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
using System.IO;

namespace Tema6
{
    public partial class Radiografie : Form
    {
        string cnp;

        public Radiografie(string cnp)
        {
            InitializeComponent();
            this.cnp = cnp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            txtCNP.Text = this.cnp;
        }

        //  adaugare radiografie in BD
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtCNP.Text != string.Empty)
            {
                string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Pediatrie;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connect);
                sqlConnection.Open();


                string insertRadiografie = "INSERT INTO Radiografii ([CNP], [Data], [Nume_imagine], [Diagnostic], [Comentarii]) VALUES (@cnp, @data, @numeimagine, @diagnostic, @comentarii)";
                SqlCommand sqlCommand = new SqlCommand(insertRadiografie, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cnp", txtCNP.Text);
                sqlCommand.Parameters.AddWithValue("@data", dtpData.Value);
                sqlCommand.Parameters.AddWithValue("@numeimagine", txtImagine.Text);
                sqlCommand.Parameters.AddWithValue("@diagnostic", txtDiagnostic.Text);
                sqlCommand.Parameters.AddWithValue("@comentarii", rtxtbComentarii.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
                MessageBox.Show("A fost introdusa radiografia in baza de date!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Nu se poate adauga radiografie la un pacient fara a se introduce CNP-ul!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Restart();
            }
        }


        //  selectare noua radiografie - in BD se salveaza doar numele si extensia imaginii
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string numeImg = Path.GetFileName(openFileDialog.FileName);
                txtImagine.Text = numeImg;
            }
        }


        //  Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
