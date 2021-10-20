using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Reflection;

namespace Exercitiul1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            int height = 0;
            int i = 0;
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode xmlNode;
            FileStream fileStream = new FileStream("fisier.xml", FileMode.Open, FileAccess.Read);
            xmlDocument.Load(fileStream);
            xmlNode = xmlDocument.ChildNodes[1];
            XmlNodeList list = xmlNode.ChildNodes;


            foreach(XmlNode node in list)
            {

                Label label = new Label();


                if (node.Name == "textBox")
                {
                    string atributNume = "";

                    try
                    {
                        atributNume = node.Attributes["nume"].Value;
                    }
                    catch (Exception eNume)
                    {
                        try
                        {
                            atributNume = node.Attributes["CNP"].Value;
                        }
                        catch (Exception eCNP)
                        {
                            //
                        }
                    }


                    string atributDetalii = node.Attributes["detalii"].Value;
                    TextBox textBox = new TextBox();
                    textBox.Text = atributDetalii;
                    textBox.Name = atributNume;
                    label.Text = atributNume;
                    

                    textBox.Left = 100;
                    textBox.Top = height;
                    label.Top = height;
                    height += 30;


                    this.Controls.Add(label);
                    this.Controls.Add(textBox);
                }
                if (node.Name == "radioButton")
                {

                    Label lblRadioBtn = new Label();
                    string atributNume = node.Attributes["nume"].Value;
                    string atributDetalii = node.Attributes["detalii"].Value;
                    
                    
                    lblRadioBtn.Text = atributDetalii;
                    lblRadioBtn.Name = atributNume;
                    lblRadioBtn.Location = new Point(0, 100);
                    
                    
                    this.Controls.Add(lblRadioBtn);


                    if (node.HasChildNodes)
                    {
                        XmlNodeList nodeList = node.ChildNodes;
                        var radioButton = new RadioButton[nodeList.Count];
                        for (i = 0; i <= nodeList.Count - 1; i++)
                        {
                            radioButton[i] = new RadioButton();
                            radioButton[i].Text = node.ChildNodes[i].InnerText;
                            radioButton[i].Location = new Point(100 + i * 104, 96);
                            this.Controls.Add(radioButton[i]);
                        }
                    }
                }
                if(node.Name == "checkBox")
                {
                    // TODO 
                }
                if(node.Name == "listBox")
                {
                    //  TODO
                }
            }
        }
    }
}