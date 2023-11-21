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
            this.tboxVraag = new System.Windows.Forms.TextBox();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.lblNoanswer = new System.Windows.Forms.Label();
            this.lblNoquestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxVraag
            // 
            this.tboxVraag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tboxVraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.tboxVraag.Location = new System.Drawing.Point(81, 116);
            this.tboxVraag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxVraag.Name = "tboxVraag";
            this.tboxVraag.Size = new System.Drawing.Size(1820, 121);
            this.tboxVraag.TabIndex = 0;
            this.tboxVraag.TextChanged += new System.EventHandler(this.tboxVraag_TextChanged);
            // 
            // btnTrue
            // 
            this.btnTrue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrue.AutoSize = true;
            this.btnTrue.BackColor = System.Drawing.Color.Green;
            this.btnTrue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 23F);
            this.btnTrue.Location = new System.Drawing.Point(197, 455);
            this.btnTrue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(668, 290);
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
            this.btnFalse.Location = new System.Drawing.Point(1144, 455);
            this.btnFalse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(668, 290);
            this.btnFalse.TabIndex = 3;
            this.btnFalse.Text = "FALSE";
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnVolgende
            // 
            this.btnVolgende.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolgende.AutoSize = true;
            this.btnVolgende.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.btnVolgende.Location = new System.Drawing.Point(1360, 811);
            this.btnVolgende.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(452, 128);
            this.btnVolgende.TabIndex = 4;
            this.btnVolgende.Text = "Next";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            // 
            // lblNoanswer
            // 
            this.lblNoanswer.AutoSize = true;
            this.lblNoanswer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblNoanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblNoanswer.ForeColor = System.Drawing.Color.Red;
            this.lblNoanswer.Location = new System.Drawing.Point(707, 811);
            this.lblNoanswer.Name = "lblNoanswer";
            this.lblNoanswer.Size = new System.Drawing.Size(628, 48);
            this.lblNoanswer.TabIndex = 5;
            this.lblNoanswer.Text = "You have not choosen a Answer!";
            this.lblNoanswer.Visible = false;
            // 
            // lblNoquestion
            // 
            this.lblNoquestion.AutoSize = true;
            this.lblNoquestion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblNoquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblNoquestion.ForeColor = System.Drawing.Color.Red;
            this.lblNoquestion.Location = new System.Drawing.Point(707, 811);
            this.lblNoquestion.Name = "lblNoquestion";
            this.lblNoquestion.Size = new System.Drawing.Size(641, 48);
            this.lblNoquestion.TabIndex = 6;
            this.lblNoquestion.Text = "You have not entered a Question!";
            this.lblNoquestion.Visible = false;
            // 
            // MakerTrueOrFalse1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.lblNoquestion);
            this.Controls.Add(this.lblNoanswer);
            this.Controls.Add(this.btnVolgende);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.tboxVraag);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MakerTrueOrFalse1";
            this.Text = "a";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxVraag;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Label lblNoanswer;
        private System.Windows.Forms.Label lblNoquestion;
    }
}

