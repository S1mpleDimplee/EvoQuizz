using MakerDeelEVOQUIZ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makerdeel2
{
    public partial class MakerTrueOrFalse1 : Form
    {
        public MakerTrueOrFalse1()
        {
            InitializeComponent();
        }
        string Question;
        string Answer;

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            btnFalse.FlatStyle = FlatStyle.Flat;
            btnFalse.FlatAppearance.BorderSize = 0;
            btnTrue.FlatStyle = FlatStyle.Flat;
            btnTrue.FlatAppearance.BorderSize = 0;
            btnVolgende.FlatAppearance.BorderSize = 0;

        }
    
    private void btnTrue_Click(object sender, EventArgs e)
        {
            Answer = "true";
            btnTrue.BackColor = Color.Lime;
            btnFalse.BackColor = Color.DarkRed;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            Answer = "false";
            btnFalse.BackColor = Color.Red;
            btnTrue.BackColor = Color.Green;
        }


        private void tboxVraag_TextChanged(object sender, EventArgs e)
        {
            Question = tboxVraag.Text;
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            FormVraagTest formVraagTest = new FormVraagTest();
            Question = tboxVraag.Text;
            this.Hide();
            formVraagTest.Show();
            formVraagTest.Question = Question;
            formVraagTest.Answer = Answer;
        }

    }
}
