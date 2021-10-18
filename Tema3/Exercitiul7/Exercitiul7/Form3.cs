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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            incarcareEchipe();
        }


        private void btnAdaugareJucator_Click(object sender, EventArgs e)
        {
            
            DirectoryInfo directorEchipa = new DirectoryInfo(Application.StartupPath + @"\" + cmbEchipe.Text);


            if (!directorEchipa.Exists)
            {
                MessageBox.Show("Nu poate fi adaugat un jucator intr-o echipa inexistenta!");
            }
            else
            {
                StreamWriter fisierJucator = new StreamWriter(directorEchipa.FullName + @"\" + txtCNP.Text + ".lpf");
                fisierJucator.Write(txtNumeJucator.Text);
                fisierJucator.Write("\r\n");
                fisierJucator.Write(cmbPost.Text);
                fisierJucator.Close();


                MessageBox.Show("Jucatorul a fost adaugat in echipa!");
                Application.Restart();
            }
        }


        private void incarcareEchipe()
        {
            cmbEchipe.Items.Clear();

            foreach (string dirPath in Directory.EnumerateDirectories(Application.StartupPath))
            {
                // adaugare nume director, fara cale
                DirectoryInfo dirName = new DirectoryInfo(dirPath);
                cmbEchipe.Items.Add(dirName.Name);
            }
        }
    }
}
