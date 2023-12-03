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
        string timerSpeed;
        string Quizname;
        private void btn10Sec_Click(object sender, EventArgs e)
        {
            timerSpeed = "10";
        }

        private void btn20Sec_Click(object sender, EventArgs e)
        {
            timerSpeed = "20";
        }

        private void btn30Sec_Click(object sender, EventArgs e)
        {
            timerSpeed = "30";
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            Quizname = tboxQuizname.Text;
            fileSend();
        }


        private async void fileSend()
        {
            string folderPathQuizname = Path.Combine(Application.StartupPath, "database", Quizname);
            if (!Directory.Exists(folderPathQuizname))
            {
                Directory.CreateDirectory(folderPathQuizname);
                

                StreamWriter timerSpeedtxt = new StreamWriter(Application.StartupPath + "\\database\\" + $"\\{Quizname}\\" + $"{Quizname}timerSpeed.txt");
                timerSpeedtxt.WriteLine(timerSpeedtxt);
                timerSpeedtxt.Close();

                StreamWriter Quiznametxt = new StreamWriter(Application.StartupPath + "\\database\\" + $"\\{Quizname}\\" + $"{Quizname}.txt");
                Quiznametxt.WriteLine(Quiznametxt);
                Quiznametxt.Close();
            }
            }
        }
}

