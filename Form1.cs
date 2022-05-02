using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form : System.Windows.Forms.Form
    {

        public Form()
        {
            InitializeComponent();
        }

        //load image
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                pictureBox1.Image = My_Image.ToBitmap();
                Image<Gray, byte> gray_image = My_Image.Convert<Gray, byte>();
                pictureBox2.Image = gray_image.AsBitmap();
                gray_image[0, 0] = new Gray(200);
            }
        }

        //generate histogram
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                HistogramViewer v = new HistogramViewer();
                v.HistogramCtrl.GenerateHistograms(My_Image, 255);
                v.Show();
            }
        }

        //brightness/contrast
        private void button3_Click(object sender, EventArgs e)
        {
            var alpha = float.Parse(textBoxAlpha.Text);
            var beta = int.Parse(textBoxBeta.Text);

            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                pictureBox3.Image = (My_Image.Mul(alpha) + beta).ToBitmap();
            }
        }

        //gamma correction
        private void button4_Click(object sender, EventArgs e)
        {
            var gamma = float.Parse(textBoxGamma.Text);
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                My_Image._GammaCorrect(gamma);
                pictureBox3.Image = My_Image.ToBitmap();
            }
        }

        //resize
        private void btnResize_Click(object sender, EventArgs e)
        {
            //var resize = float.Parse(textBoxResize.Text);
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                My_Image.Resize(1.25, Emgu.CV.CvEnum.Inter.Cubic);
                pictureBox3.Image = My_Image.ToBitmap();
            }
        }

        //rotate
        private void btnRotate_Click(object sender, EventArgs e)
        {
            var angle = 90;
            var background = new Bgr(255, 255, 255);
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                My_Image.Rotate(angle, background);
                pictureBox3.Image = My_Image.ToBitmap();
            }
        }

        //ROI
        Rectangle rect; Point StartROI; bool MouseDown;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                return;
            }
            int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
            int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
            rect = new Rectangle(Math.Min(StartROI.X, e.X),
            Math.Min(StartROI.Y, e.Y), width, height);
            Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            if (pictureBox1.Image == null || rect == Rectangle.Empty)
            { return; }
            var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
            img.ROI = rect;
            var imgROI = img.Copy();
            pictureBox2.Image = imgROI.ToBitmap();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            StartROI = e.Location;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        //video capture
        int TotalFrame, FrameNo;
        double Fps;
        bool IsReadingFrame;
        VideoCapture capture;

        //play video
        private async void ReadAllFrames()
        {
            Mat m = new Mat();
            while (IsReadingFrame == true && FrameNo < TotalFrame)
            {
                FrameNo += 1;
                var mat = capture.QueryFrame();
                pictureBox1.Image = mat.ToBitmap();
                await Task.Delay(1000 / Convert.ToInt16(Fps));
                label1.Text = FrameNo.ToString() + "/" + TotalFrame.ToString();
            }
        }

        //load video
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                capture = new VideoCapture(ofd.FileName);
                Mat m = new Mat();
                capture.Read(m);
                pictureBox1.Image = m.ToBitmap();

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
                ReadAllFrames();
            }
        }

        //background substraction
        private static VideoCapture cameraCapture;
        private Image<Bgr, Byte> newBackgroundImage;
        private static IBackgroundSubtractor fgDetector;

        //blending images
        private async void btnBlending_Click(object sender, EventArgs e)
        {
            string[] FileNames = Directory.GetFiles(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithPictures", "*.png");
            List<Image<Bgr, byte>> listImages = new List<Image<Bgr, byte>>();
            foreach (var file in FileNames)
            {
                listImages.Add(new Image<Bgr, byte>(file));
            }
            for (int i = 0; i < listImages.Count - 1; i++)
            {
                for (double alpha = 0.0; alpha <= 1.0; alpha += 0.01)
                {
                    pictureBox1.Image = listImages[i + 1].AddWeighted(listImages[i], alpha, 1 - alpha, 0).AsBitmap();
                    await Task.Delay(25);
                }
            }

        }






    }
}
