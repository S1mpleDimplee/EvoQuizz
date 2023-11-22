namespace MakerDeelEVOQUIZ
{
    partial class FormVraagTest
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
            this.lblVraag = new System.Windows.Forms.Label();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.bar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prbTijd = new System.Windows.Forms.ProgressBar();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVraag
            // 
            this.lblVraag.AutoSize = true;
            this.lblVraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblVraag.Location = new System.Drawing.Point(893, 151);
            this.lblVraag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVraag.Name = "lblVraag";
            this.lblVraag.Size = new System.Drawing.Size(216, 63);
            this.lblVraag.TabIndex = 0;
            this.lblVraag.Text = "Vraag...";
            this.lblVraag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrue
            // 
            this.btnTrue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrue.AutoSize = true;
            this.btnTrue.BackColor = System.Drawing.Color.Green;
            this.btnTrue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.btnTrue.Location = new System.Drawing.Point(412, 480);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(501, 236);
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
            this.btnFalse.BackColor = System.Drawing.Color.DarkRed;
            this.btnFalse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.btnFalse.Location = new System.Drawing.Point(1075, 480);
            this.btnFalse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(501, 236);
            this.btnFalse.TabIndex = 6;
            this.btnFalse.Text = "FALSE";
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Visible = false;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bar.Location = new System.Drawing.Point(-146, 0);
            this.bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(2077, 112);
            this.bar.TabIndex = 7;
            this.bar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Elephant", 35.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vraag 1/10";
            // 
            // prbTijd
            // 
            this.prbTijd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prbTijd.Location = new System.Drawing.Point(182, 575);
            this.prbTijd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prbTijd.Name = "prbTijd";
            this.prbTijd.Size = new System.Drawing.Size(1520, 50);
            this.prbTijd.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbTijd.TabIndex = 9;
            this.prbTijd.Value = 10;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTimer.Font = new System.Drawing.Font("Elephant", 35.8F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(893, 32);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(257, 62);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "Time: 20";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblScore.Font = new System.Drawing.Font("Elephant", 35.8F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(1144, 32);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(335, 62);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score: 1000";
            this.lblScore.Visible = false;
            // 
            // FormVraagTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.prbTijd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.lblVraag);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVraagTest";
            this.Text = "VraagTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VraagTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
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
    }
}