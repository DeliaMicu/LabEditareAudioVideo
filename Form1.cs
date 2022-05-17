using BusinessLogic;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Image_Operations : Form
    {
        ImageOperations imageOp = new ImageOperations();

        public Image_Operations()
        {
            InitializeComponent();
        }

        //load image
        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            imageOp.ConvertToGrayScale(pictureBoxNormal, pictureBoxBlackWhite);
        }

        //generate histogram
        private void btnMakeHistogram_Click(object sender, EventArgs e)
        {
            imageOp.MakeHistogram();
        }

        //brightness/contrast
        private void btnBrightness_Click(object sender, EventArgs e)
        {
            imageOp.ChangeBrigthnessAndContrast(pictureBoxBrightness, textBoxAlpha, textBoxBeta);
        }

        //gamma correction
        private void btnGammaCorrection_Click(object sender, EventArgs e)
        {
            imageOp.GammaCorrection(textBoxGamma, pictureBoxBrightness);
        }

        //resize
        private void btnResize_Click(object sender, EventArgs e)
        {
            imageOp.Resize(textBoxResize, pictureBoxResize);
        }

        //rotate
        private void btnRotate_Click(object sender, EventArgs e)
        {
            imageOp.Rotate(textBoxRotate, pictureBoxResize);
        }

        //ROI
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            imageOp.MouseMove(e, pictureBoxNormal);
            Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            imageOp.MouseUp(pictureBoxNormal, pictureBoxBlackWhite);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            imageOp.MouseDown(e);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            imageOp.Paint(e);
        }

        //load video
        private void btnLoadVideo_Click(object sender, EventArgs e)
        {
            imageOp.PlayVideo(pictureBoxNormal, labelVideo);
        }

        //blending images
        private async void btnBlending_Click(object sender, EventArgs e)
        {
            imageOp.Blending(pictureBoxNormal);
        }

        //background substraction
        private static VideoCapture cameraCapture;
        private Image<Bgr, Byte> newBackgroundImage;
        private static IBackgroundSubtractor fgDetector;

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            //cameraCapture = new VideoCapture();
            //Mat frame = cameraCapture.QueryFrame();
            //Image<Bgr, byte> frameImage = frame.ToImage<Bgr, Byte>();
            //fgDetector = new BackgroundSubtractorMOG2();
            //Mat foregroundMask = new Mat();
            //fgDetector.Apply(frame, foregroundMask);
            //var foregroundMaskImage = foregroundMask.ToImage<Gray, Byte>();
            //foregroundMaskImage = foregroundMaskImage.Not();

            //var copyOfNewBackgroundImage = newBackgroundImage.Resize(foregroundMaskImage.Width, foregroundMaskImage.Height, Inter.Lanczos4);
            //copyOfNewBackgroundImage = copyOfNewBackgroundImage.Copy(foregroundMaskImage);

            //foregroundMaskImage = foregroundMaskImage.Not();
            //frameImage = frameImage.Copy(foregroundMaskImage);
            //frameImage = frameImage.Or(copyOfNewBackgroundImage);

            //try
            //{
            //    cameraCapture = new VideoCapture();
            //    fgDetector = new BackgroundSubtractorMOG2();
            //    Application.Idle += ProcessFrames;
            //}
            //catch (NullReferenceException excpt)
            //{
            //    MessageBox.Show(excpt.Message);
            //}
        }

        //video writing
        private void btnVideoWriting_Click(object sender, EventArgs e)
        {
            VideoCapture capture = new VideoCapture(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\StarWars2.mp4");

            int Fourcc = Convert.ToInt32(capture.Get(CapProp.FourCC));
            int Width = Convert.ToInt32(capture.Get(CapProp.FrameWidth));
            int Height = Convert.ToInt32(capture.Get(CapProp.FrameHeight));
            var Fps = capture.Get(CapProp.Fps);
            var TotalFrame = capture.Get(CapProp.FrameCount);


            string destionpath = @"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5";
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
