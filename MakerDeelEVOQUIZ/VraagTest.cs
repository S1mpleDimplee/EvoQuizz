using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakerDeelEVOQUIZ
{
    public partial class FormVraagTest : Form
    {

        public string Question
        {
            get => question; internal set
            {
                question = value;
            }
        }

        public bool Answer
        {
            get => answer; internal set
            {
                answer = value;
            }
        }

        private string question;

        int timerSpeed = 20;
        int totalScore = 1000;
        int timer3 = 20;
        int finalScore = 0;
        int loop = 1;

        bool LoopStop = false;

        bool AnswerUser;
        private bool answer;

        public FormVraagTest()
        {
            InitializeComponent();
        }

        private async void VraagTest_Load(object sender, EventArgs e)
        {
            btnFalse.FlatStyle = FlatStyle.Flat;
            btnFalse.FlatAppearance.BorderSize = 0;
            btnTrue.FlatStyle = FlatStyle.Flat;
            btnTrue.FlatAppearance.BorderSize = 0;
            await Task.Delay(1);
            lblVraag.Text = question;
            while (true)
            {
                await Task.Delay(40);
                prbTijd.Value++;
                if (prbTijd.Value == 100)
                {
                    btnFalse.Visible = true;
                    btnTrue.Visible = true;
                    prbTijd.Visible = false;
                    startcount();
                    break;
                }
            }

        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            AnswerUser = true;

            if (AnswerUser == answer)
            {
                BackColor = Color.Lime;
                LoopStop = true;
                lblScore.ForeColor = Color.Lime;
                btnFalse.Enabled = false;
                btnTrue.Enabled = false;
                btnTrue.BackColor = Color.LightGreen;
            }
            else
            {
                btnTrue.BackColor = Color.LightGreen;
                totalScore = 0;
                lblScore.Text = "Score: +" + totalScore.ToString();
                lblScore.Visible = true;
                BackColor = Color.Red;
                LoopStop = true;
                lblScore.ForeColor = Color.Red;
                btnFalse.Enabled = false;
                btnTrue.Enabled = false;
            }
        }
        private void btnFalse_Click(object sender, EventArgs e)
        {
            {
                AnswerUser = false;
                if (AnswerUser == answer)
                {
                    btnFalse.BackColor = Color.IndianRed;
                    BackColor = Color.Lime;
                    LoopStop = true;
                    lblScore.ForeColor = Color.Lime;
                    btnFalse.Enabled = false;
                    btnTrue.Enabled = false;

                }
                else
                {
                    btnFalse.BackColor = Color.IndianRed;
                    totalScore = 0;
                    lblScore.Text = "Score: +" + totalScore.ToString();
                    lblScore.Visible = true;
                    BackColor = Color.Red;
                    LoopStop = true;
                    lblScore.ForeColor = Color.Red;
                    btnFalse.Enabled = false;
                    btnTrue.Enabled = false;

                }
            }
        }


        private async void startcount()
        {
            while (totalScore > 500 && loop == 1)
            {
                switch (timerSpeed)
                {
                    case 20:
                        totalScore--;
                        await Task.Delay(33);
                        lblTimer.Text = "Time: " + timer3.ToString();
                        switch (totalScore)
                        {
                            case 1000:
                                punten20();
                                break;
                            case 975:
                                punten20();
                                break;
                            case 950:
                                punten20();
                                break;
                            case 925:
                                punten20();
                                break;
                            case 900:
                                punten20();
                                break;
                            case 875:
                                punten20();
                                break;
                            case 850:
                                punten20();
                                break;
                            case 825:
                                punten20();
                                break;
                            case 800:
                                punten20();
                                break;
                            case 775:
                                punten20();
                                break;
                            case 750:
                                punten20();
                                break;
                            case 725:
                                punten20();
                                break;
                            case 700:
                                punten20();
                                break;
                            case 675:
                                punten20();
                                break;
                            case 650:
                                punten20();
                                break;
                            case 625:
                                punten20();
                                break;
                            case 600:
                                punten20();
                                break;
                            case 575:
                                punten20();
                                break;
                            case 550:
                                punten20();
                                break;
                            case 525:
                                punten20();
                                break;
                            case 500:
                                punten20();
                                BackColor = Color.Red;
                                btnFalse.BackColor = Color.Red;
                                totalScore = 0;
                                lblScore.Text = "Score: +" + totalScore.ToString();
                                lblScore.Visible = true;
                                btnFalse.Enabled = false;
                                btnTrue.Enabled = false;
                                break;
                        }
                        break;
                }
            }
        }

        private async void punten20()
        {
            timer3--;
            lblTimer.Text = "Time: " + timer3.ToString();
            if (LoopStop == true)
            {
                lblScore.Text = "Score: +" + totalScore.ToString();
                lblScore.Visible = true;
                finalScore += totalScore;
                loop = 0;
                await Task.Delay(5000);
                Formleaderboard formleaderboard = new Formleaderboard();
                formleaderboard.finalScore = finalScore;
                this.Hide();
                formleaderboard.Show();
            }
        }
    }
}
