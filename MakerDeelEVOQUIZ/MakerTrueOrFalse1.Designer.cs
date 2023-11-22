namespace Makerdeel2
{
    partial class MakerTrueOrFalse1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakerTrueOrFalse1));
            this.tboxVraag = new System.Windows.Forms.TextBox();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.lblNoanswer = new System.Windows.Forms.Label();
            this.lblNoquestion = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.bar = new System.Windows.Forms.PictureBox();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxVraag
            // 
            this.tboxVraag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tboxVraag.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tboxVraag.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxVraag.ForeColor = System.Drawing.Color.White;
            this.tboxVraag.Location = new System.Drawing.Point(297, 224);
            this.tboxVraag.Margin = new System.Windows.Forms.Padding(2);
            this.tboxVraag.Name = "tboxVraag";
            this.tboxVraag.Size = new System.Drawing.Size(1366, 107);
            this.tboxVraag.TabIndex = 0;
            this.tboxVraag.TextChanged += new System.EventHandler(this.tboxVraag_TextChanged);
            // 
            // btnTrue
            // 
            this.btnTrue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrue.AutoSize = true;
            this.btnTrue.BackColor = System.Drawing.Color.Green;
            this.btnTrue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.btnTrue.Location = new System.Drawing.Point(379, 480);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(501, 236);
            this.btnTrue.TabIndex = 1;
            this.btnTrue.Text = "TRUE";
            this.btnTrue.UseVisualStyleBackColor = false;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFalse.AutoSize = true;
            this.btnFalse.BackColor = System.Drawing.Color.DarkRed;
            this.btnFalse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.btnFalse.Location = new System.Drawing.Point(1084, 480);
            this.btnFalse.Margin = new System.Windows.Forms.Padding(2);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(501, 236);
            this.btnFalse.TabIndex = 3;
            this.btnFalse.Text = "FALSE";
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // lblNoanswer
            // 
            this.lblNoanswer.AutoSize = true;
            this.lblNoanswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNoanswer.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25F);
            this.lblNoanswer.ForeColor = System.Drawing.Color.Red;
            this.lblNoanswer.Location = new System.Drawing.Point(625, 884);
            this.lblNoanswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoanswer.Name = "lblNoanswer";
            this.lblNoanswer.Size = new System.Drawing.Size(697, 48);
            this.lblNoanswer.TabIndex = 5;
            this.lblNoanswer.Text = "You have not choosen a Answer!";
            this.lblNoanswer.Visible = false;
            // 
            // lblNoquestion
            // 
            this.lblNoquestion.AutoSize = true;
            this.lblNoquestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNoquestion.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25F);
            this.lblNoquestion.ForeColor = System.Drawing.Color.Red;
            this.lblNoquestion.Location = new System.Drawing.Point(625, 884);
            this.lblNoquestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoquestion.Name = "lblNoquestion";
            this.lblNoquestion.Size = new System.Drawing.Size(718, 48);
            this.lblNoquestion.TabIndex = 6;
            this.lblNoquestion.Text = "You have not entered a Question!";
            this.lblNoquestion.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(12, -2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 141);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 7;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bar.Location = new System.Drawing.Point(-9, -2);
            this.bar.Margin = new System.Windows.Forms.Padding(2);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1945, 143);
            this.bar.TabIndex = 8;
            this.bar.TabStop = false;
            // 
            // pboxBackground
            // 
            this.pboxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxBackground.BackgroundImage")));
            this.pboxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxBackground.Location = new System.Drawing.Point(0, 0);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(1920, 1080);
            this.pboxBackground.TabIndex = 9;
            this.pboxBackground.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Elephant", 35.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 62);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vraag 1/10";
            // 
            // pboxLogo
            // 
            this.pboxLogo.BackColor = System.Drawing.SystemColors.Highlight;
            this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
            this.pboxLogo.Location = new System.Drawing.Point(899, -2);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(164, 141);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 12;
            this.pboxLogo.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(1491, 779);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(373, 217);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNext.TabIndex = 13;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MakerTrueOrFalse1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNoquestion);
            this.Controls.Add(this.lblNoanswer);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.tboxVraag);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.pboxBackground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MakerTrueOrFalse1";
            this.Text = "a";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxVraag;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Label lblNoanswer;
        private System.Windows.Forms.Label lblNoquestion;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox bar;
        private System.Windows.Forms.PictureBox pboxBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.PictureBox btnNext;
    }
}

