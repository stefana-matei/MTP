using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Tema8
{
    public partial class Home1 : System.Web.UI.Page
    {
        static string connect = @"Data source=DESKTOP-Q8KT1F7\WINCC;Initial catalog=Firma;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connect);

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "User conectat: " + (string)Application["numeUser"];


            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cnp as [CNP], nume as [Nume], prenume as [Prenume], departament as [Departament]" +
                    " FROM Angajati ORDER BY nume,prenume ",sqlConnection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                gvAngajati.DataSource = dataSet.Tables[0];
                gvAngajati.DataBind();


                //  pentru chestionare
                string[] filePaths = Directory.GetFiles(Server.MapPath("~/Formulare/"));
                foreach(string filePath in filePaths)
                {
                    ddlChestionare.Items.Add(new ListItem(Path.GetFileNameWithoutExtension(filePath)));
                }
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


        //  suprascrie evenimentele la nivelul GridView
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            foreach(GridViewRow row in gvAngajati.Rows)
            {
                if(row.RowType == DataControlRowType.DataRow)
                {
                    row.Attributes["onmouseover"] = "this.style.cursor='hand' ;" +
                        "this.style.textDecoration='underline';";
                    row.Attributes["onmouseout"] = "this.style.textDecoraation='none';";
                    row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(gvAngajati, "Select$" + row.DataItemIndex, true);
                    row.Style.Add(HtmlTextWriterStyle.Cursor, "pointer");
                }
            }
            base.Render(writer);
        }
        
        protected void btnCauta_Click(object sender, EventArgs e)
        {

            List<string> numeAngajati = new List<string>();
            foreach (GridViewRow row in gvAngajati.Rows)
            {
                numeAngajati.Add(row.Cells[1].Text.ToString());
            }


            if (numeAngajati.Contains(txtNumeCautat.Text.Trim()))
            {
                btnAdaugaProiectAngajat.Enabled = true;
                btnCompletareChestionar.Enabled = true;
                lblAngajatBD.Text = "Exista " + txtNumeCautat.Text + " in BD";
            }
            else
            {
                lblAngajatBD.Text = "Nu exista angajatul " + txtNumeCautat.Text + " in BD";
                btnAdaugaProiectAngajat.Enabled = false;
                btnCompletareChestionar.Enabled = false;
            }
        }


        protected void btnAdaugaAngajat_Click(object sender, EventArgs e)
        {
            string url = "AdaugareAngajat.aspx";
            Response.Redirect(url);
        }


        protected void btnAdaugaProiectAngajat_Click(object sender, EventArgs e)
        {
            string url;
            string cnp = gvAngajati.SelectedRow.Cells[0].Text.ToString().Trim();
            url = "AlocareProiect.aspx?cnp=" + cnp;
            Response.Redirect(url);
        }


        protected void gvAngajati_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Select")
            {
                lblAngajatBD.Text = "";
                txtNumeCautat.Text = "";
                btnAdaugaProiectAngajat.Enabled = true;
                btnCompletareChestionar.Enabled = true;
            }
        }


        protected void btnCompletareChestionar_Click(object sender, EventArgs e)
        {
            string url;
            string cnp = gvAngajati.SelectedRow.Cells[0].Text.ToString().Trim();
            url = "Chestionar.aspx?cnp=" + cnp + "&chestionar=" + ddlChestionare.Text;
            Response.Redirect(url);
        }

        protected void btnMuncaAngajat_Click(object sender, EventArgs e)
        {
            string url;
            string cnp = gvAngajati.SelectedRow.Cells[0].Text.ToString().Trim();
            string nume = gvAngajati.SelectedRow.Cells[1].Text.ToString().Trim();
            string prenume = gvAngajati.SelectedRow.Cells[2].Text.ToString().Trim();


            url = "MuncaAngajat.aspx?cnp=" + cnp + "&nume=" + nume + "&prenume=" + prenume;
            Response.Redirect(url);
        }
    }
}