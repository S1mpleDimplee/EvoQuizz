namespace MakerDeelEVOQUIZ
{
    partial class FormVraagOptieKeuze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVraagOptieKeuze));
            this.btnMeerKeuzeVraag = new System.Windows.Forms.Button();
            this.btnTrueFalse = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.bar = new System.Windows.Forms.PictureBox();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.lblQuiz = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            this.lblSoon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMeerKeuzeVraag
            // 
            this.btnMeerKeuzeVraag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMeerKeuzeVraag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMeerKeuzeVraag.BackgroundImage")));
            this.btnMeerKeuzeVraag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeerKeuzeVraag.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeerKeuzeVraag.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnMeerKeuzeVraag.Location = new System.Drawing.Point(233, 366);
            this.btnMeerKeuzeVraag.Name = "btnMeerKeuzeVraag";
            this.btnMeerKeuzeVraag.Size = new System.Drawing.Size(545, 260);
            this.btnMeerKeuzeVraag.TabIndex = 0;
            this.btnMeerKeuzeVraag.Text = "Multiple Choice";
            this.btnMeerKeuzeVraag.UseVisualStyleBackColor = true;
            this.btnMeerKeuzeVraag.Click += new System.EventHandler(this.btnMeerKeuzeVraag_Click);
            // 
            // btnTrueFalse
            // 
            this.btnTrueFalse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrueFalse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrueFalse.BackgroundImage")));
            this.btnTrueFalse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrueFalse.Font = new System.Drawing.Font("Cooper Black", 30.25F);
            this.btnTrueFalse.ForeColor = System.Drawing.Color.White;
            this.btnTrueFalse.Location = new System.Drawing.Point(1139, 366);
            this.btnTrueFalse.Name = "btnTrueFalse";
            this.btnTrueFalse.Size = new System.Drawing.Size(545, 260);
            this.btnTrueFalse.TabIndex = 1;
            this.btnTrueFalse.Text = "True             OR          False";
            this.btnTrueFalse.UseVisualStyleBackColor = true;
            this.btnTrueFalse.Click += new System.EventHandler(this.btnTrueFalse_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 141);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 8;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bar.Location = new System.Drawing.Point(-180, 0);
            this.bar.Margin = new System.Windows.Forms.Padding(2);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(2094, 143);
            this.bar.TabIndex = 10;
            this.bar.TabStop = false;
            // 
            // pboxLogo
            // 
            this.pboxLogo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
            this.pboxLogo.Location = new System.Drawing.Point(852, 2);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(164, 141);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 13;
            this.pboxLogo.TabStop = false;
            // 
            // lblQuiz
            // 
            this.lblQuiz.AutoSize = true;
            this.lblQuiz.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblQuiz.Font = new System.Drawing.Font("Elephant", 45.8F, System.Drawing.FontStyle.Bold);
            this.lblQuiz.ForeColor = System.Drawing.Color.White;
            this.lblQuiz.Location = new System.Drawing.Point(430, 32);
            this.lblQuiz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuiz.Name = "lblQuiz";
            this.lblQuiz.Size = new System.Drawing.Size(417, 80);
            this.lblQuiz.TabIndex = 14;
            this.lblQuiz.Text = "Quiz Maker";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblMode.Font = new System.Drawing.Font("Elephant", 45.8F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.White;
            this.lblMode.Location = new System.Drawing.Point(1021, 32);
            this.lblMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(211, 80);
            this.lblMode.TabIndex = 15;
            this.lblMode.Text = "Mode";
            // 
            // pboxBackground
            // 
            this.pboxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxBackground.BackgroundImage")));
            this.pboxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxBackground.Location = new System.Drawing.Point(0, 0);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(1904, 1041);
            this.pboxBackground.TabIndex = 16;
            this.pboxBackground.TabStop = false;
            // 
            // lblSoon
            // 
            this.lblSoon.AutoSize = true;
            this.lblSoon.BackColor = System.Drawing.Color.Transparent;
            this.lblSoon.Font = new System.Drawing.Font("Elephant", 45.8F, System.Drawing.FontStyle.Bold);
            this.lblSoon.ForeColor = System.Drawing.Color.White;
            this.lblSoon.Location = new System.Drawing.Point(244, 283);
            this.lblSoon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoon.Name = "lblSoon";
            this.lblSoon.Size = new System.Drawing.Size(511, 80);
            this.lblSoon.TabIndex = 17;
            this.lblSoon.Text = "Comming Soon";
            // 
            // FormVraagOptieKeuze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblSoon);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblQuiz);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTrueFalse);
            this.Controls.Add(this.btnMeerKeuzeVraag);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.pboxBackground);
            this.Name = "FormVraagOptieKeuze";
            this.Text = "FormVraagMaker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVraagOptieKeuze_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMeerKeuzeVraag;
        private System.Windows.Forms.Button btnTrueFalse;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox bar;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Label lblQuiz;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.PictureBox pboxBackground;
        private System.Windows.Forms.Label lblSoon;
    }
}