using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;

namespace AForge.Video
{
    /// <summary>
    /// 
    /// Install-Package AForge.Video.DirectShow -Version 2.2.5
    /// 
    /// AForge.Video.FFMPEG使用VC++写的，编译的时候已经被编译成本地代码，解决方案就是不再选择使用“Any CPU”作为目标平台，改成“x86”或者“x64”（本示例使用x86）
    /// 将除 AForge.Video.FFMPEG.dll 外的所有 dll (在lib目录) 拷贝到编译后的目录
    /// 
    /// https://blog.csdn.net/m_buddy/article/details/62417912
    /// https://www.yanning.wang/archives/424.html
    /// 
    /// </summary>
    public partial class formVideo : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private VideoFileWriter videoWriter;

        public formVideo()
        {
            InitializeComponent();

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoWriter = new VideoFileWriter();

            foreach (FilterInfo device in videoDevices)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = device.Name;
                item.Value = device.Name;
                boxDevice.Items.Add(item);
            }
            boxDevice.SelectedIndex = 0;

            foreach (VideoType type in Enum.GetValues(typeof(VideoType)))
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = type.ToString();
                item.Value = type;
                boxVideoType.Items.Add(item);
            }
            boxVideoType.SelectedIndex = 0;

            buttonStop.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string deviceName = boxDevice.SelectedItem.ToString();
            string path = textPath.Text.Trim();
            int width = Convert.ToInt32(textWidth.Text.Trim());
            int height = Convert.ToInt32(textHeight.Text.Trim());
            int frameRate = Convert.ToInt32(textFrameRate.Text.Trim());
            int bitRate = Convert.ToInt32(textBitRate.Text.Trim());
            VideoType videoType = (VideoType)Enum.Parse(typeof(VideoType), boxVideoType.SelectedItem.ToString());

            if (videoDevices == null || videoDevices.Count < 1) return;

            int selectedVideoDeviceIndex = -1;
            for (int i = 0; i < videoDevices.Count; i++)
            {
                if (deviceName == videoDevices[i].Name)
                {
                    selectedVideoDeviceIndex = i;
                    break;
                }
            }

            if (selectedVideoDeviceIndex < 0) throw new Exception("video input device name not found!");

            videoSource = new VideoCaptureDevice(videoDevices[selectedVideoDeviceIndex].MonikerString);
            videoSource.NewFrame += videoNewFrame;
            videoSource.Start();

            VideoCodec videoCodec = GetVideoCode(videoType);
            path = string.Format("{0}.{1}", path, videoType);
            string dir = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) Directory.CreateDirectory(dir);

            videoWriter.Open(path, width, height, frameRate, videoCodec, bitRate);


            labelStatus.Text = "录制中...";
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }

            if (videoWriter.IsOpen) videoWriter.Close();


            labelStatus.Text = "未录制";
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
        }

        private void videoNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = eventArgs.Frame;
            videoWriter.WriteVideoFrame(bitmap);
        }

        private VideoCodec GetVideoCode(VideoType videoType)
        {
            switch (videoType)
            {
                case VideoType.avi:
                    return VideoCodec.MPEG4;
                case VideoType.wmv:
                    return VideoCodec.WMV2;
                case VideoType.flv:
                    return VideoCodec.FLV1;
                default:
                    return VideoCodec.MPEG4;
            }
        }
    }

    public enum VideoType
    {
        avi,//MPEG4 = 0,
        wmv,// WMV1 = 1, WMV2 = 2,
        flv//FLV1 = 6,
    }

    class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
