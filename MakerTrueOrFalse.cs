using MakerDeelEVOQUIZ;
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

namespace Makerdeel2
{
    public partial class MakerTrueOrFalse : Form
    {
        public MakerTrueOrFalse()
        {
            InitializeComponent();
        }
        string Answer;
        bool CheckAnswer;
        bool CheckQuestion;
        int QuestionNumber = 1;
        private string quizname;

        public string Quizname
        {
            get => quizname; internal set
            {
                quizname = value;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Dit maakt de button borders ontzichtbar
            btnFalse.FlatStyle = FlatStyle.Flat;
            btnFalse.FlatAppearance.BorderSize = 8;
            btnFalse.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnTrue.FlatStyle = FlatStyle.Flat;
            btnTrue.FlatAppearance.BorderSize = 8;
            btnTrue.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            FormLoading();
            await Task.Delay(1);
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            Answer = "true"; //Geeft het antwoord de waarde true
            CheckAnswer = true; //Kijkt of er wel True of False is ingedrukt

            //Maakt de buttons andere kleur
            btnTrue.BackColor = Color.Aqua;
            btnFalse.BackColor = Color.Silver;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            Answer = "false" ; //Geeft het antwoord de waarde False

            CheckAnswer = true; //Kijkt of er wel True of False is ingedrukt

            //Maakt de buttons andere kleur
            btnFalse.BackColor = Color.Gray;
            btnTrue.BackColor = Color.MediumTurquoise;
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

        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CheckAnswer == true && CheckQuestion == true) //Kijkt of er een vraag is ingevuld en true of false is ingevuld
            {
                //Slaat de Vraag op in een text file
                StreamWriter Question1 = new StreamWriter(Application.StartupPath + "\\database\\" + $"\\{quizname}\\" + $"Question{QuestionNumber}.txt");
                Question1.WriteLine(tboxVraag.Text);
                Question1.Close();

                //Slaat het Antwoord op in een text file
                StreamWriter Question1TrueFalse = new StreamWriter(Application.StartupPath + "\\database\\" + $"\\{quizname}\\" + $"Question{QuestionNumber}TrueFalse.txt");
                Question1TrueFalse.WriteLine(Answer);
                Question1TrueFalse.Close();

                QuestionNumber = +1;

                await Task.Delay(1);
                QuestionNumberfunction();

                FormLoading();

                //Gaat naar de volgende form
                this.Hide();
                this.Show();
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

        private void QuestionNumberfunction()
        {
            StreamWriter QuestionNumber = new StreamWriter(Application.StartupPath + "\\database\\" + $"\\{quizname}\\" + "QuestionNumber.txt");
            QuestionNumber.WriteLine(QuestionNumber);
            QuestionNumber.Close();
        }

        private void FormLoading()
        {
            string filePathNumber = Path.Combine(Application.StartupPath + "\\database\\" + $"\\{quizname}\\"+ "QuestionNumber.txt");

            if (File.Exists(filePathNumber)) //Kijkt na of de file bestaat
            {
                // Leest alle lijnen van de file
                List<string> QuestionNumber = File.ReadAllLines(filePathNumber).ToList();

                // Schijft alle lijnen op
                File.WriteAllLines(filePathNumber, QuestionNumber);

                lblQuestionnumber.Text = $"Question: {QuestionNumber.ToString()}";
            }
        }
    }
}
