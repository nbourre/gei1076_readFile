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

namespace ex_lecture_fichier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiledialog_Click(object sender, EventArgs e)
        {
            if (ofdRechercheFichier.ShowDialog() == DialogResult.OK || ofdRechercheFichier.ShowDialog() == DialogResult.Yes)
            {
                txtFilename.Text = ofdRechercheFichier.FileName;
                txtFileContent.Text = getFileContent( txtFilename.Text);

                if (txtFileContent.Text.Split('\n').Length > 20)
                {
                    txtFileContent.ScrollBars = ScrollBars.Vertical;
                }
            }
        }

        string getFileContent(String filename)
        {
            string result = null;

            using (StreamReader sr = new StreamReader(filename))
            {
                result = sr.ReadToEnd();
            }

            return result;

        }
    }
}
