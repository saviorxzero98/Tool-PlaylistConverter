using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaylistConverter
{
    public partial class Main : Form
    {
        public const string EXT_M3U8 = ".m3u8";
        public const string EXT_M3U = ".m3u";
        public const string EXT_TXT = ".txt";

        public const string TAG_EXTM3U = "EXTM3U";

        public Main()
        {
            InitializeComponent();
            InputFolderText.Select();
            OutputExtendType.SelectedIndex = 0;
        }

        private void InputFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            InputFolderText.Text = path.SelectedPath;
        }

        private void OutputFolderBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            OutputFolderText.Text = path.SelectedPath;
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            if (InputFolderText.Text.Length == 0 && 
                OutputFolderText.Text.Length == 0)
            {
                MessageBox.Show("請輸入路徑!!");
                return;
            }

            string[] filePaths = Directory.GetFiles(InputFolderText.Text);

            int totalCount = 0;
            int successCount = 0;
            for (int i = 0; i < filePaths.Length; i++)
            {
                string inputPath = filePaths[i];

                string fileName = Path.GetFileNameWithoutExtension(inputPath);
                string fileExt = OutputExtendType.Text.ToLower();
                string outputPath = string.Format("{0}\\{1}.{2}", OutputFolderText.Text, fileName, fileExt);

                if (Path.GetExtension(inputPath).ToLower() == EXT_M3U8 ||
                    Path.GetExtension(inputPath).ToLower() == EXT_M3U8 ||
                    Path.GetExtension(inputPath).ToLower() == EXT_TXT)
                {
                    if (Covert(inputPath, outputPath))
                    {
                        successCount++;
                    }
                    totalCount++;
                }
            }
            MessageBox.Show(string.Format("總共：{0}；成功：{1}", totalCount, successCount));
        }

        private bool Covert(string intpurPath, string outputPath)
        {
            try
            {
                StreamReader reader = new StreamReader(intpurPath);
                StreamWriter writer = new StreamWriter(outputPath);

                if (ExtM3UCheck.Checked)
                {
                    writer.WriteLine(TAG_EXTM3U);
                }

                while (!reader.EndOfStream)
                {
                    string inputLine = reader.ReadLine();

                    string outputLine = inputLine;
                    if (WindowsBaseType.Checked) outputLine = outputLine.Replace('/', '\\');
                    if (LinuxBaseType.Checked) outputLine = outputLine.Replace('\\', '/');

                    if (InputBasePathText.Text.Length != 0 && OutputBasePathText.Text.Length != 0)
                    {
                        outputLine = outputLine.Replace(InputBasePathText.Text, OutputBasePathText.Text);
                    }

                    writer.WriteLine(outputLine);
                }
                reader.Close();
                writer.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
