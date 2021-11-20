using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tema8
{
    public partial class Proiecte : System.Web.UI.Page
    {
        static string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Firma;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connect);
        SqlCommand sqlCommand;
        SqlDataReader dataReader;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string cnp = Request.QueryString["cnp"];
                txtCNP.Text = cnp;
                txtCNP.Enabled = false;


                try
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("SELECT numeProiect FROM Proiecte", sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();


                    while (dataReader.Read())
                    {
                        ddlProiecte.Items.Add(dataReader[0].ToString());
                    }
                }
                catch(Exception exception)
                {
                    lblEroareBD.Text = "Nu se poate realiza conexiunea " + exception.Message;
                }
                finally
                {
                    sqlConnection.Close();
                }

            }
        }

        protected void btnAdaugare_Click(object sender, EventArgs e)
        {

        }
    }
}