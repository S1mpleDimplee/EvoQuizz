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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MakerDeelEVOQUIZ
{
    public partial class FormVraag1 : Form
    {


        private string question;

        int timerSpeed = 20;
        int totalScore = 1000;
        int timer2 = 10;
        int timer3 = 20;
        int timer4 = 30;
        int finalScore = 0;
        int loop = 1;

        bool LoopStop = false;

        string AnswerUser;
        string answer;

        int thatis;

        public FormVraag1()
        {
            InitializeComponent();
        }

        private async void VraagTest_Load(object sender, EventArgs e)
        {
            //Maakt de button border onzichtbaar
            btnFalse.FlatStyle = FlatStyle.Flat;
            btnFalse.FlatAppearance.BorderSize = 8;
            btnFalse.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnTrue.FlatStyle = FlatStyle.Flat;
            btnTrue.FlatAppearance.BorderSize = 8;
            btnTrue.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;

            //Hier wacht hij 1 miliseconden en geeft daarna lblVraag de waarde van de variable in

            await Task.Delay(1);
            QuestionLoad();

            while (true) //Start de loop van de timer en maakt de buttons zichtbaar
            {
                await Task.Delay(40);
                prbTijd.Value++;
                if (prbTijd.Value == 100)
                {
                    await Task.Delay(680);
                    btnFalse.Visible = true;
                    btnTrue.Visible = true;
                    prbTijd.Visible = false;
                    startcount(); //Start de functie
                    break;
                }
            }

        }

        private async void btnTrue_Click(object sender, EventArgs e)
        {
            AnswerUser = "true";

            lblVraag.Visible = false;
            lblThatis.Visible = true;
            while (true)
            {
                lblThatis.Text = "That is.";
                await Task.Delay(300);
                lblThatis.Text = "That is..";
                await Task.Delay(300);
                lblThatis.Text = "That is...";
                await Task.Delay(300);
                thatis ++;

                if (thatis == 2)
                {
                    break;
                }
                break;
            }

            if (AnswerUser == answer) //Kijkt of de vraag goed is (Als de Vraag true is en de antwoord ook true bijvoorbeeld
            {
                //ForeColor = TextKleur
                lblScore.ForeColor = Color.Cyan;
                btnTrue.BackColor = Color.Cyan;

                //Stopts de Loop omdat hij true gaat
                LoopStop = true;

                //Disabled de buttons
                btnFalse.Enabled = false;
                btnTrue.Enabled = false;
            }
            else
            {
                btnTrue.BackColor = Color.Cyan;
                lblScore.ForeColor = Color.Gray;

                totalScore = 0; //Zet de score op nul omdat de vraag fout is

                lblScore.Text = "Score: +" + totalScore.ToString(); //Zet de totale score in de label
                lblScore.Visible = true;

                //Stopts de Loop omdat hij true gaat
                LoopStop = true;
                
                //Disabled the Buttons
                btnFalse.Enabled = false;
                btnTrue.Enabled = false;
            }
        }
        private void btnFalse_Click(object sender, EventArgs e)
        {
            {
                AnswerUser = "false";
                if (AnswerUser == answer)
                {
                    btnFalse.BackColor = Color.Goldenrod;
                    lblScore.ForeColor = Color.Cyan;

                    LoopStop = true;

                    btnFalse.Enabled = false;
                    btnTrue.Enabled = false;

                }
                else
                {
                    btnFalse.BackColor = Color.Goldenrod;
                    lblScore.ForeColor = Color.Gray;

                    totalScore = 0;
                    lblScore.Text = "Score: +" + totalScore.ToString();
                    lblScore.Visible = true;

                    LoopStop = true;

                    btnFalse.Enabled = false;
                    btnTrue.Enabled = false;

                }
            }
        }


        private async void startcount()
        {
            while (totalScore > 500 && loop == 1) //Kijkt of the totalScore boven de 500 is en Loop 1 is
            {
                switch (timerSpeed) //Timer speed switch case
                {
                    case 10:
                        totalScore--;
                        await Task.Delay(15);
                        lblTimer.Text = "Time: " + timer2.ToString();
                        switch (totalScore)
                        {
                            case 1000:
                                punten10();
                                break;
                            case 950:
                                punten10();
                                break;
                            case 900:
                                punten10();
                                break;
                            case 850:
                                punten10();
                                break;
                            case 800:
                                punten10();
                                break;
                            case 750:
                                punten10();
                                break;
                            case 700:
                                punten10();
                                break;
                            case 650:
                                punten10();
                                break;
                            case 600:
                                punten10();
                                break;
                            case 550:
                                punten10();
                                break;
                            case 500:
                                punten10();
                                break;
                        }

                        break;
                    case 20:

                        totalScore--; //Laat de score steeds 1 afnemen

                        await Task.Delay(33); //Wacht 33 Miliseconden

                        lblTimer.Text = "Time: " + timer3.ToString(); //Laat de Label aftellen door timer3

                        switch (totalScore)
                        {
                            case 1000:
                                punten20(); //Dit triggered steeds de Function punten20
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

                                //Veranderd de kleur naar rood omdat je telaat bent (20 sec) en dan telt het als fout
                                BackColor = Color.Red;
                                btnFalse.BackColor = Color.Red;


                                totalScore = 0;
                                lblScore.Text = "Score: +" + totalScore.ToString();
                                lblScore.Visible = true;

                                //disabled de buttons
                                btnFalse.Enabled = false;
                                btnTrue.Enabled = false;
                                break;
                        }
                        break;
                    case 30:
                        totalScore--;
                        await Task.Delay(55);
                        lblTimer.Text = "Time: " + timer4.ToString();
                        switch (totalScore)
                        {
                            case 1000:
                                punten30();
                                break;
                            case 983:
                                punten30();
                                break;
                            case 967:
                                punten30();
                                break;
                            case 951:
                                punten30();
                                break;
                            case 934:
                                punten30();
                                break;
                            case 918:
                                punten30();
                                break;
                            case 902:
                                punten30();
                                break;
                            case 885:
                                punten30();
                                break;
                            case 869:
                                punten30();
                                break;
                            case 852:
                                punten30();
                                break;
                            case 836:
                                punten30();
                                break;
                            case 820:
                                punten30();
                                break;
                            case 804:
                                punten30();
                                break;
                            case 787:
                                punten30();
                                break;
                            case 771:
                                punten30();
                                break;
                            case 755:
                                punten30();
                                break;
                            case 738:
                                punten30();
                                break;
                            case 722:
                                punten30();
                                break;
                            case 706:
                                punten30();
                                break;
                            case 689:
                                punten30();
                                break;
                            case 673:
                                punten30();
                                break;
                            case 657:
                                punten30();
                                break;
                            case 640:
                                punten30();
                                break;
                            case 624:
                                punten30();
                                break;
                            case 608:
                                punten30();
                                break;
                            case 591:
                                punten30();
                                break;
                            case 575:
                                punten30();
                                break;
                            case 559:
                                punten30();
                                break;
                            case 542:
                                punten30();
                                break;
                            case 526:
                                punten30();
                                break;
                            case 510:
                                punten30();
                                break;
                        }
                        break;
                }
            }
        }

        private async void punten10()
        {
            timer2--;

            lblTimer.Text = "Time: " + timer2.ToString();

            if (LoopStop == true)
            {
                lblScore.Text = "Score: +" + totalScore.ToString();
                lblScore.Visible = true;

                finalScore += totalScore;
                loop = 0; //Zet de loop op 0 zodat hij niet verder gaat

                await Task.Delay(5000);

                Formleaderboard formleaderboard = new Formleaderboard();
                formleaderboard.finalScore = finalScore;
                this.Hide();
                formleaderboard.Show();
            }
        }
        private async void punten20()
        {
            timer3--;

            lblTimer.Text = "Time: " + timer3.ToString();

            if (LoopStop == true)
            {
                //Laat hier de score zien
                lblScore.Text = "Score: +" + totalScore.ToString();
                lblScore.Visible = true;

                finalScore += totalScore;
                loop = 0; //Zet de loop op 0 zodat hij niet verder gaat

                await Task.Delay(5000);

                Formleaderboard formleaderboard = new Formleaderboard();
                formleaderboard.finalScore = finalScore;
                this.Hide();
                formleaderboard.Show();
            }
        }

        private async void punten30()
        {
            timer4--;

            lblTimer.Text = "Time: " + timer4.ToString();

            if (LoopStop == true)
            {
                //Laat hier de score zien
                lblScore.Text = "Score: +" + totalScore.ToString();
                lblScore.Visible = true;

                finalScore += totalScore;
                loop = 0; //Zet de loop op 0 zodat hij niet verder gaat

                await Task.Delay(5000);

                Formleaderboard formleaderboard = new Formleaderboard();
                formleaderboard.finalScore = finalScore;
                this.Hide();
                formleaderboard.Show();
            }
        }
        private void QuestionLoad()
        {
            //Vind de Path naar de file
            string filePathQuestion = Path.Combine(Application.StartupPath, "info", "Question1.txt");

            if (File.Exists(filePathQuestion)) //Kijkt na of de file bestaat
            {
                //Leest alle lijnen van de file
                List<string> Question1 = File.ReadAllLines(filePathQuestion).ToList();

                //Schijft alle lijnen op
                File.WriteAllLines(filePathQuestion, Question1);

                //Laat label zien
                if (Question1.Count > 0)
                {
                    lblVraag.Text = Question1[0];
                }
            }

            string filePathTrueFalse = Path.Combine(Application.StartupPath, "info", "Question1TrueFalse.txt");

            if (File.Exists(filePathTrueFalse)) //Kijkt na of de file bestaat
            {
                // Leest alle lijnen van de file
                List<string> Answer1 = File.ReadAllLines(filePathTrueFalse).ToList();

                // Schijft alle lijnen op
                File.WriteAllLines(filePathTrueFalse, Answer1);

                // Laat label zien
                if (Answer1.Count > 0)
                {
                    answer = Answer1[0];
                }
            }
        }
    }
}
