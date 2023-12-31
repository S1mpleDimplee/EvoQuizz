using Makerdeel2;
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
    public partial class MakerTrueOrFalseNaam : Form
    {
        public MakerTrueOrFalseNaam()
        {
            InitializeComponent();
        }
        int QuizNumber = 1;
        string timerSpeed;
        string Quizname;
        bool QuiznameCheck;
        bool QuiztimerCheck;
        private void btn10Sec_Click(object sender, EventArgs e)
        {
            timerSpeed = "10";
            btn10Sec.FlatStyle = FlatStyle.Flat;
            btn10Sec.FlatAppearance.BorderColor = Color.Gold;
            btn10Sec.FlatAppearance.BorderSize = 5;

            btn20Sec.FlatStyle = FlatStyle.Flat;
            btn20Sec.FlatAppearance.BorderColor = Color.Gray;
            btn20Sec.FlatAppearance.BorderSize = 5;

            btn30Sec.FlatStyle = FlatStyle.Flat;
            btn30Sec.FlatAppearance.BorderColor = Color.Gray;
            btn30Sec.FlatAppearance.BorderSize = 5;
            QuiztimerCheck = true;
        }

        private void btn20Sec_Click(object sender, EventArgs e)
        {
            timerSpeed = "20";
            btn10Sec.FlatStyle = FlatStyle.Flat;
            btn10Sec.FlatAppearance.BorderColor = Color.Gray;
            btn10Sec.FlatAppearance.BorderSize = 5;

            btn20Sec.FlatStyle = FlatStyle.Flat;
            btn20Sec.FlatAppearance.BorderColor = Color.Gold;
            btn20Sec.FlatAppearance.BorderSize = 5;

            btn30Sec.FlatStyle = FlatStyle.Flat;
            btn30Sec.FlatAppearance.BorderColor = Color.Gray;
            btn30Sec.FlatAppearance.BorderSize = 5;
            QuiztimerCheck = true;
        }

        private void btn30Sec_Click(object sender, EventArgs e)
        {
            timerSpeed = "30";
            btn10Sec.FlatStyle = FlatStyle.Flat;
            btn10Sec.FlatAppearance.BorderColor = Color.Gray;
            btn10Sec.FlatAppearance.BorderSize = 5;

            btn20Sec.FlatStyle = FlatStyle.Flat;
            btn20Sec.FlatAppearance.BorderColor = Color.Gray;
            btn20Sec.FlatAppearance.BorderSize = 5;

            btn30Sec.FlatStyle = FlatStyle.Flat;
            btn30Sec.FlatAppearance.BorderColor = Color.Gold;
            btn30Sec.FlatAppearance.BorderSize = 5;
            QuiztimerCheck = true;
        }


        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (QuiztimerCheck == true && QuiznameCheck == true)
            {
                Quizname = tboxQuizname.Text;
                fileSend();

                MakerTrueOrFalse makerTrueOrFalse = new MakerTrueOrFalse();
                makerTrueOrFalse.Show();
                makerTrueOrFalse.Quizname = Quizname;
                this.Hide();
            }
            else if (QuiztimerCheck == false)
            {
                lblQuiztimercheck.Visible = true;
                await Task.Delay(5000);
                lblQuiztimercheck.Visible = false;
            }
            else if (QuiznameCheck == false)
            {
                lblQuiznamecheck.Visible = true;
                await Task.Delay(5000);
                lblQuiznamecheck.Visible = false;
            }
        }


        private void fileSend()
        {
            string folderPathQuizname = Path.Combine(Application.StartupPath, "database", "dataquizquestions", Quizname);
            if (!Directory.Exists(folderPathQuizname))
            {
                Directory.CreateDirectory(folderPathQuizname);


                StreamWriter timerSpeedtxt = new StreamWriter(Application.StartupPath + "\\database\\" + "\\dataquizquestions\\" + $"\\{Quizname}\\" + $"{Quizname}timerSpeed.txt");
                timerSpeedtxt.WriteLine(timerSpeed);
                timerSpeedtxt.Close();

                StreamWriter Quiznametxt = new StreamWriter(Application.StartupPath + "\\database\\" + "\\dataquizquestions\\" + $"\\{Quizname}\\" + $"{Quizname}.txt");
                Quiznametxt.WriteLine(Quiznametxt);
                Quiznametxt.Close();

                QuizSave();

            }
        }
        private void QuizSave()
        {
            string pathQuizSaves = Path.Combine(Application.StartupPath + "\\database\\" + "\\datasavedquizes\\" + $"Quiz{QuizNumber}.txt");
            if (!File.Exists(pathQuizSaves))
            {
                StreamWriter QuizNamesaved = new StreamWriter(Application.StartupPath + "\\database\\" + "\\datasavedquizes\\" + $"Quiz{QuizNumber}.txt");
                QuizNamesaved.WriteLine(Quizname);
                QuizNamesaved.Close();
            }
            else
            {
                QuizNumber++;
            }
        }
            private void MakerTrueOrFalseNaam_Load(object sender, EventArgs e)
        {
            btn10Sec.FlatStyle = FlatStyle.Flat;
            btn10Sec.FlatAppearance.BorderColor = Color.Gray;
            btn10Sec.FlatAppearance.BorderSize = 5;

            btn20Sec.FlatStyle = FlatStyle.Flat;
            btn20Sec.FlatAppearance.BorderColor = Color.Gray;
            btn20Sec.FlatAppearance.BorderSize = 5;

            btn30Sec.FlatStyle = FlatStyle.Flat;
            btn30Sec.FlatAppearance.BorderColor = Color.Gray;
            btn30Sec.FlatAppearance.BorderSize = 5;
        }

        private void tboxQuizname_TextChanged(object sender, EventArgs e)
        {
            string textboxtext;
            textboxtext = tboxQuizname.Text;
            if (textboxtext == string.Empty)
            {
                QuiznameCheck = false;
            }
            else
            {
                QuiznameCheck = true;
            }
        }
    }
}

