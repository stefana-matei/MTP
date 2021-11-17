using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Tema7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] medici = File.ReadAllLines(Server.MapPath("~/Fisiere/") + "medici.txt");
                foreach (var line in medici)
                {
                    string[] medic = line.Split(',');
                    ddlMedici.Items.Add(medic[0]);
                }
            }
        }

        protected void btnAutentificare_Click(object sender, EventArgs e)
        {
            string[] medici = File.ReadAllLines(Server.MapPath("~/Fisiere/") + "medici.txt");
            foreach (var line in medici)
            {
                string[] medic = line.Split(',');


                if ((ddlMedici.Text).Equals(medic[0]))
                {
                    if (txtParola.Text.Trim().Equals(medic[1].Trim()))
                    {
                        Response.Redirect("VizualizarePacienti.aspx?medic=" + ddlMedici.Text.Trim());
                    }
                    else
                    {
                        string script = "alert(\"Parola incorecta!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }
                }
            }
        }
    }
}