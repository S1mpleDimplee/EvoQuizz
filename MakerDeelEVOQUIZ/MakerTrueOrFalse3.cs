using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakerDeelEVOQUIZ
{
    public partial class MakerTrueOrFalse3 : Form
    {
        public MakerTrueOrFalse3()
        {
            InitializeComponent();
        }

        bool Answer;

        bool CheckAnswer;
        bool CheckQuestion;


        private void MakerTrueOrFalse3_Load(object sender, EventArgs e)
        {
            //Dit maakt de button borders ontzichtbar
            btnFalse.FlatStyle = FlatStyle.Flat;
            btnFalse.FlatAppearance.BorderSize = 8;
            btnFalse.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnTrue.FlatStyle = FlatStyle.Flat;
            btnTrue.FlatAppearance.BorderSize = 8;
            btnTrue.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
        }


        private void btnTrue_Click(object sender, EventArgs e)
        {
            Answer = true; //Geeft het antwoord de waarde true

            CheckAnswer = true; //Kijkt of er wel True of False is ingedrukt

            //Maakt de buttons andere kleur
            btnTrue.BackColor = Color.Aqua;
            btnFalse.BackColor = Color.Silver;
        }

        private void btnFalse_Click_1(object sender, EventArgs e)
        {
            Answer = false; //Geeft het antwoord de waarde False

            CheckAnswer = true; //Kijkt of er wel True of False is ingedrukt

            //Maakt de buttons andere kleur
            btnFalse.BackColor = Color.Gray;
            btnTrue.BackColor = Color.MediumTurquoise;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MakerTrueOrFalse2 MakerTrueOrFalse2 = new MakerTrueOrFalse2();
            MakerTrueOrFalse2.Show();
            this.Close();
        }

        private void tboxVraag_TextChanged_1(object sender, EventArgs e)
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

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CheckAnswer == true && CheckQuestion == true) //Kijkt of er een vraag is ingevuld en true of false is ingevuld
            {
                //Slaat de Vraag op in een text file
                StreamWriter Question3 = new StreamWriter(Application.StartupPath + "\\info\\" + "Question3.txt");
                Question3.WriteLine(tboxVraag.Text);
                Question3.Close();

                //Slaat het Antwoord op in een text file
                StreamWriter Question3TrueFalse = new StreamWriter(Application.StartupPath + "\\info\\" + "Question3TrueFalse.txt");
                Question3TrueFalse.WriteLine(Answer);
                Question3TrueFalse.Close();

                this.Hide();
                MakerTrueOrFalse4 MakerTrueOrFalse4 = new MakerTrueOrFalse4();
                MakerTrueOrFalse4.Show();
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

