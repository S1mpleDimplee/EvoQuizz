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
    public partial class PlayMadeQuizes : Form
    {
        public PlayMadeQuizes()
        {
            InitializeComponent();
        }

        int QuizNumber = 1;
        private void PlayMadeQuizes_Load(object sender, EventArgs e)
        {
            LoadingQuizes();
        }
        private void LoadingQuizes()
        {

            string pathQuizSaves = Path.Combine(Application.StartupPath + "\\database\\" + $"Quiz{QuizNumber}.txt");
            if (File.Exists(pathQuizSaves)) //Kijkt na of de file bestaat
            {
                //Leest alle lijnen van de file
                List<string> QuizName = File.ReadAllLines(pathQuizSaves).ToList();

                //Schijft alle lijnen op
                File.WriteAllLines(pathQuizSaves, QuizName);

                btnQuiz1.Visible = true;
                btnQuiz1.Text = QuizName[0];

            }
            else
            {

            }
        }
    }
}
