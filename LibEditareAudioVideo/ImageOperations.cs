﻿using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class ImageOperations
    {

        Rectangle rect;
        Point StartROI;
        bool mouseDown;

        int TotalFrame, FrameNo;
        double Fps;
        bool IsReadingFrame;
        VideoCapture capture;

        public void ConvertToGrayScale(PictureBox imgOriginala, PictureBox imgAlbNegru)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                imgOriginala.Image = My_Image.ToBitmap();
                //Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                Image<Gray, byte> gray_image = My_Image.Convert<Gray, byte>();
                imgAlbNegru.Image = gray_image.AsBitmap();
                gray_image[0, 0] = new Gray(200);
            }
        }

        public void MakeHistogram()
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

        public void ChangeBrigthnessAndContrast(PictureBox imgContrastCorrection, TextBox Alpha, TextBox Beta)
        {
            var alpha = float.Parse(Alpha.Text);
            var beta = float.Parse(Beta.Text);

            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                imgContrastCorrection.Image = (My_Image.Mul(alpha) + beta).ToBitmap();
            }
        }

        public void GammaCorrection(TextBox Gamma, PictureBox imgContrastCorrection)
        {
            var gamma = float.Parse(Gamma.Text);

            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                My_Image._GammaCorrect(gamma);
                imgContrastCorrection.Image = My_Image.ToBitmap();
            }
        }

        public void Resize(TextBox Resize, PictureBox imgResizeRotate)
        {
            var r = float.Parse(Resize.Text);
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                My_Image.Resize(r, Emgu.CV.CvEnum.Inter.Cubic);
                imgResizeRotate.Image = My_Image.ToBitmap();
            }
        }

        public void Rotate(TextBox Rotate, PictureBox imgResizeRotate)
        {
            var r = float.Parse(Rotate.Text);
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> My_Image = new Image<Bgr, byte>(Openfile.FileName);
                var img_rotate = My_Image.Rotate(r, new Bgr(Color.FromArgb(0, 0, 1)));
                imgResizeRotate.Image = img_rotate.ToBitmap();
            }
        }

        public void MouseMove(MouseEventArgs e, PictureBox imgOriginala)
        {
            if (imgOriginala.Image == null)
            {
                return;
            }
            int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
            int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
            rect = new Rectangle(Math.Min(StartROI.X, e.X),
            Math.Min(StartROI.Y, e.Y), width, height);
        }

        public void MouseUp(PictureBox imgOriginala, PictureBox imgAlbNegru)
        {
            mouseDown = false;
            if (imgOriginala.Image == null || rect == Rectangle.Empty)
            { return; }
            var img = new Bitmap(imgOriginala.Image).ToImage<Bgr, byte>();
            img.ROI = rect;
            var imgROI = img.Copy();
            imgAlbNegru.Image = imgROI.ToBitmap();
        }

        public void MouseDown(MouseEventArgs e)
        {
            mouseDown = true;
            StartROI = e.Location;
        }

        public void Paint(PaintEventArgs e)
        {
            if (mouseDown)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        public async void Blending(PictureBox imgOriginala)
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
                    imgOriginala.Image = listImages[i + 1].AddWeighted(listImages[i], alpha, 1 - alpha, 0).AsBitmap();
                    await Task.Delay(25);
                }
            }
        }

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
    }
}
