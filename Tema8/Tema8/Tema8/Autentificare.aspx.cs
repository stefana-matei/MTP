using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tema8
{
    public partial class Autentificare : System.Web.UI.Page
    {

        static string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Firma;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connect);
        SqlCommand sqlCommand;
        SqlDataReader dataReader;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("SELECT NumeUtilizator FROM Users", sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();

                    //ddlUtilizatori.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                    while (dataReader.Read())
                    {

                        ddlUtilizatori.Items.Add(dataReader[0].ToString());

                    }

                    dataReader.Close();
                    sqlCommand.Dispose();
                }
                catch(Exception exception)
                {
                    lblMesajEroare.Text = "Nu se poare realiza conexiunea " + exception.Message;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        protected void btnAutentificare_Click(object sender, EventArgs e)
        {

            try
            {

                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT Parola FROM Users WHERE Numeutilizator='" 
                    + ddlUtilizatori.Text + "'", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();



                if (!dataReader.Read())
                {
                    lblMesajEroare.Text = "Datele sunt gresite!";
                }
                else
                {
                    string url;


                    if(dataReader[0].ToString().Trim() == txtParola.Text.Trim())
                    {
                        Application["numeUser"] = ddlUtilizatori.Text;
                        url = "Home.aspx";
                        lblMesajEroare.Text = "";
                        Response.Redirect(url);
                    }
                    else
                    {
                        lblMesajEroare.Text = "Parola este gresita!";
                    }
                }

            }
            catch (Exception exception)
            {
                lblMesajEroare.Text = "Nu se poate realiza conexiunea " + exception.Message;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
    }
}