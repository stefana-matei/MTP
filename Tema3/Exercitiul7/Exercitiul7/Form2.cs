using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercitiul7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void btnAdaugareEchipa_Click(object sender, EventArgs e)
        {
            DirectoryInfo directorNou = new DirectoryInfo(Application.StartupPath + @"\" + txtEchipaNoua.Text);


            if (directorNou.Exists)
                MessageBox.Show("Directorul exista, introduceti alt nume de echipa!");
            else
            {
                directorNou.Create();
                MessageBox.Show("Directorul a fost creat!");
                Application.Restart();
            }
        }
    }
}