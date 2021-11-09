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
    public partial class Pacient : Form
    {
        string cnp;
        public Pacient()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Pediatrie;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();


            string tabelDate = "select * from Pacienti"; //  query
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tabelDate, connect);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Pacienti");
            dgvBazaDate.DataSource = dataSet.Tables["Pacienti"].DefaultView;
            sqlConnection.Close();
        }


        private void btnCautareNume_Click(object sender, EventArgs e)
        {
            string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Pediatrie;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();


            string tablePacientNume = "SELECT * FROM Pacienti WHERE nume='" + txtNumeCautat.Text + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tablePacientNume, sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Pacienti");
            dgvBazaDate.DataSource = dataSet.Tables["Pacienti"].DefaultView;
            sqlConnection.Close();
            dataAdapter.Dispose();
            dataSet.Dispose();
        }


        private void btnAdaugaPacient_Click(object sender, EventArgs e)
        {
            AdaugarePacient adaugarePacient = new AdaugarePacient();
            adaugarePacient.Show();
        }


        private void btnInchidereAplicatie_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvBazaDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBazaDate.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvBazaDate.CurrentRow.Selected = true;
                cnp = dgvBazaDate.Rows[e.RowIndex].Cells["CNP"].FormattedValue.ToString();
            }
        }


        //  adaugare consultatie
        private void btnAdaugaConsultatie_Click(object sender, EventArgs e)
        {

            if (dgvBazaDate.CurrentRow.Selected)
            {
                Consultatie consultatie = new Consultatie(cnp);
                consultatie.ShowDialog();
            }
            else
                MessageBox.Show("Trebuie selectat un pacient pentru a adauga o consultatie!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        //  adaugare radiografie
        private void btnAdgRadiografii_Click(object sender, EventArgs e)
        {
            if (dgvBazaDate.CurrentRow.Selected)
            {
                Radiografie radiografie = new Radiografie(cnp);
                radiografie.ShowDialog();
            }
            else
                MessageBox.Show("Trebuie selectat un pacient pentru a adauga o radiografie!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        //  vizualizare fisa pacient
        private void btnVizualizareFisaPacient_Click(object sender, EventArgs e)
        {
            if (dgvBazaDate.CurrentRow.Selected)
            {
                FisaPacient fisaPacient = new FisaPacient(cnp);
                fisaPacient.ShowDialog();
            }
            else
                MessageBox.Show("Trebuie selectat un pacient pentru a vizualiza fisa acestuia!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        //  stergere pacient selectat din DataGridView
        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (dgvBazaDate.CurrentRow.Selected)
            {
                MessageBox.Show("Sunteti sigur ca doriti stergerea acestui pacient din BD?", "Atentionare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Trebuie selectat un pacient pentru a vizualiza fisa acestuia!", "Atentionare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}