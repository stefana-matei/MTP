using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tema7
{
    public partial class DetaliiPacient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string numeMedic = Request.QueryString["medic"];
            string numePacient = Request.QueryString["pacient"];
            lblNumePacient.Text = numePacient;


            string pathFileName = Server.MapPath("~/Fisiere/") + numeMedic + @"/" + numePacient + ".txt";
            string[] informatiiPacient = File.ReadAllLines(pathFileName);
           
            foreach (var line in informatiiPacient)
            {
                using (StreamReader stream = new StreamReader(pathFileName))
                {
                    string[] pacientLine = line.Split(',');

                    if (Path.GetFileNameWithoutExtension(pathFileName) == numePacient)
                    {
                        txtCNP.Text = pacientLine[0].ToString();
                        txtSex.Text = pacientLine[1].ToString();
                        txtLoculNasterii.Text = pacientLine[2].ToString();
                        txtDataNasterii.Text = pacientLine[3].ToString();
                        txtVarsta.Text = pacientLine[4].ToString();
                        txtAsigurat.Text = pacientLine[5].ToString();
                    }
                }
            }

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            string numeMedic = Request.QueryString["medic"];
            Response.Redirect("VizualizarePacienti.aspx?medic=" + numeMedic);
        }
    }
}