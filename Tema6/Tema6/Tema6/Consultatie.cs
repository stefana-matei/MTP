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
    public partial class Consultatie : Form
    {
        string cnp;
        public Consultatie(string cnp)
        {
            InitializeComponent();
            this.cnp = cnp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            txtCNP.Text = cnp;
        }


        //  adaugare consultatie in BD
        private void btnAdaugaConsultatie_Click(object sender, EventArgs e)
        {
            if (txtCNP.Text != string.Empty)
            {
                string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Pediatrie;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connect);
                sqlConnection.Open();


                string insertConsultatie = "INSERT INTO Consultatii ([CNP], [Data], [Simptome], [Diagnostic], [Tratament]) VALUES (@cnp, @data, @simptome, @diagnostic, @tratament)";
                SqlCommand sqlCommand = new SqlCommand(insertConsultatie, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@cnp", txtCNP.Text);
                sqlCommand.Parameters.AddWithValue("@data", dtpData.Value);
                sqlCommand.Parameters.AddWithValue("@simptome", txtSimptome.Text);
                sqlCommand.Parameters.AddWithValue("@diagnostic", txtDiagnostic.Text);
                sqlCommand.Parameters.AddWithValue("@tratament", txtTratament.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
                MessageBox.Show("A fost introdusa consultatia in baza de date!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Nu se poate adauga consultatie la un pacient fara a se introduce CNP-ul!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Restart();
            }
        }
    }
}
