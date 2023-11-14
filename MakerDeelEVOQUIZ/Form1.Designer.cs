namespace MakerDeelEVOQUIZ
{
    partial class FormMakerBegin
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
            this.btnVraagmaken = new System.Windows.Forms.Button();
            this.btnKlaar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVraagmaken
            // 
            this.btnVraagmaken.Location = new System.Drawing.Point(270, 166);
            this.btnVraagmaken.Name = "btnVraagmaken";
            this.btnVraagmaken.Size = new System.Drawing.Size(202, 92);
            this.btnVraagmaken.TabIndex = 0;
            this.btnVraagmaken.Text = "Voeg een vraag toe";
            this.btnVraagmaken.UseVisualStyleBackColor = true;
            this.btnVraagmaken.Click += new System.EventHandler(this.btnVraagmaken_Click);
            // 
            // btnKlaar
            // 
            this.btnKlaar.Location = new System.Drawing.Point(586, 12);
            this.btnKlaar.Name = "btnKlaar";
            this.btnKlaar.Size = new System.Drawing.Size(202, 92);
            this.btnKlaar.TabIndex = 1;
            this.btnKlaar.Text = "Klaar";
            this.btnKlaar.UseVisualStyleBackColor = true;
            this.btnKlaar.Click += new System.EventHandler(this.btnKlaar_Click);
            // 
            // FormMakerBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKlaar);
            this.Controls.Add(this.btnVraagmaken);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMakerBegin";
            this.Text = "Quiz Maker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVraagmaken;
        private System.Windows.Forms.Button btnKlaar;
    }
}

