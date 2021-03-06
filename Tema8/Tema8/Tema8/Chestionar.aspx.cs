using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Tema8
{
    public partial class Chestionar : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            xmlLoad();
        }


        private void xmlLoad()
        {
            XmlDocument xmlSursa = new XmlDocument();
            string nume_fisier = Request.QueryString["chestionar"];
            lblChestionar.Text = "Chestionar ales: " + nume_fisier;
            xmlSursa.Load(Server.MapPath("~/Formulare/" + nume_fisier + ".xml"));


            //  luam toate nodurile textbox
            XmlNodeList txtbNodeList = xmlSursa.SelectNodes("//Chestionar//textbox");
            foreach (XmlNode text in txtbNodeList)
            {
                string detaliiValue = text.Attributes["detalii"].Value;
                PlaceHolder1.Controls.Add(new LiteralControl("<p/>" + detaliiValue));


                //  textbox generat
                TextBox textBox = new TextBox();
                textBox.ID = text.Attributes["nume"].Value;
                textBox.Text = "";
                PlaceHolder1.Controls.Add(new LiteralControl("<p/>"));
                PlaceHolder1.Controls.Add(textBox);
            }


            //  luam toate nodurile radioButton
            XmlNodeList nodesRB = xmlSursa.SelectNodes("//Chestionar//radio");
            foreach (XmlNode radio in nodesRB)
            {
                string detaliiValue = radio.Attributes["detalii"].Value;
                PlaceHolder1.Controls.Add(new LiteralControl("<p/>" + detaliiValue));
                RadioButtonList radioButtonList = new RadioButtonList();
                radioButtonList.ID = radio.Attributes["nume"].Value;


                XmlNodeList valori = radio.ChildNodes;
                foreach (XmlNode valoare in valori)
                {
                    string nodeValoare = valoare.InnerText;
                    radioButtonList.Items.Add(nodeValoare);
                }
                radioButtonList.RepeatDirection = RepeatDirection.Horizontal;
                PlaceHolder1.Controls.Add(radioButtonList);
            }
        }

        protected void btnSalvareChestionar_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in PlaceHolder1.Controls.OfType<TextBox>())
            {
                string numeControl = txt.ID;
                string valoareControl = txt.Text;

                txtRaspunsuriChestionar.Text =
                    "Nume control: " + numeControl +
                    "  Valoare: " + valoareControl +
                    Environment.NewLine;
            }


            foreach (RadioButtonList radioButton in PlaceHolder1.Controls.OfType<RadioButtonList>())
            {
                string numeControl = radioButton.ID;
                string valoareControl = radioButton.SelectedValue;

                txtRaspunsuriChestionar.Text = txtRaspunsuriChestionar.Text +
                   "Nume control: " + numeControl +
                   "  Valoare: " + valoareControl +
                   Environment.NewLine;
            }
        }
    }
}