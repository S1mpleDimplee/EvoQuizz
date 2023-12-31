namespace MakerDeelEVOQUIZ
{
    partial class FormPlayQuizes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayQuizes));
            this.btnQuizesNormal = new System.Windows.Forms.Button();
            this.btnQuizesPlayers = new System.Windows.Forms.Button();
            this.pboxBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuizesNormal
            // 
            this.btnQuizesNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnQuizesNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuizesNormal.BackgroundImage")));
            this.btnQuizesNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Bold);
            this.btnQuizesNormal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuizesNormal.Location = new System.Drawing.Point(158, 312);
            this.btnQuizesNormal.Name = "btnQuizesNormal";
            this.btnQuizesNormal.Size = new System.Drawing.Size(358, 238);
            this.btnQuizesNormal.TabIndex = 3;
            this.btnQuizesNormal.Text = "Normal Quizes";
            this.btnQuizesNormal.UseVisualStyleBackColor = true;
            // 
            // btnQuizesPlayers
            // 
            this.btnQuizesPlayers.BackColor = System.Drawing.Color.Transparent;
            this.btnQuizesPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Bold);
            this.btnQuizesPlayers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuizesPlayers.Image = ((System.Drawing.Image)(resources.GetObject("btnQuizesPlayers.Image")));
            this.btnQuizesPlayers.Location = new System.Drawing.Point(966, 312);
            this.btnQuizesPlayers.Name = "btnQuizesPlayers";
            this.btnQuizesPlayers.Size = new System.Drawing.Size(364, 238);
            this.btnQuizesPlayers.TabIndex = 2;
            this.btnQuizesPlayers.Text = "Custom Quizes";
            this.btnQuizesPlayers.UseVisualStyleBackColor = false;
            this.btnQuizesPlayers.Click += new System.EventHandler(this.btnQuizesPlayers_Click);
            // 
            // pboxBackground
            // 
            this.pboxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboxBackground.BackgroundImage")));
            this.pboxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxBackground.Location = new System.Drawing.Point(0, 0);
            this.pboxBackground.Name = "pboxBackground";
            this.pboxBackground.Size = new System.Drawing.Size(1443, 857);
            this.pboxBackground.TabIndex = 10;
            this.pboxBackground.TabStop = false;
            // 
            // FormPlayQuizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.btnQuizesNormal);
            this.Controls.Add(this.btnQuizesPlayers);
            this.Controls.Add(this.pboxBackground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPlayQuizes";
            this.Text = "FormPlayQuizes";
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuizesNormal;
        private System.Windows.Forms.Button btnQuizesPlayers;
        private System.Windows.Forms.PictureBox pboxBackground;
    }
}