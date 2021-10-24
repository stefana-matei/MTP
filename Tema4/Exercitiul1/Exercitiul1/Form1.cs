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
            int xOffSet = 20;
            int height = 0;


            XmlDocument xmlDocument = new XmlDocument();
            XmlNode xmlNode;
            FileStream fileStream = new FileStream("fisier.xml", FileMode.Open, FileAccess.Read);
            xmlDocument.Load(fileStream);
            xmlNode = xmlDocument.ChildNodes[1];
            XmlNodeList list = xmlNode.ChildNodes;


            foreach(XmlNode node in list)
            {
                
                if (node.Name == "textBox")
                {
                    Label lblTextBox = new Label();
                    string atributNume = node.Attributes["nume"].Value;
                    string atributDetalii = node.Attributes["detalii"].Value;
                    

                    lblTextBox.Text = atributNume;
                    lblTextBox.Left = xOffSet;


                    TextBox textBox = new TextBox();
                    textBox.Text = atributDetalii;
                    textBox.Name = atributNume;
                    textBox.Left = xOffSet + 100;
                    textBox.Top = height;
                    lblTextBox.Top = height;
                    height += 30;


                    this.Controls.Add(lblTextBox);
                    this.Controls.Add(textBox);
                }
                if (node.Name == "radioButton")
                {

                    Label lblRadioBtn = new Label();
                    string atributNume = node.Attributes["nume"].Value;
                    string atributDetalii = node.Attributes["detalii"].Value;


                    lblRadioBtn.Text = atributDetalii;
                    lblRadioBtn.Name = atributNume;
                    lblRadioBtn.Location = new Point(xOffSet, 100);
                    this.Controls.Add(lblRadioBtn);


                    if (node.HasChildNodes)
                    {
                        XmlNodeList nodeList = node.ChildNodes;
                        var radioButton = new RadioButton[nodeList.Count];
                        for (int i = 0; i < nodeList.Count; i++)
                        {
                            radioButton[i] = new RadioButton();
                            radioButton[i].Text = nodeList[i].InnerText;
                            radioButton[i].Location = new Point(xOffSet + 100 + i * 104, 96);
                            this.Controls.Add(radioButton[i]);
                        }
                    }
                }
                if (node.Name == "checkBox")
                {

                    Label lblCheckBox = new Label();
                    string atributNume = node.Attributes["nume"].Value;
                    string atributDetalii = node.Attributes["detalii"].Value;


                    lblCheckBox.Text = atributDetalii;
                    lblCheckBox.Name = atributNume;
                    lblCheckBox.Location = new Point(xOffSet, 137);
                    lblCheckBox.AutoSize = true;
                    this.Controls.Add(lblCheckBox);
                    

                    if (node.HasChildNodes)
                    {
                        XmlNodeList nodeList = node.ChildNodes;
                        var ckbLP = new CheckBox[nodeList.Count];
                        for (int i = 0; i < (nodeList.Count); i++)
                        {
                            ckbLP[i] = new CheckBox();
                            ckbLP[i].Text = nodeList[i].InnerText;
                            ckbLP[i].Location = new Point(xOffSet, 160 + i * 25);
                            this.Controls.Add(ckbLP[i]);
                        }
                    }

                }
                if(node.Name == "listBox")
                {
                    Label lblListBox = new Label();
                    string atributJudet = node.Attributes["judet"].Value;
                    string atributDetalii = node.Attributes["detalii"].Value;

                    lblListBox.Name = atributJudet;
                    lblListBox.Text = atributDetalii;
                    lblListBox.Location = new Point(xOffSet, 300);
                    this.Controls.Add(lblListBox);


                    if (node.HasChildNodes)
                    {
                        XmlNodeList nodeList = node.ChildNodes;
                        var lsbJudet = new ListBox();


                        lsbJudet = new ListBox();
                        for (int i = 0; i < nodeList.Count; i++)
                        {
                            lsbJudet.Items.Add(nodeList[i].InnerText);
                            lsbJudet.Location = new System.Drawing.Point(xOffSet, 330) ;
                            lsbJudet.Size = new System.Drawing.Size(xOffSet + 130, 95);
                            this.Controls.Add(lsbJudet);
                        }
                    }
                }
            }
        }
    }
}