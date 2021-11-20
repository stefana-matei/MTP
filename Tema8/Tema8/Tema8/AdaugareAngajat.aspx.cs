using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tema8
{
    public partial class Angajati : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdaugare_Click(object sender, EventArgs e)
        {
            string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Firma;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connect);
            SqlCommand sqlCommand;


            if (txtCNP.Text == string.Empty)
            {
                lblEroareCNP.Text = "CNP - Camp obligatoriu";
            }
            else if (!verificareCNP(txtCNP.Text))
            {
                lblEroareCNP.Text = "CNP INVALID";
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("INSERT INTO Angajati (cnp,nume,prenume,departament) values(@cnp,@nume,@prenume,@departament) ", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@cnp", txtCNP.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@nume", txtNume.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@prenume", txtPrenume.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@departament", txtDepartament.Text.Trim());


                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected == 1)
                    {
                        Response.Redirect("Home.aspx");
                    }
                    else
                        lblEroareBD.Text = "Eroare la inserare in BD";

                }
                catch (Exception exception)
                {
                    lblEroareBD.Text = "Eroare la deschiderea bazei de date! " + exception.Message;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }


        public static bool verificareCNP(string cnp)
        {
            int sex, an1, an2, ziua1, ziua2, luna1, luna2, judet1, judet2, n1, n2, n3, cifc, u;


            if (cnp.Trim().Length != 13)
            {
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


                if (cifc == 10)
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
    }
}