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
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMeerKeuzeVraag
            // 
            this.btnMeerKeuzeVraag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMeerKeuzeVraag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMeerKeuzeVraag.BackgroundImage")));
            this.btnMeerKeuzeVraag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeerKeuzeVraag.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeerKeuzeVraag.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnMeerKeuzeVraag.Location = new System.Drawing.Point(2, 257);
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
            this.btnTrueFalse.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrueFalse.ForeColor = System.Drawing.Color.White;
            this.btnTrueFalse.Location = new System.Drawing.Point(908, 257);
            this.btnTrueFalse.Name = "btnTrueFalse";
            this.btnTrueFalse.Size = new System.Drawing.Size(545, 260);
            this.btnTrueFalse.TabIndex = 1;
            this.btnTrueFalse.Text = " True               False";
            this.btnTrueFalse.UseVisualStyleBackColor = true;
            this.btnTrueFalse.Click += new System.EventHandler(this.btnTrueFalse_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTerug.AutoSize = true;
            this.btnTerug.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnTerug.Location = new System.Drawing.Point(2, 53);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(277, 79);
            this.btnTerug.TabIndex = 2;
            this.btnTerug.Text = "<- Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // FormVraagOptieKeuze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1445, 823);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnTrueFalse);
            this.Controls.Add(this.btnMeerKeuzeVraag);
            this.Name = "FormVraagOptieKeuze";
            this.Text = "FormVraagMaker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMeerKeuzeVraag;
        private System.Windows.Forms.Button btnTrueFalse;
        private System.Windows.Forms.Button btnTerug;
    }
}