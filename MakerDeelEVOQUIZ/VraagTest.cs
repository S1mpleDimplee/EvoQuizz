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
        public string Answer
        {
            get => answer; internal set
            {
                answer = value;
            }
        }

        string textvraag;
        private string question;
        private string answer;

        public FormVraagTest()
        {
            InitializeComponent();
        }

        private void VraagTest_Load(object sender, EventArgs e)
        {
            lblVraag_Click(sender, e);
            btnFalse.FlatStyle = FlatStyle.Flat;
            btnFalse.FlatAppearance.BorderSize = 0;
            btnTrue.FlatStyle = FlatStyle.Flat;
            btnTrue.FlatAppearance.BorderSize = 0;
            
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            lblVraag.Text = question;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {

        }

        private void lblVraag_Click(object sender, EventArgs e)
        {
            lblVraag.Text = question;
        }
    }
}
