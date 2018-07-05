namespace AForge.Video
{
    partial class formVideo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.boxDevice = new System.Windows.Forms.ComboBox();
            this.boxVideoType = new System.Windows.Forms.ComboBox();
            this.textPath = new System.Windows.Forms.TextBox();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textFrameRate = new System.Windows.Forms.TextBox();
            this.textBitRate = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "视频输入设备：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "视频后缀(格式)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "保存路径+文件名(不含后缀)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "视频宽(需与视频源一致)：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "视频高(需与视频源一致)：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "帧率：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "比特率：";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(233, 317);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 12);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "未录制";
            // 
            // boxDevice
            // 
            this.boxDevice.FormattingEnabled = true;
            this.boxDevice.Location = new System.Drawing.Point(205, 24);
            this.boxDevice.Name = "boxDevice";
            this.boxDevice.Size = new System.Drawing.Size(266, 20);
            this.boxDevice.TabIndex = 8;
            // 
            // boxVideoType
            // 
            this.boxVideoType.FormattingEnabled = true;
            this.boxVideoType.Location = new System.Drawing.Point(205, 61);
            this.boxVideoType.Name = "boxVideoType";
            this.boxVideoType.Size = new System.Drawing.Size(266, 20);
            this.boxVideoType.TabIndex = 9;
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(205, 98);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(266, 21);
            this.textPath.TabIndex = 10;
            this.textPath.Text = "D:\\test\\123456";
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(205, 136);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(266, 21);
            this.textWidth.TabIndex = 11;
            this.textWidth.Text = "1920";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(205, 172);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(266, 21);
            this.textHeight.TabIndex = 12;
            this.textHeight.Text = "1080";
            // 
            // textFrameRate
            // 
            this.textFrameRate.Location = new System.Drawing.Point(205, 210);
            this.textFrameRate.Name = "textFrameRate";
            this.textFrameRate.Size = new System.Drawing.Size(266, 21);
            this.textFrameRate.TabIndex = 13;
            this.textFrameRate.Text = "29";
            // 
            // textBitRate
            // 
            this.textBitRate.Location = new System.Drawing.Point(205, 255);
            this.textBitRate.Name = "textBitRate";
            this.textBitRate.Size = new System.Drawing.Size(266, 21);
            this.textBitRate.TabIndex = 14;
            this.textBitRate.Text = "5942000";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(64, 312);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 15;
            this.buttonStart.Text = "开始录制";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(396, 312);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 16;
            this.buttonStop.Text = "停止录制";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // formVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 356);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBitRate);
            this.Controls.Add(this.textFrameRate);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.boxVideoType);
            this.Controls.Add(this.boxDevice);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formVideo";
            this.Text = "formVideo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox boxDevice;
        private System.Windows.Forms.ComboBox boxVideoType;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textFrameRate;
        private System.Windows.Forms.TextBox textBitRate;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
    }
}