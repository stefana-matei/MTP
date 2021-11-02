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
    public partial class Form2 : Form
    {
        string nume, test;
        Intrebare intrebareAfisata;


        public Form2(string nume, string test)
        {
            InitializeComponent();
            this.nume = nume;
            this.test = test;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        List<Intrebare> TestGrila = new List<Intrebare>();
        public int totalIntrebari;
        public int punctaj = 0;
        public int intrebareCurenta = 0;


        private void Form2_Load(object sender, EventArgs e)
        {
            CitireFisierXML();
        }


        private void CitireFisierXML()
        {
            txtCandidat.Text = nume;
 

            XmlDocument xmlDocument = new XmlDocument();
            XmlNode xmlNode;
            FileStream fileStream = new FileStream(test + ".xml", FileMode.Open, FileAccess.Read);
            xmlDocument.Load(fileStream);
            xmlNode = xmlDocument.ChildNodes[1];
            XmlNodeList nodeList = xmlNode.ChildNodes;


            foreach (XmlNode nodeIntrebare in nodeList)
            {           
                int nrIntrebare = 0;
                string tipIntrebare = "";
                string textIntrebare = "";
                int nrVarianteRaspuns = 0;
                string[] varianteRaspuns = new string[2];
                string pathPoza = ""; // daca exista
                string raspunsuriCorecte = "";


                if (nodeIntrebare.Name == "intrebare")
                {
                    if (nodeIntrebare.HasChildNodes)
                    {

                        foreach(XmlNode childIntrebare in nodeIntrebare.ChildNodes)
                        {
                            switch(childIntrebare.Name)
                            {
                                case "nrIntrebare":

                                    nrIntrebare = Convert.ToInt16(childIntrebare.InnerText);
                                    break;


                                case "tipIntrebare":

                                    tipIntrebare = childIntrebare.InnerText;
                                    break;


                                case "textIntrebare":

                                    textIntrebare = childIntrebare.InnerText;
                                    break;


                                case "varianteRaspuns":

                                    if (childIntrebare.HasChildNodes)
                                    {

                                        XmlNodeList nodeList1 = childIntrebare.ChildNodes;
                                        nrVarianteRaspuns = nodeList1.Count;
                                        varianteRaspuns = new string[nodeList1.Count];


                                        for (int i = 0; i < nodeList1.Count; i++)
                                        {
                                            varianteRaspuns[i] = nodeList1[i].InnerText;
                                        }
                                    }

                                    break;


                                case "linkPoza":

                                    pathPoza = childIntrebare.InnerText;
                                    break;


                                case "raspunsuriCorecte":
                                    
                                    raspunsuriCorecte = childIntrebare.InnerText;
                                    break;

                            }
                        }
                    }
                }


                Intrebare intrebare = new Intrebare(nrIntrebare, tipIntrebare, textIntrebare, nrVarianteRaspuns, varianteRaspuns, pathPoza, raspunsuriCorecte);
                TestGrila.Add(intrebare);
            }


            totalIntrebari = TestGrila.Count();
            txtNrIntrebari.Text = totalIntrebari.ToString();


            lblIntrebare.Text = TestGrila[0].TextIntrebare;
            Incarcare_variante_raspuns(0);


            string link = TestGrila[0].PathPoza;
            if (!link.Equals("0"))
            {
                picbPoza.SizeMode = PictureBoxSizeMode.StretchImage;
                picbPoza.Image = Image.FromFile(link);
            }
        }


        private void btnUrmIntrebare_Click(object sender, EventArgs e)
        {

            string[] raspunsCorect = txtRaspunsuriCorecte.Text.Split(',');
            string[] raspunsuri = new string[raspunsCorect.Length];
            int count = 0;
            bool check = false;
            int nrVariante = flpVarianteRaspuns.Controls.Count;




            for (int i = 1; i <= nrVariante; i++)
            {
                bool individualCheck = false;
                bool individualCorect = false;

                if (flpVarianteRaspuns.Controls[i - 1].Name.Contains("ck"))
                {
                    CheckBox checkBox = (CheckBox)flpVarianteRaspuns.Controls[i - 1];
                    if (checkBox.Checked == true && raspunsCorect.Contains(i.ToString()))
                    {
                        raspunsuri[count] = i.ToString();
                        count++;

                        // Tinem minte fiecare raspuns individual corect
                        individualCorect = true;

                        if (Enumerable.SequenceEqual(raspunsCorect, raspunsuri))
                        {
                            punctaj++;
                            check = true;
                        }
                    }

                    // Tinem minte fiecare raspuns individual, corect sau gresit
                    individualCheck = checkBox.Checked;
                }
                else
                {
                    RadioButton radioButton = (RadioButton)flpVarianteRaspuns.Controls[i - 1];
                    if (radioButton.Checked == true && raspunsCorect.Contains(i.ToString()))
                    {
                        punctaj++;
                        individualCheck = true;
                        individualCorect = true;
                        check = true;
                    }
                }

                // Tinem minte in intrebarea afisata ce raspunsuri au fost corecte
                intrebareAfisata.UserRaspunsuri[i-1] = individualCheck;
                intrebareAfisata.UserRaspunsuriCorecte[i - 1] = individualCorect;

            }


            intrebareAfisata.UserPass = check;


            txtPunctaj.Text = punctaj.ToString();

            // Intrebarea urmatoare 

            if (intrebareCurenta < totalIntrebari - 1)
            {
                intrebareCurenta++;


                lblIntrebare.Text = TestGrila[intrebareCurenta].TextIntrebare;
                Incarcare_variante_raspuns(intrebareCurenta);


                string link = TestGrila[intrebareCurenta].PathPoza;
                if (!link.Equals("0"))
                {
                    picbPoza.Image = Image.FromFile(link);
                }
                //txtRaspunsuriCorecte.Text = TestGrila[0].RaspunsCorect;

            }
            else
            {
                MessageBox.Show("Testul s-a incheiat!");
                btnUrmIntrebare.Enabled = false;
                this.VerificareFinala();
            }



        }

        private void Incarcare_variante_raspuns(int x)
        {
            this.intrebareAfisata = TestGrila[x];

            flpVarianteRaspuns.Controls.Clear();
            flpVarianteRaspuns.FlowDirection = FlowDirection.TopDown;
            txtRaspunsuriCorecte.Text = TestGrila[x].RaspunsCorect;


            if (TestGrila[x].TipIntrebare == "multiple")
            {
                for (int i = 0; i < TestGrila[x].NrVarianteRaspuns; i++)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = TestGrila[x].VarianteRaspuns[i];
                    checkBox.Name = "ck" + (i + 1).ToString();
                    flpVarianteRaspuns.Controls.Add(checkBox);
                }
            }
            else if (TestGrila[x].TipIntrebare == "single")
            {
                for (int i = 0; i < TestGrila[x].NrVarianteRaspuns; i++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Text = TestGrila[x].VarianteRaspuns[i];
                    radioButton.Name = "rb" + (i + 1).ToString();
                    flpVarianteRaspuns.Controls.Add(radioButton);
                }
            }
        }

        private void VerificareFinala()
        {
            foreach(Intrebare intrebare in TestGrila)
            {
                // Check if user fucked up
                // MessageBox.Show(intrebare.UserPass.ToString());

                string afisare = "";

                // Per intrebare
                if(intrebare.UserPass)
                {
                    afisare += "Userul a raspuns corect la intrebare! \n";
                }
                else
                {
                    afisare += "Userul a gresit intrebarea! \n";
                }


                // Per raspuns indiferent de corectitudine
                afisare += "\n Raspunsuri: ";

                foreach (bool checkbox in intrebare.UserRaspunsuri)
                {
                    afisare += checkbox.ToString();
                }


                // Per raspuns corect
                afisare += "\n Corecte:       ";
                foreach (bool checkbox in intrebare.UserRaspunsuriCorecte)
                {
                    afisare += checkbox.ToString();
                }

                MessageBox.Show(afisare);
            }
        }


    }
}
