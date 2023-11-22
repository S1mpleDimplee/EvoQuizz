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
            //Dit maakt de button borders ontzichtbar
            btnFalse.FlatStyle = FlatStyle.Flat;
            btnFalse.FlatAppearance.BorderSize = 0;
            btnTrue.FlatStyle = FlatStyle.Flat;
            btnTrue.FlatAppearance.BorderSize = 0;

            this.btnNext.BackColor = Color.Transparent;

        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            Answer = true; //Geeft het antwoord de waarde true

            CheckAnswer = true; //Kijkt of er wel True of False is ingedrukt

            //Maakt de buttons andere kleur
            btnTrue.BackColor = Color.Lime;
            btnFalse.BackColor = Color.DarkRed;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            Answer = false; //Geeft het antwoord de waarde False

            CheckAnswer = true; //Kijkt of er wel True of False is ingedrukt

            //Maakt de buttons andere kleur
            btnFalse.BackColor = Color.Red;
            btnTrue.BackColor = Color.Green;
        }


        private void tboxVraag_TextChanged(object sender, EventArgs e)
        {
            string tbox; //Maakt snel een variable aan om te checken
            tbox = tboxVraag.Text;

            if (tbox == string.Empty) //Als de textbox leeg is dan doet hij niks en kan je niet verder
            {
                CheckQuestion = false;
            }
            else
            {
                CheckQuestion = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormVraagOptieKeuze formVraagOptieKeuze = new FormVraagOptieKeuze();
            formVraagOptieKeuze.Show();
            this.Close();
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CheckAnswer == true && CheckQuestion == true) //Kijkt of er een vraag is ingevuld en true of false is ingevuld
            {

                Question = tboxVraag.Text;
                this.Hide();
                FormVraagTest formVraagTest = new FormVraagTest();
                formVraagTest.Show();
                formVraagTest.Question = Question;
                formVraagTest.Answer = Answer;
            }
            if (CheckAnswer == false) //Als er geen true of false is ingevuld dan vermeld die dat met de label lblNoaswer
            {
                lblNoanswer.Visible = true;
                await Task.Delay(4000);
                lblNoanswer.Visible = false;
            }
            if (CheckQuestion == false) //Als er geen vraag is ingevuld dan vermeld die dat met de label lblNoquestion
            {
                lblNoquestion.Visible = true;
                await Task.Delay(4000);
                lblNoquestion.Visible = false;
            }
        }
    }
}
