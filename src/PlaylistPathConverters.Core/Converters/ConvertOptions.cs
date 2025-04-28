using PlaylistPathConverters.Core.Settings;

namespace PlaylistPathConverters.Core.Converters
{
    public class ConvertOptions : OutputProfile
    {
        /// <summary>
        /// 輸入路徑
        /// </summary>
        public string SourcePath { get; set; }


        public ConvertOptions()
        {

        }
        public ConvertOptions(string inputPath, OutputProfile output)
        {
            SourcePath = inputPath;
            ToPath = output.ToPath;
            IsWindowsFileSystem = output.IsWindowsFileSystem;
            PlaylistExtension = output.PlaylistExtension;
            HasExtendM3uTag = output.HasExtendM3uTag;
            FileExtension = output.FileExtension;
            Options = output.Options;
        }
    }
}
