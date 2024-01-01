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
    public partial class QuizesMadeByPlayersPage : Form
    {
        public QuizesMadeByPlayersPage()
        {
            InitializeComponent();
        }

        int QuizClickNumber;
        int QuizNumber = 1;
        string[] QuizNameText = new string[16];



        private void PlayMadeQuizes_Load(object sender, EventArgs e)
        {
            LoadingQuizes();
        }
        private async void LoadingQuizes()
        {

            string pathQuizSaves = Path.Combine(Application.StartupPath + "\\database\\" + "\\datasavedquizes\\" + $"Quiz{QuizNumber}.txt");
            if (File.Exists(pathQuizSaves))
            {


                //Leest alle lijnen van de file
                List<string> QuizName = File.ReadAllLines(pathQuizSaves).ToList();
                File.WriteAllLines(pathQuizSaves, QuizName);
                QuizNameText[QuizNumber] = QuizName[0];
                

                await Task.Delay(1);

                loadingQuizesExtra();

                QuizNumber++;

                LoadingQuizes();
            }
            else
            {
                if (QuizNumber == 1)
                {
                    lblNoQuizes.Visible = true;
                    btnCreateQuiz.Visible = true;

                }
                else
                {

                }
            }
        }

        private void loadingQuizesExtra()
        {
            switch (QuizNumber)
            {
                case 1:
                    btnQuiz1.Text = QuizNameText[QuizNumber];
                    btnQuiz1.Visible = true;
                    QuizClickNumber = 1;
                    break;
                case 2:
                    btnQuiz2.Text = QuizNameText[QuizNumber];
                    btnQuiz2.Visible = true;
                    QuizClickNumber = 2;
                    break;
                case 3:
                    btnQuiz3.Text = QuizNameText[QuizNumber];
                    btnQuiz3.Visible = true;
                    QuizClickNumber = 3;
                    break;
                case 4:
                    btnQuiz4.Text = QuizNameText[QuizNumber];
                    btnQuiz4.Visible = true;
                    QuizClickNumber = 4;
                    break;
                case 5:
                    btnQuiz5.Text = QuizNameText[QuizNumber];
                    btnQuiz5.Visible = true;
                    QuizClickNumber = 5;
                    break;
                case 6:
                    btnQuiz6.Text = QuizNameText[QuizNumber];
                    btnQuiz6.Visible = true;
                    QuizClickNumber = 6;
                    break;
                case 7:
                    btnQuiz7.Text = QuizNameText[QuizNumber];
                    btnQuiz7.Visible = true;
                    QuizClickNumber = 7;
                    break;
                case 8:
                    btnQuiz8.Text = QuizNameText[QuizNumber];
                    btnQuiz8.Visible = true;
                    QuizClickNumber = 8;
                    break;
                case 9:
                    btnQuiz9.Text = QuizNameText[QuizNumber];
                    btnQuiz9.Visible = true;
                    QuizClickNumber = 9;
                    break;
                case 10:
                    btnQuiz10.Text = QuizNameText[QuizNumber];
                    btnQuiz10.Visible = true;
                    QuizClickNumber = 10;
                    break;
                case 11:
                    btnQuiz11.Text = QuizNameText[QuizNumber];
                    btnQuiz11.Visible = true;
                    QuizClickNumber = 11;
                    break;
                case 12:
                    btnQuiz12.Text = QuizNameText[QuizNumber];
                    btnQuiz12.Visible = true;
                    QuizClickNumber = 12;
                    break;
                case 13:
                    btnQuiz13.Text = QuizNameText[QuizNumber];
                    btnQuiz13.Visible = true;
                    QuizClickNumber = 13;
                    break;
                case 14:
                    btnQuiz14.Text = QuizNameText[QuizNumber];
                    btnQuiz14.Visible = true;
                    QuizClickNumber = 14;
                    break;
                case 15:
                    btnQuiz15.Text = QuizNameText[QuizNumber];
                    btnQuiz15.Visible = true;
                    QuizClickNumber = 15;
                    break;
                case 16:
                    btnQuiz16.Text = QuizNameText[QuizNumber];
                    btnQuiz16.Visible = true;
                    QuizClickNumber = 16;
                    break;
            }

        }
        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            FormVraagOptieKeuze FormVraagOptieKeuze = new FormVraagOptieKeuze();
            FormVraagOptieKeuze.Show();
            this.Hide();


        }

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz2_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz3_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz4_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz5_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz6_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz7_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz8_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz9_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz10_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz11_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz12_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz13_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz14_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz15_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnQuiz16_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            StreamWriter pathQuestionTrueFalse = new StreamWriter(Application.StartupPath + "\\database\\" + $"PlayedQuiz.txt");
            pathQuestionTrueFalse.WriteLine(QuizNameText[QuizClickNumber]);
            pathQuestionTrueFalse.Close();

            FormVraag1 TrueOrFalseQuiz = new FormVraag1();
            this.Hide();
            TrueOrFalseQuiz.Show();
        }

        private void QuizesMadeByPlayersPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            this.Close();
        }
    }
}
