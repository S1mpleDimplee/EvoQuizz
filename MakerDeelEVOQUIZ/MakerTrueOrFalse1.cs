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
        bool Answer;

        bool CheckAnswer;
        bool CheckQuestion;

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
            Answer = true;
            CheckAnswer = true;
            btnTrue.BackColor = Color.Lime;
            btnFalse.BackColor = Color.DarkRed;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            Answer = false;
            CheckAnswer = true;
            btnFalse.BackColor = Color.Red;
            btnTrue.BackColor = Color.Green;
        }


        private void tboxVraag_TextChanged(object sender, EventArgs e)
        {
            string tbox;
            tbox = tboxVraag.Text;
            if (tbox == string.Empty)
            {
                CheckQuestion = false;
            }
            else
            {
                CheckQuestion = true;
            }
        }

        private async void btnVolgende_Click(object sender, EventArgs e)
        {
            if (CheckAnswer == true && CheckQuestion == true)
            {

                FormVraagTest formVraagTest = new FormVraagTest();
                Question = tboxVraag.Text;
                this.Hide();
                formVraagTest.Show();
                formVraagTest.Question = Question;
                formVraagTest.Answer = Answer;
            }
            if (CheckAnswer == false)
            {
                lblNoanswer.Visible = true;
                await Task.Delay(4000);
                lblNoanswer.Visible = false;
            }
            if (CheckQuestion == false) 
            {
                lblNoquestion.Visible = true;
                await Task.Delay(4000);
                lblNoquestion.Visible = false;
            }
        }
    }
}
