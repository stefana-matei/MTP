using System;
using System.Collections.Generic;
using System.Data;
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


            proiectAlocat(cnp, nume, prenume);
        }

    

        protected void ddlLuni_SelectedIndexChanged(object sender, EventArgs e)
        {
            muncaAngajat();
            oreLucrateTotal();
        }


        protected void proiectAlocat(string cnp, string nume, string prenume)
        {

            lblAngajat.Text = " Munca angajatului " + nume + " " + prenume;


            try
            {
                sqlConnection.Open();
                string query = "SELECT proiectAlocat FROM Log_proiecte WHERE CNP='" + cnp + "' AND luna='" + ddlLuni.Text.ToString() + "'";
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();


                while (dataReader.Read())
                {
                    lblProiectAlocat.Text = "Proiect alocat: " + dataReader[0].ToString();
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


        private void muncaAngajat()
        {
            string cnp = Request.QueryString["cnp"];
            string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Firma;Integrated Security=True";
            string query = "SELECT ziua as [Zi de lucru], oreLucrate as [Ore lucrate]" +
                    " FROM Log_proiecte  WHERE CNP='" + cnp + "' AND luna='" + ddlLuni.Text.ToString() + "'";

            SqlCommand sqlCommand = new SqlCommand(query);
            using (SqlConnection connection = new SqlConnection(connect))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                {
                    sqlCommand.Connection = connection;
                    dataAdapter.SelectCommand = sqlCommand;

                    using (DataSet dataSet = new DataSet())
                    {
                        dataAdapter.Fill(dataSet);
                        gvOreLucrate.DataSource = dataSet.Tables[0];
                        gvOreLucrate.DataBind();
                    }
                }
            }
        }


        private void oreLucrateTotal()
        {

            string cnp = Request.QueryString["cnp"];
            

            try
            {
                sqlConnection.Open();
                string query = "SELECT SUM(oreLucrate) * COUNT(ziua)" + " FROM Log_proiecte  WHERE CNP='" + cnp + "' AND luna='" + ddlLuni.Text.ToString() + "'";
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();


                while (dataReader.Read())
                {
                    lblOreLucrateTotal.Text = "Ore total lucrate: " + dataReader[0].ToString() + " h";
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