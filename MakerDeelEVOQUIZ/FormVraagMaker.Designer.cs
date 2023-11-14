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
            this.SuspendLayout();
            // 
            // btnMeerKeuzeVraag
            // 
            this.btnMeerKeuzeVraag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMeerKeuzeVraag.BackgroundImage")));
            this.btnMeerKeuzeVraag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeerKeuzeVraag.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeerKeuzeVraag.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnMeerKeuzeVraag.Location = new System.Drawing.Point(28, 154);
            this.btnMeerKeuzeVraag.Name = "btnMeerKeuzeVraag";
            this.btnMeerKeuzeVraag.Size = new System.Drawing.Size(272, 143);
            this.btnMeerKeuzeVraag.TabIndex = 0;
            this.btnMeerKeuzeVraag.Text = "Multiple Choice";
            this.btnMeerKeuzeVraag.UseVisualStyleBackColor = true;
            this.btnMeerKeuzeVraag.Click += new System.EventHandler(this.btnMeerKeuzeVraag_Click);
            // 
            // btnTrueFalse
            // 
            this.btnTrueFalse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrueFalse.BackgroundImage")));
            this.btnTrueFalse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrueFalse.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrueFalse.ForeColor = System.Drawing.Color.White;
            this.btnTrueFalse.Location = new System.Drawing.Point(465, 154);
            this.btnTrueFalse.Name = "btnTrueFalse";
            this.btnTrueFalse.Size = new System.Drawing.Size(287, 143);
            this.btnTrueFalse.TabIndex = 1;
            this.btnTrueFalse.Text = " True               False";
            this.btnTrueFalse.UseVisualStyleBackColor = true;
            this.btnTrueFalse.Click += new System.EventHandler(this.btnTrueFalse_Click);
            // 
            // FormVraagOptieKeuze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrueFalse);
            this.Controls.Add(this.btnMeerKeuzeVraag);
            this.Name = "FormVraagOptieKeuze";
            this.Text = "FormVraagMaker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMeerKeuzeVraag;
        private System.Windows.Forms.Button btnTrueFalse;
    }
}