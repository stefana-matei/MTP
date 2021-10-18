using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercitiul1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnGenereaza_Click(object sender, EventArgs e)
        {
            string salariuBaza = txtSalariuBaza.Text;
            string nrTicheteMasa = txtNrTicheteMasa.Text;
            string valoareTichet = txtValoareTichet.Text;
            string sporuri = txtSporuri.Text;
            string deduceri = txtDeduceri.Text;
            
            if((txtSalariuBaza.Text == "") || (txtNrTicheteMasa.Text == "") || (txtValoareTichet.Text == "") || (txtSporuri.Text == "") || (txtDeduceri.Text == ""))
            {
                MessageBox.Show("Trebuie completate campurile!");
            }
            else
            {
            
                int salariuBrut = int.Parse(txtSalariuBaza.Text) + int.Parse(txtSporuri.Text);
                float asigurariSociale = (float)(25.00 / 100.00 * salariuBrut);
                float asigurariSocialeSanatate = (float)(10.00 / 100.00 * salariuBrut);
                float impozitVenit = (float)(10.00 / 100.00 * (salariuBrut + (int.Parse(txtNrTicheteMasa.Text) * int.Parse(txtValoareTichet.Text)) - asigurariSociale - asigurariSocialeSanatate));


                if (!ckbScutireImpozit.Checked)
                {
                    float totalTaxe = asigurariSociale + asigurariSocialeSanatate + impozitVenit;
                    float salariuNet = (float)(salariuBrut - totalTaxe);
                    float restPlata = (float)(salariuNet - int.Parse(deduceri));

                    txtSalariuBrut.Text = salariuBrut.ToString();
                    txtSalariuNet.Text = salariuNet.ToString();
                    txt2Deduceri.Text = txtDeduceri.Text;
                    txtRestPlata.Text = restPlata.ToString();
                }
                else
                {
                    float totalTaxe = asigurariSociale + asigurariSocialeSanatate;
                    float salariuNet = (float)(salariuBrut - totalTaxe);
                    float restPlata = (float)(salariuNet - int.Parse(deduceri));

                    txtSalariuBrut.Text = (salariuBrut.ToString());
                    txtSalariuNet.Text = (salariuNet.ToString());
                    txt2Deduceri.Text = txtDeduceri.Text;
                    txtRestPlata.Text = (restPlata.ToString());
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSalariuBaza_TextChanged(object sender, EventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSalariuBaza.Text, @"^[0-9]*$"))
            {
                MessageBox.Show("Salariul de baza trebuie sa fie un numar valid pozitiv!");
                txtSalariuBaza.Text = txtSalariuBaza.Text.Remove(0, txtSalariuBaza.TextLength);
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNrTicheteMasa.Text, @"^[0-9]*$"))
            {
                MessageBox.Show("Numarul de tichete trebuie sa fie un numar valid pozitiv!");
                txtNrTicheteMasa.Text = txtNrTicheteMasa.Text.Remove(0, txtNrTicheteMasa.TextLength);
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(txtValoareTichet.Text, @"^[0-9]*$"))
            {
                MessageBox.Show("valoarea tichetului trebuie sa fie un numar valid pozitiv!!");
                txtValoareTichet.Text = txtValoareTichet.Text.Remove(0, txtValoareTichet.TextLength);
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSporuri.Text, @"^[0-9]*$"))
            {
                MessageBox.Show("Valoarea de sporuri trebuie sa fie un numar valid pozitiv!");
                txtSporuri.Text = txtSporuri.Text.Remove(0, txtSporuri.TextLength);
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDeduceri.Text, @"^[0-9]*$"))
            {
                MessageBox.Show("Valoarea de deduceri trebuie sa fie un numar valid pozitiv!");
                txtDeduceri.Text = txtDeduceri.Text.Remove(0, txtDeduceri.TextLength);
            }
        }
    }
}
