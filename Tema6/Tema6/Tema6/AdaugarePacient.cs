using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tema6
{
    public partial class AdaugarePacient : Form
    {
        public AdaugarePacient()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void txtCNP_Leave(object sender, EventArgs e)
        {
            if (verificareCNP(txtCNP.Text))
            {
                calculareVarsta(txtCNP.Text);
            }
            else
            {
                dtpDataNasterii.Value = DateTime.Now;
                txtVarsta.Text = "";
            }
        }


        public static bool verificareCNP(string cnp)
        {
            int sex, an1, an2, ziua1, ziua2, luna1, luna2, judet1, judet2, n1, n2, n3, cifc, u;
            

            if(cnp.Trim().Length != 13)
            {
                MessageBox.Show("CNP-ul introdus este invalid, trebuie sa fie de 13 cifre!");
                return false;
            }
            else
            {
                //  se extrage fiecare caracter in parte
                sex = Convert.ToInt16(cnp.Substring(0, 1));
                an1 = Convert.ToInt16(cnp.Substring(1, 1));
                an2 = Convert.ToInt16(cnp.Substring(2, 1));
                luna1 = Convert.ToInt16(cnp.Substring(3, 1));
                luna2 = Convert.ToInt16(cnp.Substring(4, 1));
                ziua1 = Convert.ToInt16(cnp.Substring(5, 1));
                ziua2 = Convert.ToInt16(cnp.Substring(6, 1)); 
                judet1 = Convert.ToInt16(cnp.Substring(7, 1));
                judet2 = Convert.ToInt16(cnp.Substring(8, 1));
                n1 = Convert.ToInt16(cnp.Substring(9, 1));
                n2 = Convert.ToInt16(cnp.Substring(10, 1));
                n3 = Convert.ToInt16(cnp.Substring(11, 1));
                cifc = Convert.ToInt16((sex * 2 + an1 * 7 + an2 * 9 + luna1 * 1
                    + luna2 * 4 + ziua1 * 6 + ziua2 * 3 + judet1 * 5 + judet2 * 8
                    + n1 * 2 + n2 * 7 + n3 * 9) % 11);


                if(cifc == 10)
                {
                    cifc = 1;
                }
                u = Convert.ToInt16(cnp.Substring(12, 1));
                
                
                if (cifc == u)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                    
            }
        }


        public void calculareVarsta(string cnp)
        {
            int an1 = Convert.ToInt32(cnp.Substring(1, 1));
            int an2 = Convert.ToInt32(cnp.Substring(2, 1));
            int luna1 = Convert.ToInt32(cnp.Substring(3, 1));
            int luna2 = Convert.ToInt32(cnp.Substring(4, 1));
            int ziua1 = Convert.ToInt32(cnp.Substring(5, 1));
            int ziua2 = Convert.ToInt32(cnp.Substring(6, 1));


            string anulNasterii = "19" + an1.ToString() + an2.ToString();
            string lunaNasterii = luna1.ToString() + luna2.ToString();
            string ziuaNasterii = ziua1.ToString() + ziua2.ToString();
            dtpDataNasterii.Value = new DateTime(Convert.ToInt32(anulNasterii), Convert.ToInt32(lunaNasterii), Convert.ToInt32(ziuaNasterii));
            DateTime dataNasterii = dtpDataNasterii.Value;
            DateTime dataCurenta = DateTime.Now;
            int varsta = dataCurenta.Year - dataNasterii.Year;


            if (dataCurenta.Month > dataNasterii.Month || (dataCurenta.Month == dataNasterii.Month && dataCurenta.Day > dataNasterii.Day))
            {
                txtVarsta.Text = varsta.ToString();
            }
            else
            {
                varsta--;
                txtVarsta.Text = varsta.ToString();
            }
        }

        private void btnSalvarePacient_Click(object sender, EventArgs e)
        {
            if(txtCNP.Text != string.Empty)
            {
                string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Pediatrie;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connect);
                sqlConnection.Open();


                string insertPacient = "INSERT INTO Pacienti ([CNP], [Nume], [Prenume], [Sex], [Nume_mama], " +
                    "[Nume_tata], [Data_nasterii], [Locul_nasterii], [APGAR], [Medic_familie], [Antecedente]) VALUES " +
                    "(@cnp, @nume, @prenume, @sex, @numemama, @numetata, @datanasterii, @loculnasterii, @apgar, @medicfamilie, @antecedente)";


                SqlCommand sqlCommand = new SqlCommand(insertPacient, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cnp", txtCNP.Text);
                sqlCommand.Parameters.AddWithValue("@nume", txtNume.Text);
                sqlCommand.Parameters.AddWithValue("@prenume", txtPrenume.Text);
                sqlCommand.Parameters.AddWithValue("@sex", txtSex.Text);
                sqlCommand.Parameters.AddWithValue("@numemama", txtNumeTata.Text);
                sqlCommand.Parameters.AddWithValue("@numetata", txtNumeTata.Text);
                sqlCommand.Parameters.AddWithValue("@datanasterii", dtpDataNasterii.Value);
                sqlCommand.Parameters.AddWithValue("@loculnasterii", txtLocNastere.Text);
                sqlCommand.Parameters.AddWithValue("@apgar", txtAPGAR.Text);
                sqlCommand.Parameters.AddWithValue("@medicfamilie", txtMedicFamilie.Text);
                sqlCommand.Parameters.AddWithValue("@antecedente", txtAntecedente.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
                MessageBox.Show("A fost introdus pacientul in baza de date!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Trebuie introdus CNP-ul");
            }
        }
    }
}
