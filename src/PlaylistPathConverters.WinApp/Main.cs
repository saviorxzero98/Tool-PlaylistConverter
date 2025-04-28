using Newtonsoft.Json;
using PlaylistPathConverters.Core.Converters;
using PlaylistPathConverters.Core.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PlaylistPathConverters.WinApp
{
    public partial class Main : Form
    {
        #region Constant

        public const string ConfigFile = "appsettings.json";

        #endregion Constant


        #region Property

        public string[] BasePaths { get; set; }

        public AppSetting Config { get; set; } = new AppSetting();

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
                    Config = JsonConvert.DeserializeObject<AppSetting>(settingJson);
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

            var converter = new PlaylistConverter(InputFolderText.Text, OutputFolderText.Text);
            var profile = new ConvertOptions(InputBasePathText.Text, Config.Profiles[profileName]);
            var result = converter.Convert(profile);

            MessageBox.Show(string.Format("總共：{0}；成功：{1}", result.TotalCount, result.SuccessCount));
        }

        #endregion Event
    }
}
