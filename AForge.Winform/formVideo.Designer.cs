namespace AForge.Winform
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
            this.panelVideoSourcePlayer = new System.Windows.Forms.Panel();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.btnCapture = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelVideoSourcePlayer.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVideoSourcePlayer
            // 
            this.panelVideoSourcePlayer.Controls.Add(this.videoSourcePlayer);
            this.panelVideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVideoSourcePlayer.Location = new System.Drawing.Point(0, 0);
            this.panelVideoSourcePlayer.Name = "panelVideoSourcePlayer";
            this.panelVideoSourcePlayer.Size = new System.Drawing.Size(828, 566);
            this.panelVideoSourcePlayer.TabIndex = 0;
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(828, 566);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // panelToolbar
            // 
            this.panelToolbar.Controls.Add(this.btnCapture);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelToolbar.Location = new System.Drawing.Point(0, 566);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(828, 81);
            this.panelToolbar.TabIndex = 1;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(313, 17);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(91, 52);
            this.btnCapture.TabIndex = 5;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelVideoSourcePlayer);
            this.panelContainer.Controls.Add(this.panelToolbar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(828, 647);
            this.panelContainer.TabIndex = 2;
            // 
            // formVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 647);
            this.Controls.Add(this.panelContainer);
            this.Name = "formVideo";
            this.Text = "Video";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formVideo_FormClosing);
            this.panelVideoSourcePlayer.ResumeLayout(false);
            this.panelToolbar.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVideoSourcePlayer;
        private Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnCapture;
    }
}