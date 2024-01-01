namespace MakerDeelEVOQUIZ
{
    partial class FormVraag1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVraag1));
            this.lblVraag = new System.Windows.Forms.Label();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.bar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prbTijd = new System.Windows.Forms.ProgressBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblThatis = new System.Windows.Forms.Label();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblQuizName = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVraag
            // 
            this.lblVraag.AutoSize = true;
            this.lblVraag.BackColor = System.Drawing.Color.Transparent;
            this.lblVraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold);
            this.lblVraag.ForeColor = System.Drawing.Color.White;
            this.lblVraag.Location = new System.Drawing.Point(586, 272);
            this.lblVraag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVraag.Name = "lblVraag";
            this.lblVraag.Size = new System.Drawing.Size(224, 63);
            this.lblVraag.TabIndex = 0;
            this.lblVraag.Text = "Vraag...";
            this.lblVraag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrue
            // 
            this.btnTrue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrue.AutoSize = true;
            this.btnTrue.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTrue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.btnTrue.Location = new System.Drawing.Point(252, 465);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(381, 236);
            this.btnTrue.TabIndex = 4;
            this.btnTrue.Text = "TRUE";
            this.btnTrue.UseVisualStyleBackColor = false;
            this.btnTrue.Visible = false;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFalse.AutoSize = true;
            this.btnFalse.BackColor = System.Drawing.Color.Orange;
            this.btnFalse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.btnFalse.Location = new System.Drawing.Point(789, 465);
            this.btnFalse.Margin = new System.Windows.Forms.Padding(2);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(381, 236);
            this.btnFalse.TabIndex = 6;
            this.btnFalse.Text = "FALSE";
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Visible = false;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.Gold;
            this.bar.Location = new System.Drawing.Point(-146, 0);
            this.bar.Margin = new System.Windows.Forms.Padding(2);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(2077, 112);
            this.bar.TabIndex = 7;
            this.bar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vraag 1/10";
            // 
            // prbTijd
            // 
            this.prbTijd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prbTijd.ForeColor = System.Drawing.Color.Purple;
            this.prbTijd.Location = new System.Drawing.Point(11, 550);
            this.prbTijd.Margin = new System.Windows.Forms.Padding(2);
            this.prbTijd.Name = "prbTijd";
            this.prbTijd.Size = new System.Drawing.Size(1360, 50);
            this.prbTijd.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbTijd.TabIndex = 9;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Gold;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.8F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(758, 24);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(218, 55);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "Time: 20";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Gold;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.8F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(1052, 24);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(295, 55);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score: 1000";
            this.lblScore.Visible = false;
            // 
            // lblThatis
            // 
            this.lblThatis.AutoSize = true;
            this.lblThatis.BackColor = System.Drawing.Color.Transparent;
            this.lblThatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThatis.ForeColor = System.Drawing.Color.White;
            this.lblThatis.Location = new System.Drawing.Point(507, 272);
            this.lblThatis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThatis.Name = "lblThatis";
            this.lblThatis.Size = new System.Drawing.Size(407, 63);
            this.lblThatis.TabIndex = 14;
            this.lblThatis.Text = "That answer is.";
            this.lblThatis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThatis.Visible = false;
            // 
            // pboxBackground
            // 
            this.pboxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pboxBackground.Image = ((System.Drawing.Image)(resources.GetObject("pboxBackground.Image")));
            this.pboxBackground.Location = new System.Drawing.Point(0, 0);
            this.pboxBackground.Margin = new System.Windows.Forms.Padding(2);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(1587, 895);
            this.pboxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBackground.TabIndex = 13;
            this.pboxBackground.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(-284, 106);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2077, 24);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lblQuizName
            // 
            this.lblQuizName.AutoSize = true;
            this.lblQuizName.BackColor = System.Drawing.Color.Gold;
            this.lblQuizName.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.8F, System.Drawing.FontStyle.Bold);
            this.lblQuizName.ForeColor = System.Drawing.Color.White;
            this.lblQuizName.Location = new System.Drawing.Point(433, 24);
            this.lblQuizName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuizName.Name = "lblQuizName";
            this.lblQuizName.Size = new System.Drawing.Size(140, 55);
            this.lblQuizName.TabIndex = 17;
            this.lblQuizName.Text = "Quiz:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.Lime;
            this.lblCorrect.Location = new System.Drawing.Point(598, 272);
            this.lblCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(227, 63);
            this.lblCorrect.TabIndex = 18;
            this.lblCorrect.Text = "Correct!";
            this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCorrect.Visible = false;
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.lblIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblIncorrect.Location = new System.Drawing.Point(563, 272);
            this.lblIncorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(262, 63);
            this.lblIncorrect.TabIndex = 19;
            this.lblIncorrect.Text = "Incorrect!";
            this.lblIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIncorrect.Visible = false;
            // 
            // FormVraag1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.lblThatis);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblQuizName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.prbTijd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.lblVraag);
            this.Controls.Add(this.pboxBackground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVraag1";
            this.Text = "VraagTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVraag1_FormClosing);
            this.Load += new System.EventHandler(this.VraagTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVraag;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.PictureBox bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prbTijd;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblThatis;
        private System.Windows.Forms.PictureBox pboxBackground;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblQuizName;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
    }
}