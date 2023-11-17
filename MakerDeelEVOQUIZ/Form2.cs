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
    public partial class Form2 : Form
    {
        private string vraag1;

        public Form2()
        {
            InitializeComponent();
        }

        public string vraag
        {
            get => vraag1; internal set
            {
                vraag1 = value;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vraag1 = vraag;
            label1.Text = vraag1;
        }
        private void Form2_Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
