using BusinessLogic;
using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Image_Operations : Form
    {
        ImageOperations imageOp = new ImageOperations();
        VideoOperations videoOp = new VideoOperations();
        AudioOperations audioOp = new AudioOperations();

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

        //red channel
        private void btnRedChannel_Click(object sender, EventArgs e)
        {
            pictureBoxRedChannel.Image = imageOp.RedChannel(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithPictures\Flowers.png");
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
            videoOp.PlayVideo(pictureBoxVideo, labelVideo);
        }

        //blending images
        private async void btnBlending_Click(object sender, EventArgs e)
        {
            imageOp.Blending(pictureBoxNormal);
        }

        //background substraction
        private void ProcessFrames(object e, EventArgs i)
        {
            pictureBoxResize.Image = videoOp.ProcessFrame();
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            try
            {
                videoOp.BackgroundSubstraction();
                Application.Idle += ProcessFrames;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //video writing
        private void btnVideoWriting_Click(object sender, EventArgs e)
        {
            videoOp.VideoWriting();
        }

        //NAudio playback
        private void btnPlayback_Click(object sender, EventArgs e)
        {
            audioOp.Playback();
        }

        //mp3 to wav
        private void btnConvertMp3ToWav_Click(object sender, EventArgs e)
        {
            audioOp.ConvertMp3ToWav();
        }

        //wav to mp3
        private void btnConvertWavToMp3_Click(object sender, EventArgs e)
        {
            audioOp.ConvertWavToMp3();
        }

        //mix audio
        private void btnMixAudio_Click(object sender, EventArgs e)
        {
            audioOp.MixAudio();
        }

        private void btnTrimm_Click(object sender, EventArgs e)
        {
            string inputAdress = @"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Audio2.wav";
            string output = @"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\TrimmedWav.wav";
            int beginning = 100;
            int ending = 500;
            audioOp.TrimWavFile(inputAdress, output, beginning, ending);
        }

        private void btnMono_Click(object sender, EventArgs e)
        {
            audioOp.MonoToStereo();
        }

        private void btnStereo_Click(object sender, EventArgs e)
        {
            audioOp.StereoToMono();
        }

        private void btnConcatenateSkipTake_Click(object sender, EventArgs e)
        {
            audioOp.ConcatenateSkipTake();
        }

        private void btnPitch_Click(object sender, EventArgs e)
        {
            audioOp.Pitch();
        }

        private void btnResampler_Click(object sender, EventArgs e)
        {
            audioOp.Resampler();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
