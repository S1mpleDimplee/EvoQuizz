using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakerDeelEVOQUIZ
{
    public partial class MakerTrueOrFalseNaam : Form
    {
        public MakerTrueOrFalseNaam()
        {
            InitializeComponent();
        }
        string timerSpeed;
        private void btn10Sec_Click(object sender, EventArgs e)
        {
            timerSpeed = "10";
            fileSend();
        }

        private void btn20Sec_Click(object sender, EventArgs e)
        {
            timerSpeed = "20";
            fileSend();
        }

        private void btn30Sec_Click(object sender, EventArgs e)
        {
            timerSpeed = "30";
            fileSend();
        }

        private void fileSend()
        {
            StreamWriter timerSpeed = new StreamWriter(Application.StartupPath + "\\info\\" + "timerSpeed.txt");
            timerSpeed.WriteLine(timerSpeed);
            timerSpeed.Close();
        }
    }
}
