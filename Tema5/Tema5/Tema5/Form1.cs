using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Tema5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] xmlFiles = Directory.GetFiles(Application.StartupPath, "*.xml");


            foreach(string xmlFile in xmlFiles)
            {
                cmbTest.Items.Add(Path.GetFileName(xmlFile).Split('.')[0]);
            }
        }


        private void txtCNP_Leave(object sender, EventArgs e)
        {
            if (verificareCNP(txtCNP.Text.Trim()) == true)
            {
                MessageBox.Show("CNP este valid!");
            }
            else
            {
                MessageBox.Show("CNP nu este valid!");
            }
        }


        public static bool verificareCNP(string cnp)
        {

            int sex, an1, an2, luna1, luna2, ziua1, ziua2, judet1, judet2,
                            n1, n2, n3, cifraControl, cCNP;

            if (cnp.Trim().Length != 13)
            {
                return false;
            }
            else
            {
                sex = Convert.ToInt32(cnp.Substring(0, 1));
                an1 = Convert.ToInt32(cnp.Substring(1, 1));
                an2 = Convert.ToInt32(cnp.Substring(2, 1));
                luna1 = Convert.ToInt32(cnp.Substring(3, 1));
                luna2 = Convert.ToInt32(cnp.Substring(4, 1));
                ziua1 = Convert.ToInt32(cnp.Substring(5, 1));
                ziua2 = Convert.ToInt32(cnp.Substring(6, 1));
                judet1 = Convert.ToInt32(cnp.Substring(7, 1));
                judet2 = Convert.ToInt32(cnp.Substring(8, 1));
                n1 = Convert.ToInt32(cnp.Substring(9, 1));
                n2 = Convert.ToInt32(cnp.Substring(10, 1));
                n3 = Convert.ToInt32(cnp.Substring(11, 1));
                cifraControl = Convert.ToInt32(((sex * 2 + an1 * 7
                    + an2 * 9 + luna1 * 1 + luna2 * 4 + ziua1 * 6
                    + ziua2 * 3 + judet1 * 5 + judet2 * 8 + n1 * 2
                    + n2 * 7 + n3 * 9) % 11));


                if (cifraControl == 10)
                {
                    cifraControl = 1;
                }


                cCNP = Convert.ToInt32(cnp.Substring(12, 1));

                if (cifraControl == cCNP)
                    return true;
                else
                    return false;
            }
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text;
            string test = cmbTest.Text;
            Form2 form2 = new Form2(nume, test);
            form2.ShowDialog();
        }
    }
}
