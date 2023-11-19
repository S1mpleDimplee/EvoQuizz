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
            MakerTrueOrFalse1 form1 = new MakerTrueOrFalse1();
            form1.Show();
            this.Hide();
        }

 
    }
}
