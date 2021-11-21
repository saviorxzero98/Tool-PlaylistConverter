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
            this.InputBasePathText = new System.Windows.Forms.ComboBox();
            this.ConfigProfile = new System.Windows.Forms.ComboBox();
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
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "設定檔：";
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
            this.ConvertBtn.Location = new System.Drawing.Point(133, 164);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(588, 32);
            this.ConvertBtn.TabIndex = 6;
            this.ConvertBtn.Text = "轉換";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
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
            // ConfigProfile
            // 
            this.ConfigProfile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConfigProfile.FormattingEnabled = true;
            this.ConfigProfile.Location = new System.Drawing.Point(134, 117);
            this.ConfigProfile.Name = "ConfigProfile";
            this.ConfigProfile.Size = new System.Drawing.Size(587, 28);
            this.ConfigProfile.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 208);
            this.Controls.Add(this.ConfigProfile);
            this.Controls.Add(this.InputBasePathText);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.OutputFolderBtn);
            this.Controls.Add(this.InputFolderBtn);
            this.Controls.Add(this.OutputFolderText);
            this.Controls.Add(this.InputFolderText);
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
        private System.Windows.Forms.ComboBox InputBasePathText;
        private System.Windows.Forms.ComboBox ConfigProfile;
    }
}

