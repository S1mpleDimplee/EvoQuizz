﻿namespace MakerDeelEVOQUIZ
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
            this.SuspendLayout();
            // 
            // lblVraag
            // 
            this.lblVraag.AutoSize = true;
            this.lblVraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblVraag.Location = new System.Drawing.Point(642, 142);
            this.lblVraag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVraag.Name = "lblVraag";
            this.lblVraag.Size = new System.Drawing.Size(216, 63);
            this.lblVraag.TabIndex = 0;
            this.lblVraag.Text = "Vraag...";
            this.lblVraag.Click += new System.EventHandler(this.lblVraag_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.BackColor = System.Drawing.Color.Green;
            this.btnTrue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.btnTrue.Location = new System.Drawing.Point(174, 370);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(501, 236);
            this.btnTrue.TabIndex = 4;
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
            this.btnFalse.Location = new System.Drawing.Point(845, 370);
            this.btnFalse.Margin = new System.Windows.Forms.Padding(2);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(501, 236);
            this.btnFalse.TabIndex = 6;
            this.btnFalse.Text = "FALSE";
            this.btnFalse.UseVisualStyleBackColor = false;
            // 
            // FormVraagTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1465, 821);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.lblVraag);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVraagTest";
            this.Text = "VraagTest";
            this.Load += new System.EventHandler(this.VraagTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVraag;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
    }
}