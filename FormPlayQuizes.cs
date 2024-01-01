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
    public partial class FormPlayQuizes : Form
    {
        public FormPlayQuizes()
        {
            InitializeComponent();
        }

        private void btnQuizesPlayers_Click(object sender, EventArgs e)
        {
            QuizesMadeByPlayersPage playMadeQuizes = new QuizesMadeByPlayersPage();
            playMadeQuizes.Show();
            this.Hide();
        }

        private void FormPlayQuizes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            this.Close();
        }
    }
}
