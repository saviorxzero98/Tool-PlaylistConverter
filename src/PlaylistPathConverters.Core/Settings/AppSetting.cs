using PlaylistPathConverters.Core.Constants;
using System.Collections.Generic;

namespace PlaylistPathConverters.Core.Settings
{
    public class AppSetting
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
        public Dictionary<string, OutputProfile> Profiles { get; set; } = new Dictionary<string, OutputProfile>();
    }

    public class OutputProfile
    {
        /// <summary>
        /// 輸出路徑
        /// </summary>
        public string ToPath { get; set; } = string.Empty;

        /// <summary>
        /// 作業系統
        /// </summary>
        public bool IsWindowsFileSystem { get; set; } = true;

        /// <summary>
        /// 播放清單檔案類型
        /// </summary>
        public string PlaylistExtension { get; set; } = FileTypes.Text;

        /// <summary>
        /// 第一列是否有 "EXTM3U" 標記
        /// </summary>
        public bool HasExtendM3uTag { get; set; } = false;

        /// <summary>
        /// 音樂檔案類型
        /// </summary>
        public string FileExtension { get; set; } = FileTypes.Wma;

        /// <summary>
        /// 其他選項
        /// </summary>
        public OutputProfileOption Options { get; set; } = new OutputProfileOption();
    }

    public class OutputProfileOption
    {
        /// <summary>
        /// 修正部分機種的排序問題
        /// </summary>
        public bool FixOrder { get; set; } = false;
    }
}
