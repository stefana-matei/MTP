using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Tema7
{
    public partial class VizualizarePacienti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string numeMedic = Request.QueryString["medic"];
                lblMedic.Text = "Lista de pacienti a medicului: " + numeMedic;


                //  vizualizare pacienti
                string pathFileName = Server.MapPath("~/Fisiere/") + numeMedic;
                foreach (string fileName in Directory.EnumerateFiles(pathFileName, "*.txt"))
                {
                    using (StreamReader stream = new StreamReader(fileName))
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(pathFileName);
                        if (directoryInfo.Name == numeMedic)
                        {
                            string numePacient = Path.GetFileNameWithoutExtension(fileName);
                            ListBox1.Items.Add(numePacient);
                        }
                    }
                }
            }
        }


        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeMedic = Request.QueryString["medic"];
            Response.Redirect("DetaliiPacient.aspx?medic=" + numeMedic + "&pacient=" + ListBox1.SelectedItem.Text);
        }

        protected void btnAdaugarePacient_Click(object sender, EventArgs e)
        {
            string numeMedic = Request.QueryString["medic"];
            Response.Redirect("AdaugarePacient.aspx?medic=" + numeMedic);
        }
    }
    
}