using PlaylistPathConverters.Core.Constants;
using PlaylistPathConverters.Core.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PlaylistPathConverters.Core.Converters
{
    public class PlaylistConverter
    {
        public string InputFolder { get; set; }

        public string InputFileExtensionType { get; set; } = FileExtensionTypes.M3u8;

        public string OutputFolder { get; set; }

        public PlaylistConverter(string inputFolder, string outputFolder)
        {
            InputFolder = inputFolder;
            OutputFolder = outputFolder;
        }

        /// <summary>
        /// 轉換
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public virtual ConvertResult Convert(ConvertOptions options)
        {
            try
            {
                var result = new ConvertResult();
                var inputFiles = Directory.GetFiles(InputFolder, $"*{InputFileExtensionType}", SearchOption.AllDirectories);

                foreach (var inputFile in inputFiles)
                {
                    var inputLines = ReadFileLines(inputFile);

                    if (inputLines.Count == 0)
                    {
                        result.AddFailure(inputFile);
                    }

                    var outputLines = ConvertLines(inputLines, options);

                    var outputFile = GetOutputFilePath(InputFolder, inputFile, OutputFolder, options);

                    var isSuccess = WriteFileLines(outputLines, outputFile);
                    if (isSuccess)
                    {
                        result.AddSuccess(inputFile);
                    }
                    else
                    {
                        result.AddFailure(inputFile);
                    }
                }
                return result;
            }
            catch
            {
                return new ConvertResult();
            }
        }

        /// <summary>
        /// 讀取檔案
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        protected virtual List<string> ReadFileLines(string filePath)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                return lines.ToList();
            }
            return new List<string>();
        }

        /// <summary>
        /// 內容轉換
        /// </summary>
        /// <param name="inputLines"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        protected virtual List<string> ConvertLines(List<string> inputLines, ConvertOptions options)
        {
            if (inputLines == null || !inputLines.Any())
            {
                return new List<string>();
            }

            List<string> outputLines = new List<string>();

            // 第一列是否有 "#EXTM3U" 標記
            if (options.HasExtendM3uTag)
            {
                outputLines.Add(MediaTags.ExtendM3u);
            }

            // 路徑轉換
            foreach (string inputLine in inputLines)
            {
                var outputLine = ConvertLine(inputLine, options);

                if (!string.IsNullOrEmpty(outputLine))
                {
                    outputLines.Add(outputLine);
                }
            }

            // 修正部分機種的排序問題
            if (options.Options != null &&
                options.Options.FixOrder)
            {
                outputLines.Insert(0, outputLines.LastOrDefault());
                int lastIndex = (outputLines.Count - 1);
                outputLines.RemoveAt(lastIndex);
            }
            return outputLines;
        }

        /// <summary>
        /// 內容轉換
        /// </summary>
        /// <param name="inputLine"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        protected virtual string ConvertLine(string inputLine, ConvertOptions options)
        {
            string outputLine = inputLine;

            if (inputLine == MediaTags.Foobar2000Head)
            {
                return string.Empty;
            }

            // 檢查路徑
            if (!string.IsNullOrWhiteSpace(options.SourcePath) &&
                !string.IsNullOrWhiteSpace(options.ToPath))
            {
                outputLine = outputLine.Replace(options.SourcePath, options.ToPath);
            }

            // 檔案路徑系統
            if (options.IsWindowsFileSystem)
            {
                outputLine = outputLine.Replace('/', '\\');
            }
            else
            {
                outputLine = outputLine.Replace('\\', '/');
            }

            // 音樂檔案類型
            switch (options.FileExtension.ToLower())
            {
                case FileTypes.Mp3:
                    outputLine = Path.ChangeExtension(outputLine, FileExtensionTypes.Mp3);
                    break;

                case FileTypes.Wma:
                    outputLine = Path.ChangeExtension(outputLine, FileExtensionTypes.Wma);
                    break;
            }

            return outputLine;
        }

        /// <summary>
        /// 取得輸出路徑
        /// </summary>
        /// <param name="inputFolder"></param>
        /// <param name="inputFilePath"></param>
        /// <param name="outputFolder"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        protected virtual string GetOutputFilePath(string inputFolder, string inputFilePath, string outputFolder, ConvertOptions options)
        {
            string relativePath = PathHelper.GetRelativePath(inputFilePath, inputFolder);

            string outputFilePath = PathHelper.ToAbsolutePath(relativePath, outputFolder);

            string destinationFolder = Path.GetDirectoryName(outputFilePath);
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            return Path.ChangeExtension(outputFilePath, options.PlaylistExtension.ToLower());
        }

        /// <summary>
        /// 輸出檔案
        /// </summary>
        /// <param name="outputLines"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        protected virtual bool WriteFileLines(List<string> outputLines, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(File.Open(filePath, FileMode.Create), Encoding.UTF8))
                {
                    foreach (var outputLine in outputLines)
                    {
                        writer.WriteLine(outputLine);
                    }

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
