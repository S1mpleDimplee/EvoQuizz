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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnMaker_Click(object sender, EventArgs e)
        {
            FormVraagOptieKeuze formVraagOptieKeuze = new FormVraagOptieKeuze();
            formVraagOptieKeuze.Show();
            this.Hide();
        }
        private void btnQuizes_Click(object sender, EventArgs e)
        {
            FormPlayQuizes formPlayQuizes = new FormPlayQuizes();
            this.Hide();
            formPlayQuizes.Show();
        }
        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            pboxPlayGif.Enabled = true;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            pboxPlayGif.Enabled = false;
        }

        private void btnCreate_MouseHover(object sender, EventArgs e)
        {
            pboxCreategif.Enabled = true;
        }

        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            pboxCreategif.Enabled = false;
        }
        private void Formhomepage_Load(object sender, EventArgs e)
        {
            pboxPlayGif.Enabled = false;
            pboxCreategif.Enabled = false;
            CreateFiles();
        }

        private void CreateFiles()
        {

            string pathDatabase = Path.Combine(Application.StartupPath, "database");
            if (!Directory.Exists(pathDatabase))
            {
                Directory.CreateDirectory(pathDatabase);
            }

            string pathDatabaseQuizes = Path.Combine(Application.StartupPath, "database", "dataquizquestions");
            if (!Directory.Exists(pathDatabaseQuizes))
            {
                Directory.CreateDirectory(pathDatabaseQuizes);
            }

            string dataquizespage = Path.Combine(Application.StartupPath, "database", "datasavedquizes");
            if (!Directory.Exists(dataquizespage))
            {
                Directory.CreateDirectory(dataquizespage);
            }
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            this.Close();
        }
    }
}
