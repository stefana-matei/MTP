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

namespace Spanzuratoarea
{
    public partial class Form1 : Form
    {
        const int incercariPermise = 3;

        private char[] cuvant;
        private string descriere;
        private int punctaj, incercari, litereGasite;
        private int incercariCorecte, incercariGresite;
        private int oldLitereGasite = 0;
        private List<char> litereIncercate = new List<char>();


        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            citireFisier();
            generareLitere();
            generareTextBox();
            afisareLabels();

            this.oldLitereGasite = this.litereGasite;

        }

        private void generareLitere()
        {
            Label label = new Label();
            label.Location = new System.Drawing.Point(50, 25);
            label.Size = new System.Drawing.Size(70, 20);
            label.Text = "LITERE:";
            this.Controls.Add(label);

            for (int i = 65; i <= 90; i++)
            {
                Label litera = new Label();
                litera.Location = new System.Drawing.Point(150 + (i - 65) * 15, 25);
                litera.Size = new System.Drawing.Size(15, 20);
                litera.Text = Char.ConvertFromUtf32(i);
                this.Controls.Add(litera);

                litera.Click += literaClick;
            }
        }

        private void literaClick(object sender, EventArgs e)
        {
            char litera = ((System.Windows.Forms.Label)sender).Text.ToCharArray()[0];

            if (!this.litereIncercate.Contains(litera))
            {
                this.litereIncercate.Add(litera);

                // Rescriere box + verificare litere gasite
                generareTextBox();

                if(this.oldLitereGasite != this.litereGasite)
                {
                    // Am nimerit o litera
                    this.incercariCorecte += this.litereGasite - this.oldLitereGasite;
                }
                else
                {
                    // Am gresit o litera
                    this.incercariGresite++;
                    if (this.incercariGresite == incercariPermise)
                        iesireJoc();

                }

                this.oldLitereGasite = this.litereGasite;

                // Succes
                if (this.litereGasite == this.cuvant.Length) 
                    rezolvatCuSucces();

            }

            afisareLabels();

        }

        private void generareTextBox()
        {
            flowLayoutPanel1.Controls.Clear();
            this.litereGasite = 0;

            for (int i = 0; i <= cuvant.Length - 1; i++)
            {
                TextBox textBox = new TextBox();
                char litera = cuvant[i];


                if(litera.Equals(' '))
                {
                    textBox.Text = "-";
                    this.litereGasite++;
                }
                else if(this.litereIncercate.Contains(litera))
                {
                    textBox.Text = litera.ToString();
                    this.litereGasite++;
                }


                textBox.Location = new System.Drawing.Point(10 + i * 50, 25);
                textBox.Size = new System.Drawing.Size(30, 20);
                // textBox.Click
                flowLayoutPanel1.Controls.Add(textBox);
            }

        }


        private void citireFisier()
        {
            if(!File.Exists(Application.StartupPath + @"\" + "file.txt"))
            {
                MessageBox.Show("Nu exista fisierul!");
            }
            else
            {
                string[] lines = File.ReadAllLines(Application.StartupPath + @"\" + "file.txt");
                string rand;

                
                Random random = new Random();

                rand = lines[random.Next(lines.Length)];

                string[] v = rand.Split(',');

                this.cuvant = v[0].ToArray();
                this.descriere = v[1];
            }
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }


        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void afisarePunctaj()
        {
            this.punctaj = this.incercariCorecte - this.incercariGresite;

            txtPunctaj.Text = this.punctaj.ToString();
        }


        private void afisareLabelLitereIncercate()
        {
            string text = "Litere incercate: ";

            this.litereIncercate.ForEach(litera => text = text + " " + litera.ToString());

            lblLitereIncercate.Text = text;
        }

        private void afisareScoreLabels()
        {
            lblCorecte.Text = "Corecte: " + this.incercariCorecte.ToString();
            lblGresite.Text = "Gresite: " + this.incercariGresite.ToString();
        }

        private void afisareLabels()
        {
            afisareLabelLitereIncercate();
            afisareScoreLabels();
            afisarePunctaj();
        }



        private void rezolvatCuSucces()
        {
            afisareLabels();
            MessageBox.Show("FELICITARI!");
            Application.Restart();
        }

        private void iesireJoc()
        {
            afisareLabels();
            MessageBox.Show("Ai pierdut!");
            Application.Restart();
        }
            
    }
}
