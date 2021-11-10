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
    public partial class FisaPacient : Form
    {
        string cnp;
        public FisaPacient(string cnp)
        {
            InitializeComponent();
            this.cnp = cnp;
            


            txtCNP.Text = this.cnp;
        }

        //  incarcare informatii din baza de date
        private void FisaPacient_Load(object sender, EventArgs e)
        {
            string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Pediatrie;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();


            //  afisare datele aferente pacientului selectat din tabela Pacienti
            string queryInformatiiPacient = "SELECT * FROM Pacienti WHERE CNP='" + cnp + "'";
            SqlCommand sqlCommand = new SqlCommand(queryInformatiiPacient, sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                txtNume.Text = dataReader["Nume"].ToString();
                txtPrenume.Text = dataReader["Prenume"].ToString();
                txtSex.Text = dataReader["Sex"].ToString();
                txtNumeMama.Text = dataReader["Nume_mama"].ToString();
                txtNumeTata.Text = dataReader["Nume_tata"].ToString();
                dtpDataNasterii.Value = DateTime.Parse(dataReader["Data_nasterii"].ToString());
                txtLocNastere.Text = dataReader["Locul_nasterii"].ToString();
                txtAPGAR.Text = dataReader["APGAR"].ToString();
                txtMedicFamilie.Text = dataReader["Medic_familie"].ToString();
                txtAntecedente.Text = dataReader["Antecedente"].ToString();


                calculareVarsta(cnp);
                showImages();
            }



            //  adaugare consultatiile pacientului selectat in DataGridView
            string queryConsultatiePacient = "SELECT * FROM Consultatii WHERE CNP='" + cnp + "'"; //  query
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryConsultatiePacient, connect);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Consultatii");
            dgvConsultatii.DataSource = dataSet.Tables["Consultatii"].DefaultView;
            
            
            sqlConnection.Close();
            sqlCommand.Dispose();
            dataReader.Close();
        }


        //  adaugare radiografii in flowLayoutPanel
        private void showImages()
        {
            PictureBox pictureBox;
            int index = 0;
            flpRadiografii.Controls.Clear();


            string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Pediatrie;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();


            //  afisare radiografii, aferente pacientului selectat, din tabela radiografii
            string queryRadiografiiPacient = "SELECT * FROM radiografii WHERE CNP='" + cnp + "'";
            SqlCommand sqlCommand = new SqlCommand(queryRadiografiiPacient, sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {

                string poza = dataReader["Nume_imagine"].ToString();
                string calePoza = @"E:\FACULTATE\AN 3\SEM 1\MTP\LAB\TEME\Tema6\" + poza;


                //  generare poza
                pictureBox = new PictureBox();


                //  setare proprietatile pozei
                pictureBox.Name = "Picture" + index.ToString();
                pictureBox.SetBounds(0, 0, 90, 70);
                pictureBox.BackColor = Color.Black;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = Bitmap.FromFile(calePoza);
                pictureBox.Tag = index++;


                flpRadiografii.Controls.Add(pictureBox);
                pictureBox.Click += PictureBox_Click;

            }
        }


        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            pcbClickRadiografie.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbClickRadiografie.Image = picture.Image;
            picture.BorderStyle = BorderStyle.Fixed3D;
        }


        //  calculare varsta pacient din CNP
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


        private void btnOK_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
