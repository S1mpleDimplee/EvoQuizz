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
    public partial class Formleaderboard : Form
    {
        private int finalScore1;

        public Formleaderboard()
        {
            InitializeComponent();
        }

        public int finalScore
        {
            get => finalScore1; internal set
            {
                finalScore1 = value;
            }
        }

        private async void Formleaderboard_Load(object sender, EventArgs e)
        {
            await Task.Delay(1);
            lblPoints1.Text = finalScore.ToString();
        }
    }
}
