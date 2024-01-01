using Makerdeel2;
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
    public partial class FormVraagOptieKeuze : Form
    {
        public FormVraagOptieKeuze()
        {
            InitializeComponent();
        }

        private void btnMeerKeuzeVraag_Click(object sender, EventArgs e)
        {

        }

        private void btnTrueFalse_Click(object sender, EventArgs e)
        {
            //Sluit deze form en gaat naarde volgende
            MakerTrueOrFalseNaam MakerTrueOrFalseNaam = new MakerTrueOrFalseNaam();
            MakerTrueOrFalseNaam.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage formhomepage = new HomePage();
            formhomepage.Show();
            this.Hide();
        }

        private void FormVraagOptieKeuze_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            this.Close();
        }
    }
}
