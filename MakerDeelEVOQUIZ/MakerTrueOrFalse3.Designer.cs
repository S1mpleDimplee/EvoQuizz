namespace MakerDeelEVOQUIZ
{
    partial class MakerTrueOrFalse3
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
            this.btnVolgende = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.tboxVraag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolgende
            // 
            this.btnVolgende.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolgende.AutoSize = true;
            this.btnVolgende.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.btnVolgende.Location = new System.Drawing.Point(1009, 642);
            this.btnVolgende.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(339, 104);
            this.btnVolgende.TabIndex = 12;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            // 
            // btnFalse
            // 
            this.btnFalse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFalse.AutoSize = true;
            this.btnFalse.BackColor = System.Drawing.Color.DarkRed;
            this.btnFalse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.btnFalse.Location = new System.Drawing.Point(847, 353);
            this.btnFalse.Margin = new System.Windows.Forms.Padding(2);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(501, 236);
            this.btnFalse.TabIndex = 11;
            this.btnFalse.Text = "FALSE";
            this.btnFalse.UseVisualStyleBackColor = false;
            // 
            // btnTrue
            // 
            this.btnTrue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrue.AutoSize = true;
            this.btnTrue.BackColor = System.Drawing.Color.Green;
            this.btnTrue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.btnTrue.Location = new System.Drawing.Point(137, 353);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(501, 236);
            this.btnTrue.TabIndex = 10;
            this.btnTrue.Text = "TRUE";
            this.btnTrue.UseVisualStyleBackColor = false;
            // 
            // tboxVraag
            // 
            this.tboxVraag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tboxVraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.tboxVraag.Location = new System.Drawing.Point(50, 77);
            this.tboxVraag.Margin = new System.Windows.Forms.Padding(2);
            this.tboxVraag.Name = "tboxVraag";
            this.tboxVraag.Size = new System.Drawing.Size(1366, 98);
            this.tboxVraag.TabIndex = 9;
            // 
            // MakerTrueOrFalse3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1466, 823);
            this.Controls.Add(this.btnVolgende);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.tboxVraag);
            this.Name = "MakerTrueOrFalse3";
            this.Text = "MakerTrueOrFalse3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.TextBox tboxVraag;
    }
}