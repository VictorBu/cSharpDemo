using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace AForge.Winform
{
    /// <summary>
    /// 
    /// Install-Package AForge.Controls -Version 2.2.5
    /// Install-Package AForge.Video.DirectShow -Version 2.2.5
    /// 
    /// </summary>
    public partial class formVideo : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private readonly string imagePath = @"D:\temp\images";

        public formVideo()
        {
            InitializeComponent();

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices != null && videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSourcePlayer.VideoSource = videoSource;

                videoSource.Start();
            }

            Task.Run(() =>
            {
                if (!Directory.Exists(imagePath)) Directory.CreateDirectory(imagePath);
            });
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                Bitmap bitmap = videoSourcePlayer.GetCurrentVideoFrame();
                string savePath = Path.Combine(imagePath, Guid.NewGuid() + ".jpg");
                bitmap.Save(savePath, ImageFormat.Jpeg);
            }
        }

        private void formVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}
