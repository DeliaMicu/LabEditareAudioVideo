using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class VideoOperations
    {
        int TotalFrame, FrameNo;
        double Fps;
        bool IsReadingFrame;
        VideoCapture capture;
        private static VideoCapture cameraCapture;
        private static IBackgroundSubtractor fgDetector;
        private static Image<Bgr, Byte> newBackgroundImage = new Image<Bgr, byte>(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithPictures\flowers.png");

        private async void ReadAllFrames(PictureBox videoBox, Label label1)
        {
            Mat m = new Mat();
            while (IsReadingFrame == true && FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = capture.QueryFrame();
                videoBox.Image = mat.ToBitmap();
                await Task.Delay(1000 / Convert.ToInt16(Fps));
                label1.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
            }
        }

        public void PlayVideo(PictureBox videoBox, Label label1)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                Mat m = new Mat();
                capture.Read(m);
                videoBox.Image = m.ToBitmap();

                TotalFrame = (int)capture.Get(CapProp.FrameCount);
                Fps = capture.Get(CapProp.Fps);
                FrameNo = 1;

                NumericUpDown numericUpDown1 = new NumericUpDown();
                NumericUpDown numericUpDown2 = new NumericUpDown();
                NumericUpDown numericUpDown3 = new NumericUpDown();

                numericUpDown1.Value = FrameNo;
                numericUpDown1.Minimum = 0;
                numericUpDown1.Maximum = TotalFrame;

                if (capture == null)
                {
                    return;
                }
                IsReadingFrame = true;
                ReadAllFrames(videoBox, label1);
            }
        }

        public void BackgroundSubstraction()
        {
            cameraCapture = new VideoCapture();
            fgDetector = new BackgroundSubtractorMOG2();
        }

        public Bitmap ProcessFrame()
        {
            if (newBackgroundImage != null)
            {
                Mat frame = cameraCapture.QueryFrame();
                Image<Bgr, byte> frameImage = frame.ToImage<Bgr, Byte>();

                Mat foregroundMask = new Mat();
                fgDetector.Apply(frame, foregroundMask);
                var foregroundMaskImage = foregroundMask.ToImage<Gray, Byte>();
                foregroundMaskImage = foregroundMaskImage.Not();
                //newBackgroundImage = frame.ToImage<Bgr, Byte>();

                var copyOfNewBackgroundImage = newBackgroundImage.Resize(foregroundMaskImage.Width, foregroundMaskImage.Height, Inter.Lanczos4);
                copyOfNewBackgroundImage = copyOfNewBackgroundImage.Copy(foregroundMaskImage);

                foregroundMaskImage = foregroundMaskImage.Not();
                frameImage = frameImage.Copy(foregroundMaskImage);
                frameImage = frameImage.Or(copyOfNewBackgroundImage);
                return frameImage.AsBitmap();
            }
            else
            {
                Mat frame = cameraCapture.QueryFrame();
                Image<Bgr, byte> frameImage = frame.ToImage<Bgr, Byte>();
                return frameImage.AsBitmap();
            }
        }

        public void VideoWriting()
        {
            VideoCapture capture = new VideoCapture(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\StarWars2.mp4");

            int Fourcc = Convert.ToInt32(capture.Get(CapProp.FourCC));
            int Width = Convert.ToInt32(capture.Get(CapProp.FrameWidth));
            int Height = Convert.ToInt32(capture.Get(CapProp.FrameHeight));
            var Fps = capture.Get(CapProp.Fps);
            var TotalFrame = capture.Get(CapProp.FrameCount);


            string destionpath = @"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\VideoWriting.mpg";
            using (VideoWriter writer = new VideoWriter(destionpath, Fourcc, Fps, new Size(Width, Height), true))
            {
                Image<Bgr, byte> logo = new Image<Bgr, byte>(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithPictures\logo.jpg");
                Mat m = new Mat();

                var FrameNo = 1;
                while (FrameNo < TotalFrame)
                {
                    capture.Read(m);
                    Image<Bgr, byte> img = m.ToImage<Bgr, byte>();
                    img.ROI = new Rectangle(Width - logo.Width - 30, 10, logo.Width, logo.Height);
                    logo.CopyTo(img);

                    img.ROI = Rectangle.Empty;

                    writer.Write(img.Mat);
                    FrameNo++;
                }
            }
        }
    }

    

}
