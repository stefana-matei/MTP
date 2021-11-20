using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tema8
{
    public partial class MuncaAngajat : System.Web.UI.Page
    {
        static string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Firma;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connect);
        SqlCommand sqlCommand;
        SqlDataReader dataReader;

        protected void Page_Load(object sender, EventArgs e)
        {
            string cnp = Request.QueryString["cnp"];
            string nume = Request.QueryString["nume"];
            string prenume = Request.QueryString["prenume"];

            lblAngajat.Text = "Angajat: " + nume + " " + prenume;


            try
            {
                sqlConnection.Open();
                string sqlProiect = "SELECT proiectAlocat FROM Log_proiecte WHERE CNP='" + cnp + "'";
                string sqlLuna = "SELECT luna FROM Log_proiecte WHERE CNP='" + cnp + "'";
                sqlCommand = new SqlCommand(sqlProiect + sqlLuna, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();


                while (dataReader.Read())
                {
                    lblProiectAlocat.Text = "Proiect alocat: " + dataReader[0].ToString();
                }

                dataReader.NextResult();


                while (dataReader.Read())
                {
                    ddlLuni.Items.Add(dataReader[0].ToString());
                }

                dataReader.Close();

            }
            catch (Exception exception)
            {
                lblEroareBD.Text = "Nu se poate realiza conexiunea la BD " + exception.Message;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
    }
}