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
        private string antwoord1;

        public string antwoord
        {
            get => antwoord1; internal set
            {
                antwoord1 = value;
            }
        }

        public string vraag { get; internal set; }
        string textvraag;

        public FormVraagTest()
        {
            InitializeComponent();
        }

        private void VraagTest_Load(object sender, EventArgs e)
        {
            btnFalse.FlatStyle = FlatStyle.Flat;
            btnFalse.FlatAppearance.BorderSize = 0;
            btnTrue.FlatStyle = FlatStyle.Flat;
            btnTrue.FlatAppearance.BorderSize = 0;
            textvraag = vraag;
            lblVraag.Text = textvraag;

            if (antwoord == "true")
            {
                btnFalse.BackColor = Color.Red;
            }


        }

        private void btnTrue_Click(object sender, EventArgs e)
        {

        }

        private void btnFalse_Click(object sender, EventArgs e)
        {

        }
    }
}
