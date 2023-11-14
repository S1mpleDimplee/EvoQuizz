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
    public partial class FormMakerBegin : Form
    {
        public FormMakerBegin()
        {
            InitializeComponent();
        }

        private void btnKlaar_Click(object sender, EventArgs e)
        {

        }

        private void btnVraagmaken_Click(object sender, EventArgs e)
        {
            FormVraagOptieKeuze formVraagOptieKeuze = new FormVraagOptieKeuze();
            formVraagOptieKeuze.ShowDialog();
            this.Close();
        }
    }
}
