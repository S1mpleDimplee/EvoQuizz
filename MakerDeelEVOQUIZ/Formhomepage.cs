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
    public partial class Formhomepage : Form
    {
        public Formhomepage()
        {
            InitializeComponent();
        }

        private void btnMaker_Click(object sender, EventArgs e)
        {
            FormVraagOptieKeuze formVraagOptieKeuze = new FormVraagOptieKeuze();
            formVraagOptieKeuze.Show();
            this.Hide();
        }
    }
}
