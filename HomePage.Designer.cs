namespace MakerDeelEVOQUIZ
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnMaker = new System.Windows.Forms.Button();
            this.btnQuizes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            this.pboxPlayGif = new System.Windows.Forms.PictureBox();
            this.pboxCreategif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCreategif)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaker
            // 
            this.btnMaker.BackColor = System.Drawing.Color.Transparent;
            this.btnMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Bold);
            this.btnMaker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaker.Image = ((System.Drawing.Image)(resources.GetObject("btnMaker.Image")));
            this.btnMaker.Location = new System.Drawing.Point(981, 391);
            this.btnMaker.Name = "btnMaker";
            this.btnMaker.Size = new System.Drawing.Size(364, 238);
            this.btnMaker.TabIndex = 0;
            this.btnMaker.Text = "CREATE";
            this.btnMaker.UseVisualStyleBackColor = false;
            this.btnMaker.Click += new System.EventHandler(this.btnMaker_Click);
            this.btnMaker.MouseLeave += new System.EventHandler(this.btnCreate_MouseLeave);
            this.btnMaker.MouseHover += new System.EventHandler(this.btnCreate_MouseHover);
            // 
            // btnQuizes
            // 
            this.btnQuizes.BackColor = System.Drawing.Color.Transparent;
            this.btnQuizes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuizes.BackgroundImage")));
            this.btnQuizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Bold);
            this.btnQuizes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuizes.Location = new System.Drawing.Point(227, 391);
            this.btnQuizes.Name = "btnQuizes";
            this.btnQuizes.Size = new System.Drawing.Size(358, 238);
            this.btnQuizes.TabIndex = 1;
            this.btnQuizes.Text = "Play";
            this.btnQuizes.UseVisualStyleBackColor = true;
            this.btnQuizes.Click += new System.EventHandler(this.btnQuizes_Click);
            this.btnQuizes.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnQuizes.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(623, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pboxBackground
            // 
            this.pboxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxBackground.Cursor = System.Windows.Forms.Cursors.No;
            this.pboxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pboxBackground.Image")));
            this.pboxBackground.Location = new System.Drawing.Point(0, 0);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(1443, 857);
            this.pboxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBackground.TabIndex = 3;
            this.pboxBackground.TabStop = false;
            // 
            // pboxPlayGif
            // 
            this.pboxPlayGif.BackColor = System.Drawing.Color.Transparent;
            this.pboxPlayGif.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pboxPlayGif.ErrorImage")));
            this.pboxPlayGif.Image = ((System.Drawing.Image)(resources.GetObject("pboxPlayGif.Image")));
            this.pboxPlayGif.Location = new System.Drawing.Point(204, 227);
            this.pboxPlayGif.Margin = new System.Windows.Forms.Padding(2);
            this.pboxPlayGif.Name = "pboxPlayGif";
            this.pboxPlayGif.Size = new System.Drawing.Size(399, 269);
            this.pboxPlayGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPlayGif.TabIndex = 4;
            this.pboxPlayGif.TabStop = false;
            // 
            // pboxCreategif
            // 
            this.pboxCreategif.BackColor = System.Drawing.Color.Transparent;
            this.pboxCreategif.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pboxCreategif.ErrorImage")));
            this.pboxCreategif.Image = ((System.Drawing.Image)(resources.GetObject("pboxCreategif.Image")));
            this.pboxCreategif.Location = new System.Drawing.Point(959, 213);
            this.pboxCreategif.Margin = new System.Windows.Forms.Padding(2);
            this.pboxCreategif.Name = "pboxCreategif";
            this.pboxCreategif.Size = new System.Drawing.Size(399, 314);
            this.pboxCreategif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCreategif.TabIndex = 5;
            this.pboxCreategif.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuizes);
            this.Controls.Add(this.btnMaker);
            this.Controls.Add(this.pboxPlayGif);
            this.Controls.Add(this.pboxCreategif);
            this.Controls.Add(this.pboxBackground);
            this.DoubleBuffered = true;
            this.Name = "HomePage";
            this.Text = "Formhomepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.Formhomepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCreategif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaker;
        private System.Windows.Forms.Button btnQuizes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pboxBackground;
        private System.Windows.Forms.PictureBox pboxPlayGif;
        private System.Windows.Forms.PictureBox pboxCreategif;
    }
}