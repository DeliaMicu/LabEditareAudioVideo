
namespace Lab5
{
    partial class Image_Operations
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
            this.btnLoadPicture = new System.Windows.Forms.Button();
            this.pictureBoxNormal = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlackWhite = new System.Windows.Forms.PictureBox();
            this.btnMakeHistogram = new System.Windows.Forms.Button();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.pictureBoxBrightness = new System.Windows.Forms.PictureBox();
            this.btnBrightness = new System.Windows.Forms.Button();
            this.btnGammaCorrection = new System.Windows.Forms.Button();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.labelBeta = new System.Windows.Forms.Label();
            this.labelGamma = new System.Windows.Forms.Label();
            this.labelResize = new System.Windows.Forms.Label();
            this.textBoxResize = new System.Windows.Forms.TextBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnLoadVideo = new System.Windows.Forms.Button();
            this.labelVideo = new System.Windows.Forms.Label();
            this.btnBlending = new System.Windows.Forms.Button();
            this.textBoxRotate = new System.Windows.Forms.TextBox();
            this.labelRotate = new System.Windows.Forms.Label();
            this.pictureBoxResize = new System.Windows.Forms.PictureBox();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnVideoWriting = new System.Windows.Forms.Button();
            this.btnPlayback = new System.Windows.Forms.Button();
            this.btnConvertMp3ToWav = new System.Windows.Forms.Button();
            this.btnConvertWavToMp3 = new System.Windows.Forms.Button();
            this.btnMixAudio = new System.Windows.Forms.Button();
            this.btnTrimm = new System.Windows.Forms.Button();
            this.btnMono = new System.Windows.Forms.Button();
            this.btnStereo = new System.Windows.Forms.Button();
            this.btnRedChannel = new System.Windows.Forms.Button();
            this.pictureBoxRedChannel = new System.Windows.Forms.PictureBox();
            this.btnConcatenateSkipTake = new System.Windows.Forms.Button();
            this.btnPitch = new System.Windows.Forms.Button();
            this.btnResampler = new System.Windows.Forms.Button();
            this.labelAudioOp = new System.Windows.Forms.Label();
            this.pictureBoxVideo = new System.Windows.Forms.PictureBox();
            this.labelImageOp = new System.Windows.Forms.Label();
            this.labelVideoOp = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlackWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadPicture.Location = new System.Drawing.Point(462, 126);
            this.btnLoadPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(227, 54);
            this.btnLoadPicture.TabIndex = 0;
            this.btnLoadPicture.Text = "LOAD PICTURE";
            this.btnLoadPicture.UseVisualStyleBackColor = true;
            this.btnLoadPicture.Click += new System.EventHandler(this.btnLoadPicture_Click);
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.Location = new System.Drawing.Point(24, 13);
            this.pictureBoxNormal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(376, 243);
            this.pictureBoxNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNormal.TabIndex = 1;
            this.pictureBoxNormal.TabStop = false;
            this.pictureBoxNormal.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBoxNormal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxNormal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBoxNormal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBoxBlackWhite
            // 
            this.pictureBoxBlackWhite.Location = new System.Drawing.Point(24, 275);
            this.pictureBoxBlackWhite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxBlackWhite.Name = "pictureBoxBlackWhite";
            this.pictureBoxBlackWhite.Size = new System.Drawing.Size(376, 239);
            this.pictureBoxBlackWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBlackWhite.TabIndex = 2;
            this.pictureBoxBlackWhite.TabStop = false;
            // 
            // btnMakeHistogram
            // 
            this.btnMakeHistogram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeHistogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMakeHistogram.Location = new System.Drawing.Point(462, 188);
            this.btnMakeHistogram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakeHistogram.Name = "btnMakeHistogram";
            this.btnMakeHistogram.Size = new System.Drawing.Size(227, 54);
            this.btnMakeHistogram.TabIndex = 3;
            this.btnMakeHistogram.Text = "MAKE HISTOGRAM";
            this.btnMakeHistogram.UseVisualStyleBackColor = true;
            this.btnMakeHistogram.Click += new System.EventHandler(this.btnMakeHistogram_Click);
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(550, 414);
            this.textBoxAlpha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(55, 26);
            this.textBoxAlpha.TabIndex = 4;
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.Location = new System.Drawing.Point(550, 448);
            this.textBoxBeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(55, 26);
            this.textBoxBeta.TabIndex = 5;
            // 
            // pictureBoxBrightness
            // 
            this.pictureBoxBrightness.Location = new System.Drawing.Point(453, 561);
            this.pictureBoxBrightness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxBrightness.Name = "pictureBoxBrightness";
            this.pictureBoxBrightness.Size = new System.Drawing.Size(376, 206);
            this.pictureBoxBrightness.TabIndex = 6;
            this.pictureBoxBrightness.TabStop = false;
            // 
            // btnBrightness
            // 
            this.btnBrightness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrightness.Location = new System.Drawing.Point(647, 396);
            this.btnBrightness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(162, 66);
            this.btnBrightness.TabIndex = 7;
            this.btnBrightness.Text = "BRIGHTNESS";
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // btnGammaCorrection
            // 
            this.btnGammaCorrection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGammaCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGammaCorrection.Location = new System.Drawing.Point(647, 467);
            this.btnGammaCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGammaCorrection.Name = "btnGammaCorrection";
            this.btnGammaCorrection.Size = new System.Drawing.Size(162, 68);
            this.btnGammaCorrection.TabIndex = 8;
            this.btnGammaCorrection.Text = "GAMMA CORR.";
            this.btnGammaCorrection.UseVisualStyleBackColor = true;
            this.btnGammaCorrection.Click += new System.EventHandler(this.btnGammaCorrection_Click);
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(550, 482);
            this.textBoxGamma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(55, 26);
            this.textBoxGamma.TabIndex = 9;
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlpha.Location = new System.Drawing.Point(476, 415);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(74, 25);
            this.labelAlpha.TabIndex = 10;
            this.labelAlpha.Text = "Alpha: ";
            // 
            // labelBeta
            // 
            this.labelBeta.AutoSize = true;
            this.labelBeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBeta.Location = new System.Drawing.Point(486, 452);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(58, 25);
            this.labelBeta.TabIndex = 11;
            this.labelBeta.Text = "Beta:";
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGamma.Location = new System.Drawing.Point(457, 486);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(87, 25);
            this.labelGamma.TabIndex = 12;
            this.labelGamma.Text = "Gamma:";
            // 
            // labelResize
            // 
            this.labelResize.AutoSize = true;
            this.labelResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResize.Location = new System.Drawing.Point(989, 417);
            this.labelResize.Name = "labelResize";
            this.labelResize.Size = new System.Drawing.Size(77, 25);
            this.labelResize.TabIndex = 13;
            this.labelResize.Text = "Resize:";
            // 
            // textBoxResize
            // 
            this.textBoxResize.Location = new System.Drawing.Point(1072, 418);
            this.textBoxResize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResize.Name = "textBoxResize";
            this.textBoxResize.Size = new System.Drawing.Size(55, 26);
            this.textBoxResize.TabIndex = 14;
            // 
            // btnResize
            // 
            this.btnResize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResize.Location = new System.Drawing.Point(1163, 399);
            this.btnResize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(150, 61);
            this.btnResize.TabIndex = 15;
            this.btnResize.Text = "RESIZE";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRotate.Location = new System.Drawing.Point(1163, 472);
            this.btnRotate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(150, 59);
            this.btnRotate.TabIndex = 16;
            this.btnRotate.Text = "ROTATE";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnLoadVideo
            // 
            this.btnLoadVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadVideo.Location = new System.Drawing.Point(1263, 126);
            this.btnLoadVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadVideo.Name = "btnLoadVideo";
            this.btnLoadVideo.Size = new System.Drawing.Size(227, 54);
            this.btnLoadVideo.TabIndex = 18;
            this.btnLoadVideo.Text = "LOAD VIDEO";
            this.btnLoadVideo.UseVisualStyleBackColor = true;
            this.btnLoadVideo.Click += new System.EventHandler(this.btnLoadVideo_Click);
            // 
            // labelVideo
            // 
            this.labelVideo.AutoSize = true;
            this.labelVideo.Location = new System.Drawing.Point(1226, 334);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(31, 20);
            this.labelVideo.TabIndex = 19;
            this.labelVideo.Text = "0/0";
            // 
            // btnBlending
            // 
            this.btnBlending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBlending.Location = new System.Drawing.Point(462, 306);
            this.btnBlending.Name = "btnBlending";
            this.btnBlending.Size = new System.Drawing.Size(227, 51);
            this.btnBlending.TabIndex = 20;
            this.btnBlending.Text = "BLEND IMAGES";
            this.btnBlending.UseVisualStyleBackColor = true;
            this.btnBlending.Click += new System.EventHandler(this.btnBlending_Click);
            // 
            // textBoxRotate
            // 
            this.textBoxRotate.Location = new System.Drawing.Point(1072, 483);
            this.textBoxRotate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRotate.Name = "textBoxRotate";
            this.textBoxRotate.Size = new System.Drawing.Size(55, 26);
            this.textBoxRotate.TabIndex = 21;
            // 
            // labelRotate
            // 
            this.labelRotate.AutoSize = true;
            this.labelRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRotate.Location = new System.Drawing.Point(992, 482);
            this.labelRotate.Name = "labelRotate";
            this.labelRotate.Size = new System.Drawing.Size(74, 25);
            this.labelRotate.TabIndex = 22;
            this.labelRotate.Text = "Rotate:";
            // 
            // pictureBoxResize
            // 
            this.pictureBoxResize.Location = new System.Drawing.Point(949, 561);
            this.pictureBoxResize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxResize.Name = "pictureBoxResize";
            this.pictureBoxResize.Size = new System.Drawing.Size(376, 206);
            this.pictureBoxResize.TabIndex = 23;
            this.pictureBoxResize.TabStop = false;
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSubstraction.Location = new System.Drawing.Point(1263, 188);
            this.btnSubstraction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(227, 54);
            this.btnSubstraction.TabIndex = 24;
            this.btnSubstraction.Text = "SUBSTRACTION";
            this.btnSubstraction.UseVisualStyleBackColor = true;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btnVideoWriting
            // 
            this.btnVideoWriting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVideoWriting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVideoWriting.Location = new System.Drawing.Point(1263, 250);
            this.btnVideoWriting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVideoWriting.Name = "btnVideoWriting";
            this.btnVideoWriting.Size = new System.Drawing.Size(227, 51);
            this.btnVideoWriting.TabIndex = 25;
            this.btnVideoWriting.Text = "VIDEO WRITING";
            this.btnVideoWriting.UseVisualStyleBackColor = true;
            this.btnVideoWriting.Click += new System.EventHandler(this.btnVideoWriting_Click);
            // 
            // btnPlayback
            // 
            this.btnPlayback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlayback.Location = new System.Drawing.Point(1570, 126);
            this.btnPlayback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlayback.Name = "btnPlayback";
            this.btnPlayback.Size = new System.Drawing.Size(227, 54);
            this.btnPlayback.TabIndex = 26;
            this.btnPlayback.Text = "PLAYBACK";
            this.btnPlayback.UseVisualStyleBackColor = true;
            this.btnPlayback.Click += new System.EventHandler(this.btnPlayback_Click);
            // 
            // btnConvertMp3ToWav
            // 
            this.btnConvertMp3ToWav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertMp3ToWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConvertMp3ToWav.Location = new System.Drawing.Point(1570, 188);
            this.btnConvertMp3ToWav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvertMp3ToWav.Name = "btnConvertMp3ToWav";
            this.btnConvertMp3ToWav.Size = new System.Drawing.Size(227, 54);
            this.btnConvertMp3ToWav.TabIndex = 27;
            this.btnConvertMp3ToWav.Text = "MP3 -> WAV";
            this.btnConvertMp3ToWav.UseVisualStyleBackColor = true;
            this.btnConvertMp3ToWav.Click += new System.EventHandler(this.btnConvertMp3ToWav_Click);
            // 
            // btnConvertWavToMp3
            // 
            this.btnConvertWavToMp3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvertWavToMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConvertWavToMp3.Location = new System.Drawing.Point(1570, 250);
            this.btnConvertWavToMp3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConvertWavToMp3.Name = "btnConvertWavToMp3";
            this.btnConvertWavToMp3.Size = new System.Drawing.Size(227, 54);
            this.btnConvertWavToMp3.TabIndex = 28;
            this.btnConvertWavToMp3.Text = "WAV -> MP3";
            this.btnConvertWavToMp3.UseVisualStyleBackColor = true;
            this.btnConvertWavToMp3.Click += new System.EventHandler(this.btnConvertWavToMp3_Click);
            // 
            // btnMixAudio
            // 
            this.btnMixAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMixAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMixAudio.Location = new System.Drawing.Point(1570, 312);
            this.btnMixAudio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMixAudio.Name = "btnMixAudio";
            this.btnMixAudio.Size = new System.Drawing.Size(227, 54);
            this.btnMixAudio.TabIndex = 29;
            this.btnMixAudio.Text = "MIX AUDIO";
            this.btnMixAudio.UseVisualStyleBackColor = true;
            this.btnMixAudio.Click += new System.EventHandler(this.btnMixAudio_Click);
            // 
            // btnTrimm
            // 
            this.btnTrimm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrimm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrimm.Location = new System.Drawing.Point(1570, 377);
            this.btnTrimm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTrimm.Name = "btnTrimm";
            this.btnTrimm.Size = new System.Drawing.Size(227, 54);
            this.btnTrimm.TabIndex = 30;
            this.btnTrimm.Text = "TRIMM";
            this.btnTrimm.UseVisualStyleBackColor = true;
            this.btnTrimm.Click += new System.EventHandler(this.btnTrimm_Click);
            // 
            // btnMono
            // 
            this.btnMono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMono.Location = new System.Drawing.Point(1570, 439);
            this.btnMono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMono.Name = "btnMono";
            this.btnMono.Size = new System.Drawing.Size(104, 68);
            this.btnMono.TabIndex = 31;
            this.btnMono.Text = "MONO";
            this.btnMono.UseVisualStyleBackColor = true;
            this.btnMono.Click += new System.EventHandler(this.btnMono_Click);
            // 
            // btnStereo
            // 
            this.btnStereo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStereo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStereo.Location = new System.Drawing.Point(1680, 439);
            this.btnStereo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStereo.Name = "btnStereo";
            this.btnStereo.Size = new System.Drawing.Size(117, 68);
            this.btnStereo.TabIndex = 32;
            this.btnStereo.Text = "STEREO";
            this.btnStereo.UseVisualStyleBackColor = true;
            this.btnStereo.Click += new System.EventHandler(this.btnStereo_Click);
            // 
            // btnRedChannel
            // 
            this.btnRedChannel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRedChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRedChannel.Location = new System.Drawing.Point(462, 249);
            this.btnRedChannel.Name = "btnRedChannel";
            this.btnRedChannel.Size = new System.Drawing.Size(227, 51);
            this.btnRedChannel.TabIndex = 33;
            this.btnRedChannel.Text = "RED CHANNEL";
            this.btnRedChannel.UseVisualStyleBackColor = true;
            this.btnRedChannel.Click += new System.EventHandler(this.btnRedChannel_Click);
            // 
            // pictureBoxRedChannel
            // 
            this.pictureBoxRedChannel.Location = new System.Drawing.Point(24, 536);
            this.pictureBoxRedChannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxRedChannel.Name = "pictureBoxRedChannel";
            this.pictureBoxRedChannel.Size = new System.Drawing.Size(376, 239);
            this.pictureBoxRedChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRedChannel.TabIndex = 34;
            this.pictureBoxRedChannel.TabStop = false;
            // 
            // btnConcatenateSkipTake
            // 
            this.btnConcatenateSkipTake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcatenateSkipTake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConcatenateSkipTake.Location = new System.Drawing.Point(1570, 515);
            this.btnConcatenateSkipTake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConcatenateSkipTake.Name = "btnConcatenateSkipTake";
            this.btnConcatenateSkipTake.Size = new System.Drawing.Size(227, 55);
            this.btnConcatenateSkipTake.TabIndex = 35;
            this.btnConcatenateSkipTake.Text = "PLAYLIST";
            this.btnConcatenateSkipTake.UseVisualStyleBackColor = true;
            this.btnConcatenateSkipTake.Click += new System.EventHandler(this.btnConcatenateSkipTake_Click);
            // 
            // btnPitch
            // 
            this.btnPitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPitch.Location = new System.Drawing.Point(1570, 578);
            this.btnPitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPitch.Name = "btnPitch";
            this.btnPitch.Size = new System.Drawing.Size(227, 54);
            this.btnPitch.TabIndex = 36;
            this.btnPitch.Text = "PITCH";
            this.btnPitch.UseVisualStyleBackColor = true;
            this.btnPitch.Click += new System.EventHandler(this.btnPitch_Click);
            // 
            // btnResampler
            // 
            this.btnResampler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResampler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResampler.Location = new System.Drawing.Point(1570, 640);
            this.btnResampler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResampler.Name = "btnResampler";
            this.btnResampler.Size = new System.Drawing.Size(227, 54);
            this.btnResampler.TabIndex = 37;
            this.btnResampler.Text = "RESAMPLER";
            this.btnResampler.UseVisualStyleBackColor = true;
            this.btnResampler.Click += new System.EventHandler(this.btnResampler_Click);
            // 
            // labelAudioOp
            // 
            this.labelAudioOp.AutoSize = true;
            this.labelAudioOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAudioOp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelAudioOp.Location = new System.Drawing.Point(1531, 35);
            this.labelAudioOp.Name = "labelAudioOp";
            this.labelAudioOp.Size = new System.Drawing.Size(309, 32);
            this.labelAudioOp.TabIndex = 38;
            this.labelAudioOp.Text = "AUDIO OPERATIONS";
            // 
            // pictureBoxVideo
            // 
            this.pictureBoxVideo.Location = new System.Drawing.Point(844, 111);
            this.pictureBoxVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxVideo.Name = "pictureBoxVideo";
            this.pictureBoxVideo.Size = new System.Drawing.Size(376, 243);
            this.pictureBoxVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVideo.TabIndex = 39;
            this.pictureBoxVideo.TabStop = false;
            // 
            // labelImageOp
            // 
            this.labelImageOp.AutoSize = true;
            this.labelImageOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImageOp.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelImageOp.Location = new System.Drawing.Point(428, 35);
            this.labelImageOp.Name = "labelImageOp";
            this.labelImageOp.Size = new System.Drawing.Size(311, 32);
            this.labelImageOp.TabIndex = 40;
            this.labelImageOp.Text = "IMAGE OPERATIONS";
            // 
            // labelVideoOp
            // 
            this.labelVideoOp.AutoSize = true;
            this.labelVideoOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVideoOp.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelVideoOp.Location = new System.Drawing.Point(1005, 35);
            this.labelVideoOp.Name = "labelVideoOp";
            this.labelVideoOp.Size = new System.Drawing.Size(308, 32);
            this.labelVideoOp.TabIndex = 41;
            this.labelVideoOp.Text = "VIDEO OPERATIONS";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(1570, 754);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 54);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Image_Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1874, 821);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelVideoOp);
            this.Controls.Add(this.labelImageOp);
            this.Controls.Add(this.pictureBoxVideo);
            this.Controls.Add(this.labelAudioOp);
            this.Controls.Add(this.btnResampler);
            this.Controls.Add(this.btnPitch);
            this.Controls.Add(this.btnConcatenateSkipTake);
            this.Controls.Add(this.pictureBoxRedChannel);
            this.Controls.Add(this.btnRedChannel);
            this.Controls.Add(this.btnStereo);
            this.Controls.Add(this.btnMono);
            this.Controls.Add(this.btnTrimm);
            this.Controls.Add(this.btnMixAudio);
            this.Controls.Add(this.btnConvertWavToMp3);
            this.Controls.Add(this.btnConvertMp3ToWav);
            this.Controls.Add(this.btnPlayback);
            this.Controls.Add(this.btnVideoWriting);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.pictureBoxResize);
            this.Controls.Add(this.labelRotate);
            this.Controls.Add(this.textBoxRotate);
            this.Controls.Add(this.btnBlending);
            this.Controls.Add(this.labelVideo);
            this.Controls.Add(this.btnLoadVideo);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.textBoxResize);
            this.Controls.Add(this.labelResize);
            this.Controls.Add(this.labelGamma);
            this.Controls.Add(this.labelBeta);
            this.Controls.Add(this.labelAlpha);
            this.Controls.Add(this.textBoxGamma);
            this.Controls.Add(this.btnGammaCorrection);
            this.Controls.Add(this.btnBrightness);
            this.Controls.Add(this.pictureBoxBrightness);
            this.Controls.Add(this.textBoxBeta);
            this.Controls.Add(this.textBoxAlpha);
            this.Controls.Add(this.btnMakeHistogram);
            this.Controls.Add(this.pictureBoxBlackWhite);
            this.Controls.Add(this.pictureBoxNormal);
            this.Controls.Add(this.btnLoadPicture);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Image_Operations";
            this.Text = "Image/Audio Operations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlackWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPicture;
        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.PictureBox pictureBoxBlackWhite;
        private System.Windows.Forms.Button btnMakeHistogram;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.PictureBox pictureBoxBrightness;
        private System.Windows.Forms.Button btnBrightness;
        private System.Windows.Forms.Button btnGammaCorrection;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.Label labelBeta;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.Label labelResize;
        private System.Windows.Forms.TextBox textBoxResize;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnLoadVideo;
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.Button btnBlending;
        private System.Windows.Forms.TextBox textBoxRotate;
        private System.Windows.Forms.Label labelRotate;
        private System.Windows.Forms.PictureBox pictureBoxResize;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnVideoWriting;
        private System.Windows.Forms.Button btnPlayback;
        private System.Windows.Forms.Button btnConvertMp3ToWav;
        private System.Windows.Forms.Button btnConvertWavToMp3;
        private System.Windows.Forms.Button btnMixAudio;
        private System.Windows.Forms.Button btnTrimm;
        private System.Windows.Forms.Button btnMono;
        private System.Windows.Forms.Button btnStereo;
        private System.Windows.Forms.Button btnRedChannel;
        private System.Windows.Forms.PictureBox pictureBoxRedChannel;
        private System.Windows.Forms.Button btnConcatenateSkipTake;
        private System.Windows.Forms.Button btnPitch;
        private System.Windows.Forms.Button btnResampler;
        private System.Windows.Forms.Label labelAudioOp;
        private System.Windows.Forms.PictureBox pictureBoxVideo;
        private System.Windows.Forms.Label labelImageOp;
        private System.Windows.Forms.Label labelVideoOp;
        private System.Windows.Forms.Button btnExit;
    }
}

