namespace PlaylistConverter
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.InputFolderLabel = new System.Windows.Forms.Label();
            this.OutputFolderLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InputFolderText = new System.Windows.Forms.TextBox();
            this.OutputFolderText = new System.Windows.Forms.TextBox();
            this.InputFolderBtn = new System.Windows.Forms.Button();
            this.OutputFolderBtn = new System.Windows.Forms.Button();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.WindowsBaseType = new System.Windows.Forms.RadioButton();
            this.LinuxBaseType = new System.Windows.Forms.RadioButton();
            this.ExtM3UCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputExtendType = new System.Windows.Forms.ComboBox();
            this.InputBasePathText = new System.Windows.Forms.ComboBox();
            this.OutputBasePathText = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MusicFileExtendType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // InputFolderLabel
            // 
            this.InputFolderLabel.AutoSize = true;
            this.InputFolderLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputFolderLabel.Location = new System.Drawing.Point(13, 13);
            this.InputFolderLabel.Name = "InputFolderLabel";
            this.InputFolderLabel.Size = new System.Drawing.Size(105, 24);
            this.InputFolderLabel.TabIndex = 0;
            this.InputFolderLabel.Text = "歌單目錄：";
            // 
            // OutputFolderLabel
            // 
            this.OutputFolderLabel.AutoSize = true;
            this.OutputFolderLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OutputFolderLabel.Location = new System.Drawing.Point(12, 49);
            this.OutputFolderLabel.Name = "OutputFolderLabel";
            this.OutputFolderLabel.Size = new System.Drawing.Size(105, 24);
            this.OutputFolderLabel.TabIndex = 1;
            this.OutputFolderLabel.Text = "輸出目錄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "原始根目錄：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "輸出根目錄：";
            // 
            // InputFolderText
            // 
            this.InputFolderText.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputFolderText.Location = new System.Drawing.Point(134, 8);
            this.InputFolderText.Name = "InputFolderText";
            this.InputFolderText.Size = new System.Drawing.Size(550, 29);
            this.InputFolderText.TabIndex = 4;
            // 
            // OutputFolderText
            // 
            this.OutputFolderText.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OutputFolderText.Location = new System.Drawing.Point(134, 44);
            this.OutputFolderText.Name = "OutputFolderText";
            this.OutputFolderText.Size = new System.Drawing.Size(550, 29);
            this.OutputFolderText.TabIndex = 4;
            // 
            // InputFolderBtn
            // 
            this.InputFolderBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputFolderBtn.Location = new System.Drawing.Point(690, 11);
            this.InputFolderBtn.Name = "InputFolderBtn";
            this.InputFolderBtn.Size = new System.Drawing.Size(31, 30);
            this.InputFolderBtn.TabIndex = 5;
            this.InputFolderBtn.Text = "...";
            this.InputFolderBtn.UseVisualStyleBackColor = true;
            this.InputFolderBtn.Click += new System.EventHandler(this.InputFolderBtn_Click);
            // 
            // OutputFolderBtn
            // 
            this.OutputFolderBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OutputFolderBtn.Location = new System.Drawing.Point(690, 47);
            this.OutputFolderBtn.Name = "OutputFolderBtn";
            this.OutputFolderBtn.Size = new System.Drawing.Size(31, 30);
            this.OutputFolderBtn.TabIndex = 5;
            this.OutputFolderBtn.Text = "...";
            this.OutputFolderBtn.UseVisualStyleBackColor = true;
            this.OutputFolderBtn.Click += new System.EventHandler(this.OutputFolderBtn_Click);
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConvertBtn.Location = new System.Drawing.Point(603, 259);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(119, 32);
            this.ConvertBtn.TabIndex = 6;
            this.ConvertBtn.Text = "轉換";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // WindowsBaseType
            // 
            this.WindowsBaseType.AutoSize = true;
            this.WindowsBaseType.Checked = true;
            this.WindowsBaseType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WindowsBaseType.Location = new System.Drawing.Point(134, 193);
            this.WindowsBaseType.Name = "WindowsBaseType";
            this.WindowsBaseType.Size = new System.Drawing.Size(89, 24);
            this.WindowsBaseType.TabIndex = 7;
            this.WindowsBaseType.TabStop = true;
            this.WindowsBaseType.Text = "Window";
            this.WindowsBaseType.UseVisualStyleBackColor = true;
            // 
            // LinuxBaseType
            // 
            this.LinuxBaseType.AutoSize = true;
            this.LinuxBaseType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LinuxBaseType.Location = new System.Drawing.Point(229, 193);
            this.LinuxBaseType.Name = "LinuxBaseType";
            this.LinuxBaseType.Size = new System.Drawing.Size(143, 24);
            this.LinuxBaseType.TabIndex = 7;
            this.LinuxBaseType.Text = "Linux / Android";
            this.LinuxBaseType.UseVisualStyleBackColor = true;
            // 
            // ExtM3UCheck
            // 
            this.ExtM3UCheck.AutoSize = true;
            this.ExtM3UCheck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExtM3UCheck.Location = new System.Drawing.Point(134, 228);
            this.ExtM3UCheck.Name = "ExtM3UCheck";
            this.ExtM3UCheck.Size = new System.Drawing.Size(120, 24);
            this.ExtM3UCheck.TabIndex = 8;
            this.ExtM3UCheck.Text = "Extend M3U";
            this.ExtM3UCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸出副檔名：";
            // 
            // OutputExtendType
            // 
            this.OutputExtendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputExtendType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OutputExtendType.FormattingEnabled = true;
            this.OutputExtendType.Items.AddRange(new object[] {
            "M3U8",
            "M3U",
            "TXT"});
            this.OutputExtendType.Location = new System.Drawing.Point(134, 153);
            this.OutputExtendType.Name = "OutputExtendType";
            this.OutputExtendType.Size = new System.Drawing.Size(247, 28);
            this.OutputExtendType.TabIndex = 9;
            // 
            // InputBasePathText
            // 
            this.InputBasePathText.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InputBasePathText.FormattingEnabled = true;
            this.InputBasePathText.Location = new System.Drawing.Point(135, 81);
            this.InputBasePathText.Name = "InputBasePathText";
            this.InputBasePathText.Size = new System.Drawing.Size(587, 28);
            this.InputBasePathText.TabIndex = 10;
            // 
            // OutputBasePathText
            // 
            this.OutputBasePathText.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OutputBasePathText.FormattingEnabled = true;
            this.OutputBasePathText.Location = new System.Drawing.Point(134, 117);
            this.OutputBasePathText.Name = "OutputBasePathText";
            this.OutputBasePathText.Size = new System.Drawing.Size(587, 28);
            this.OutputBasePathText.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "路徑格式：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(13, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "檔案標頭：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(13, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "音樂副檔名：";
            // 
            // MusicFileExtendType
            // 
            this.MusicFileExtendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MusicFileExtendType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MusicFileExtendType.FormattingEnabled = true;
            this.MusicFileExtendType.Items.AddRange(new object[] {
            "WMA",
            "MP3"});
            this.MusicFileExtendType.Location = new System.Drawing.Point(134, 259);
            this.MusicFileExtendType.Name = "MusicFileExtendType";
            this.MusicFileExtendType.Size = new System.Drawing.Size(247, 28);
            this.MusicFileExtendType.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 300);
            this.Controls.Add(this.MusicFileExtendType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OutputBasePathText);
            this.Controls.Add(this.InputBasePathText);
            this.Controls.Add(this.OutputExtendType);
            this.Controls.Add(this.ExtM3UCheck);
            this.Controls.Add(this.LinuxBaseType);
            this.Controls.Add(this.WindowsBaseType);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.OutputFolderBtn);
            this.Controls.Add(this.InputFolderBtn);
            this.Controls.Add(this.OutputFolderText);
            this.Controls.Add(this.InputFolderText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputFolderLabel);
            this.Controls.Add(this.InputFolderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "播放清單轉換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputFolderLabel;
        private System.Windows.Forms.Label OutputFolderLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InputFolderText;
        private System.Windows.Forms.TextBox OutputFolderText;
        private System.Windows.Forms.Button InputFolderBtn;
        private System.Windows.Forms.Button OutputFolderBtn;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.RadioButton WindowsBaseType;
        private System.Windows.Forms.RadioButton LinuxBaseType;
        private System.Windows.Forms.CheckBox ExtM3UCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OutputExtendType;
        private System.Windows.Forms.ComboBox InputBasePathText;
        private System.Windows.Forms.ComboBox OutputBasePathText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MusicFileExtendType;
    }
}

