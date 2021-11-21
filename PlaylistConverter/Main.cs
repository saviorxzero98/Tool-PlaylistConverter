using Newtonsoft.Json;
using PlaylistConverter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlaylistConverter
{
    public partial class Main : Form
    {
        #region Constant

        public const string EXT_M3U8 = ".m3u8";
        public const string EXT_M3U = ".m3u";
        public const string EXT_TXT = ".txt";

        public const string TAG_EXTM3U = "EXTM3U";

        public const string CONFIG_FILE_NAME = ".\\setting.ini";

        public const string DEFAULT_PATH = "${Path}";

        public const string TagExtM3U = "EXTM3U";
        public const string ConfigFile = "appsettings.json";

        #endregion Constant


        #region Property

        public string[] BasePaths { get; set; }

        public AppSettings Config { get; set; } = new AppSettings();

        #endregion Property


        public Main()
        {
            InitializeComponent();
            
            // 讀取檔案
            ReadConfig();

            // 初始化 歌單目錄
            InputFolderText.Select();
            InputFolderText.Text = Config.InputFolder;

            // 初始化 輸出目錄
            OutputFolderText.Text = Config.OutputFolder;

            // 初始化 原始根目錄
            List<string> paths = Config.Paths;
            foreach (var path in paths)
            {
                InputBasePathText.Items.Add(path);
            }
            InputBasePathText.SelectedIndex = 0;

            // 初始化 設定檔
            List<string> profiles = Config.Profiles.Keys.ToList();
            foreach (var profile in profiles)
            {
                ConfigProfile.Items.Add(profile);
            }
            ConfigProfile.SelectedIndex = 0;
        }

        /// <summary>
        /// 讀取設定檔
        /// </summary>
        private void ReadConfig()
        {
            if (File.Exists(ConfigFile))
            {
                using (StreamReader reader = new StreamReader(ConfigFile))
                {
                    string settingJson = reader.ReadToEnd();
                    Config = JsonConvert.DeserializeObject<AppSettings>(settingJson);
                }
            }
        }

        #region Event

        /// <summary>
        /// 選擇來源目錄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();

            // 設定預設目錄
            if (!string.IsNullOrEmpty(InputFolderText.Text) && 
                Directory.Exists(InputFolderText.Text))
            {
                path.SelectedPath = Config.InputFolder;
            }

            // 顯示目錄選擇視窗
            path.ShowDialog();

            // 取得設定值
            InputFolderText.Text = path.SelectedPath;
            Config.InputFolder = InputFolderText.Text;
        }

        /// <summary>
        /// 選擇輸出目錄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutputFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();

            // 設定預設目錄
            if (!string.IsNullOrEmpty(OutputFolderText.Text) &&
                Directory.Exists(OutputFolderText.Text))
            {
                path.SelectedPath = Config.InputFolder;
            }

            // 顯示目錄選擇視窗
            path.ShowDialog();

            // 取得設定值
            OutputFolderText.Text = path.SelectedPath;
            Config.OutputFolder = OutputFolderText.Text;
        }

        /// <summary>
        /// 執行轉換
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            if (InputFolderText.Text.Length == 0 &&
                OutputFolderText.Text.Length == 0)
            {
                MessageBox.Show("請輸入路徑!!");
                return;
            }

            string profileName = ConfigProfile.Text;
            if (!Config.Profiles.ContainsKey(profileName))
            {
                MessageBox.Show("找不到指定的設定檔!!");
                return;
            }

            int totalCount = 0;
            int successCount = 0;

            ConfigProfile profile = Config.Profiles[profileName];
            string[] filePaths = Directory.GetFiles(InputFolderText.Text);

            for (int i = 0; i < filePaths.Length; i++)
            {
                string inputPath = filePaths[i];

                string fileName = Path.GetFileNameWithoutExtension(inputPath);
                string fileExt = profile.PlaylistExtension.ToLower();
                string outputPath = $"{OutputFolderText.Text}\\{fileName}.{fileExt}";

                if (Covert(inputPath, outputPath, profile))
                {
                    successCount++;
                }
                totalCount++;
            }
            MessageBox.Show(string.Format("總共：{0}；成功：{1}", totalCount, successCount));
        }

        #endregion Event


        #region Operator

        /// <summary>
        /// 轉換
        /// </summary>
        /// <param name="inputPath"></param>
        /// <param name="outputPath"></param>
        /// <param name="profile"></param>
        /// <returns></returns>
        private bool Covert(string inputPath, string outputPath, ConfigProfile profile)
        {
            try
            {
                if (string.IsNullOrEmpty(inputPath) ||
                    string.IsNullOrEmpty(outputPath) ||
                    profile == null)
                {
                    return false;
                }

                List<string> playlist = ReadInputPlaylist(inputPath, profile);
                return WriteOutputPlaylist(outputPath, playlist, profile);
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 讀取播放清單
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="profile"></param>
        /// <returns></returns>
        private List<string> ReadInputPlaylist(string inputPath, ConfigProfile profile)
        {
            List<string> playList = new List<string>();

            if (File.Exists(inputPath))
            {
                using (var reader = new StreamReader(inputPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string inputLine = reader.ReadLine();

                        string outputLine = inputLine;

                        // 檢查路徑
                        if (InputBasePathText.Text.Length != 0 &&
                            profile.ToPath.Length != 0)
                        {
                            outputLine = outputLine.Replace(InputBasePathText.Text, profile.ToPath);
                        }

                        // 檔案路徑系統
                        if (profile.IsWindowsFileSystem)
                        {
                            outputLine = outputLine.Replace('/', '\\');
                        }
                        else
                        {
                            outputLine = outputLine.Replace('\\', '/');
                        }

                        // 音樂檔案類型
                        switch (profile.FileExtension.ToLower())
                        {
                            case FileType.MP3:
                                outputLine = Path.ChangeExtension(outputLine, FileExtensionType.MP3);
                                break;

                            case FileType.WMA:
                                outputLine = Path.ChangeExtension(outputLine, FileExtensionType.WMA);
                                break;
                        }

                        playList.Add(outputLine);
                    }
                }
            }
            return playList;
        }

        /// <summary>
        /// 寫入播放清單
        /// </summary>
        /// <param name="outputPath"></param>
        /// <param name="playlist"></param>
        /// <param name="profile"></param>
        private bool WriteOutputPlaylist(string outputPath, List<string> playlist, ConfigProfile profile)
        {
            if (playlist == null || !playlist.Any())
            {
                return false;
            }


            // 修正部分機種的排序問題
            if (profile.Options != null &&
                profile.Options.FixOrder)
            {
                playlist.Insert(0, playlist.LastOrDefault());
                int lastIndex = (playlist.Count - 1);
                playlist.RemoveAt(lastIndex);
            }

            using (StreamWriter writer = new StreamWriter(File.Open(outputPath, FileMode.Create), Encoding.UTF8))
            {
                // 第一列是否有 "EXTM3U" 標記
                if (profile.HasExtendM3uTag)
                {
                    writer.WriteLine(TagExtM3U);
                }

                foreach (var item in playlist)
                {
                    writer.WriteLine(item);
                }
            }

            return true;
        }

        #endregion Operator
    }
}
