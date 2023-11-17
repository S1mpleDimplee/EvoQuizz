using MakerDeelEVOQUIZ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makerdeel2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string vraag;
        string antwoord;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFalse.FlatStyle = FlatStyle.Flat;
            btnFalse.FlatAppearance.BorderSize = 0;
            btnTrue.FlatStyle = FlatStyle.Flat;
            btnTrue.FlatAppearance.BorderSize = 0;
            btnVolgende.FlatStyle = FlatStyle.Flat;
            btnVolgende.FlatAppearance.BorderSize = 0;
        }
        private void btnTrue_Click(object sender, EventArgs e)
        {
            antwoord = "true";
            btnTrue.BackColor = Color.Lime;
            btnFalse.BackColor = Color.DarkRed;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            antwoord = "false";
            btnFalse.BackColor = Color.Red;
            btnTrue.BackColor = Color.Green;
        }


        private void tboxVraag_TextChanged(object sender, EventArgs e)
        {
            vraag = tboxVraag.Text;
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            if (vraag == "")
            {

            }
            else
            {
                vraag = tboxVraag.Text;
                FormVraagTest formVraagTest = new FormVraagTest();
                this.Hide();
                formVraagTest.Show();
                formVraagTest.vraag = vraag;
                formVraagTest.antwoord = antwoord;
            }
        }

    }
}
