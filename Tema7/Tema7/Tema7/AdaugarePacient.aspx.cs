using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tema7
{
    public partial class AdaugarePacient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }


        protected void btnBack_Click(object sender, EventArgs e)
        {
            string numeMedic = Request.QueryString["medic"];
            Response.Redirect("VizualizarePacienti.aspx?medic=" + numeMedic);
        }


        protected void btnAdaugare_Click(object sender, EventArgs e)
        {
            string numeMedic = Request.QueryString["medic"];
            string pathFileName = Server.MapPath("~/Fisiere/") + numeMedic;


            DirectoryInfo directoryInfo = new DirectoryInfo(pathFileName);
            if (directoryInfo.Name == numeMedic)
            {
                if (verificareCNP(txtCNP.Text))
                {
                    if (isNumber(txtVarsta.Text))
                    {
                        if (isDateOfBirth(txtDataNasterii.Text))
                        {
                            StreamWriter fisierPacient = new StreamWriter(pathFileName + @"\" + txtNume.Text + ".txt");
                            fisierPacient.WriteLine(txtCNP.Text + "," + ddlSex.SelectedValue.ToString() + "," + txtLoculNasterii.Text + ","
                                    + txtDataNasterii.Text + "," + txtVarsta.Text + "," + ddlAsigurat.SelectedValue.ToString());
                            fisierPacient.Close();


                            Response.Redirect("VizualizarePacienti.aspx?medic=" + numeMedic);
                        }
                        else
                        {
                            string script = "alert(\"Data nasterii este invalida!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert(\"Varsta trebuie sa fie un numar!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
                else
                {
                    string script = "alert(\"CNP-ul introdus este invalid\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

            }
            else
            {
                string script = "alert(\"Nu exista medicul in sistem!\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
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


        public static bool isNumber(string number)
        {
            if (Regex.IsMatch(number, @"^[0-9]+$"))
            {
                return true;
            }
            else
                return false;
        }


        public static bool isDateOfBirth(string date)
        {
            if (Regex.IsMatch(date, @"[0-9]{1,2}(\/|\.)[0-9]{1,2}(\/|\.)([1-9][0-9]{3}|[0-9]{2})"))
            {
                return true;
            }
            else
                return false;
        }

    }
}