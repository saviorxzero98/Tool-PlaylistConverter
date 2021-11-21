using System.Collections.Generic;

namespace PlaylistConverter.Models
{
    public class AppSettings
    {
        /// <summary>
        /// 歌單目錄
        /// </summary>
        public string InputFolder { get; set; } = string.Empty;

        /// <summary>
        /// 輸出目錄
        /// </summary>
        public string OutputFolder { get; set; } = string.Empty;

        /// <summary>
        /// 原始根目錄
        /// </summary>
        public List<string> Paths { get; set; } = new List<string>();

        /// <summary>
        /// 設定檔
        /// </summary>
        public Dictionary<string, ConfigProfile> Profiles { get; set; } = new Dictionary<string, ConfigProfile>();
    }

    public class ConfigProfile
    {
        /// <summary>
        /// 路徑
        /// </summary>
        public string ToPath { get; set; } = string.Empty;

        /// <summary>
        /// 作業系統
        /// </summary>
        public bool IsWindowsFileSystem { get; set; } = true;

        /// <summary>
        /// 播放清單檔案類型
        /// </summary>
        public string PlaylistExtension { get; set; } = FileType.TXT;

        /// <summary>
        /// 第一列是否有 "EXTM3U" 標記
        /// </summary>
        public bool HasExtendM3uTag { get; set; } = false;

        /// <summary>
        /// 音樂檔案類型
        /// </summary>
        public string FileExtension { get; set; } = FileType.WMA;

        /// <summary>
        /// 其他選項
        /// </summary>
        public ConfigProfileOption Options { get; set; } = new ConfigProfileOption();
    }

    public class ConfigProfileOption
    {
        /// <summary>
        /// 修正部分機種的排序問題
        /// </summary>
        public bool FixOrder { get; set; } = false;
    }

    public static class FileType
    {
        /// <summary>
        /// 文字檔
        /// </summary>
        public const string TXT = "txt";

        /// <summary>
        /// M3U檔
        /// </summary>
        public const string M3U = "m3u";

        /// <summary>
        /// M3U8檔
        /// </summary>
        public const string M3U8 = "m3u8";


        /// <summary>
        /// WMA檔
        /// </summary>
        public const string WMA = "wma";

        /// <summary>
        /// MP3檔
        /// </summary>
        public const string MP3 = "mp3";
    }

    public static class FileExtensionType
    {
        /// <summary>
        /// 文字檔
        /// </summary>
        public const string TXT = ".txt";

        /// <summary>
        /// M3U檔
        /// </summary>
        public const string M3U = ".m3u";

        /// <summary>
        /// M3U8檔
        /// </summary>
        public const string M3U8 = ".m3u8";


        /// <summary>
        /// WMA檔
        /// </summary>
        public const string WMA = ".wma";

        /// <summary>
        /// MP3檔
        /// </summary>
        public const string MP3 = ".mp3";
    }
}