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
    public partial class ProiecteFirma : System.Web.UI.Page
    {

        static string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Firma;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connect);

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT numeProiect as [Nume Proiect], numarOreAlocate as [Numar ore alocate], departament as [Departament]" +
                    " FROM Proiecte ", sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                gvProiecte.DataSource = dataSet.Tables[0];
                gvProiecte.DataBind();
               
            }
            catch (Exception exception)
            {
                lblEroare.Text = "Nu se poate realiza conexiunea la BD: " + exception.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}