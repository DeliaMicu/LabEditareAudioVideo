
namespace Lab5
{
    partial class Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMakeHistogram = new System.Windows.Forms.Button();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBlending = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadPicture.Location = new System.Drawing.Point(75, 457);
            this.btnLoadPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(149, 92);
            this.btnLoadPicture.TabIndex = 0;
            this.btnLoadPicture.Text = "LOAD PICTURE";
            this.btnLoadPicture.UseVisualStyleBackColor = true;
            this.btnLoadPicture.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(428, 35);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 354);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnMakeHistogram
            // 
            this.btnMakeHistogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMakeHistogram.Location = new System.Drawing.Point(326, 457);
            this.btnMakeHistogram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakeHistogram.Name = "btnMakeHistogram";
            this.btnMakeHistogram.Size = new System.Drawing.Size(153, 92);
            this.btnMakeHistogram.TabIndex = 3;
            this.btnMakeHistogram.Text = "MAKE HISTOGRAM";
            this.btnMakeHistogram.UseVisualStyleBackColor = true;
            this.btnMakeHistogram.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(891, 38);
            this.textBoxAlpha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(55, 26);
            this.textBoxAlpha.TabIndex = 4;
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.Location = new System.Drawing.Point(891, 68);
            this.textBoxBeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(55, 26);
            this.textBoxBeta.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(822, 159);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(364, 354);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btnBrightness
            // 
            this.btnBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrightness.Location = new System.Drawing.Point(988, 21);
            this.btnBrightness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(150, 61);
            this.btnBrightness.TabIndex = 7;
            this.btnBrightness.Text = "BRIGHTNESS";
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGammaCorrection
            // 
            this.btnGammaCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGammaCorrection.Location = new System.Drawing.Point(988, 90);
            this.btnGammaCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGammaCorrection.Name = "btnGammaCorrection";
            this.btnGammaCorrection.Size = new System.Drawing.Size(150, 61);
            this.btnGammaCorrection.TabIndex = 8;
            this.btnGammaCorrection.Text = "GAMMA CORR.";
            this.btnGammaCorrection.UseVisualStyleBackColor = true;
            this.btnGammaCorrection.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(891, 102);
            this.textBoxGamma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(55, 26);
            this.textBoxGamma.TabIndex = 9;
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlpha.Location = new System.Drawing.Point(817, 39);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(74, 25);
            this.labelAlpha.TabIndex = 10;
            this.labelAlpha.Text = "Alpha: ";
            // 
            // labelBeta
            // 
            this.labelBeta.AutoSize = true;
            this.labelBeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBeta.Location = new System.Drawing.Point(827, 72);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(58, 25);
            this.labelBeta.TabIndex = 11;
            this.labelBeta.Text = "Beta:";
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGamma.Location = new System.Drawing.Point(798, 106);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(87, 25);
            this.labelGamma.TabIndex = 12;
            this.labelGamma.Text = "Gamma:";
            // 
            // labelResize
            // 
            this.labelResize.AutoSize = true;
            this.labelResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResize.Location = new System.Drawing.Point(1216, 37);
            this.labelResize.Name = "labelResize";
            this.labelResize.Size = new System.Drawing.Size(77, 25);
            this.labelResize.TabIndex = 13;
            this.labelResize.Text = "Resize:";
            // 
            // textBoxResize
            // 
            this.textBoxResize.Location = new System.Drawing.Point(1299, 37);
            this.textBoxResize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxResize.Name = "textBoxResize";
            this.textBoxResize.Size = new System.Drawing.Size(55, 26);
            this.textBoxResize.TabIndex = 14;
            // 
            // btnResize
            // 
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResize.Location = new System.Drawing.Point(1262, 83);
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
            this.btnRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRotate.Location = new System.Drawing.Point(1262, 182);
            this.btnRotate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(150, 61);
            this.btnRotate.TabIndex = 16;
            this.btnRotate.Text = "ROTATE";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(561, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 92);
            this.button1.TabIndex = 18;
            this.button1.Text = "LOAD VIDEO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // btnBlending
            // 
            this.btnBlending.Location = new System.Drawing.Point(1248, 328);
            this.btnBlending.Name = "btnBlending";
            this.btnBlending.Size = new System.Drawing.Size(181, 56);
            this.btnBlending.TabIndex = 20;
            this.btnBlending.Text = "BLEND IMAGES";
            this.btnBlending.UseVisualStyleBackColor = true;
            this.btnBlending.Click += new System.EventHandler(this.btnBlending_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 562);
            this.Controls.Add(this.btnBlending);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBoxBeta);
            this.Controls.Add(this.textBoxAlpha);
            this.Controls.Add(this.btnMakeHistogram);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadPicture);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form";
            this.Text = "Image Operations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMakeHistogram;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.PictureBox pictureBox3;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBlending;
    }
}

