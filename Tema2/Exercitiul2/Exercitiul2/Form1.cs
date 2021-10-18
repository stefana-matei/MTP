using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercitiul2
{
    public partial class Form1 : Form
    {

        double left = 0, right = 0;
        string operand = "";
        bool floatMode = false;
        int floatValue = 0;


        private void calcul(int numar = 0, string operand = "")
        {
            if(floatMode)
            {
                if (floatValue == 0)
                    floatValue = numar;
                else
                    floatValue = floatValue * 10 + numar;

            }
            else {

                if (operand != "")
                {
                    this.operand = operand;
                }


                if (this.operand == "")
                {
                    if(left == 0)
                    {
                        left = numar;
                    }
                    else if (left > 0)
                    {
                        left = left * 10 + numar;

                    }
                    else if (left < 0)
                    {
                        left = left * 10 - numar;

                    }
                }
                else if (this.operand == "sqrt")
                {
                    left = Math.Sqrt(left);
                    this.operand = "";

                }
                else
                {
                    if (right == 0)
                    {
                        right = numar;
                    }
                    else if (right > 0)
                    {
                        right = right * 10 + numar;

                    }
                    else if (right < 0)
                    {
                        right = right * 10 - numar;

                    }
                }

            }


            afisareDefault();
        }

        private void afisareDefault()
        {
            if (this.operand == "")
            {
                afisare(
                    left.ToString() + 
                    (floatMode ? "." : "") + 
                    (floatValue != 0 ? floatValue.ToString() : "") + 
                    " " + 
                    this.operand
                );

            }
            else
            {
                afisare(
                    left.ToString() +
                    " " + 
                    this.operand +
                    " " +
                    right.ToString() +
                    (floatMode ? "." : "") +
                    (floatValue != 0 ? floatValue.ToString() : "")
                );
            }

        }


        private void btnEgal_Click(object sender, EventArgs e)
        {
            disableFloatMode();

            switch (operand)
            {
                case "+":
                    left = left + right;
                    break;

                case "*":
                    left = left * right;
                    break;

                case "/":
                    left = left / right;
                    break;

                case "-":
                    left = left - right;
                    break;
            }

            operand = "";
            right = 0;

            afisare(left.ToString());

        }

        private void schimbareSemn()
        {
            if (this.operand == "")
            {
                left = -1 * left;
            }
            else
            {
                right = -1 * right;
            }

            afisareDefault();
            return;
        }


        private void enableFloatMode()
        {
            floatMode = true;
            afisareDefault();
        }


        private void disableFloatMode()
        {
            if(floatMode == false)
            {
                return;
            }

            floatMode = false;

            if (this.operand == "")
            {
                left = double.Parse(left.ToString() + "." + floatValue.ToString());
            }
            else
            {
                right = double.Parse(right.ToString() + "." + floatValue.ToString());
            }

            floatValue = 0;
        }


        private void afisare(string text)
        {
            rtbAfisare.Text = text;
        }


        private void btn1_Click(object sender, EventArgs e){calcul(1);}
        private void btn2_Click(object sender, EventArgs e){calcul(2);}
        private void btn3_Click(object sender, EventArgs e){calcul(3);}
        private void btn4_Click(object sender, EventArgs e){calcul(4);}
        private void btn5_Click(object sender, EventArgs e){calcul(5);}
        private void btn6_Click(object sender, EventArgs e){calcul(6);}
        private void btn7_Click(object sender, EventArgs e){calcul(7);}
        private void btn8_Click(object sender, EventArgs e){calcul(8);}
        private void btn9_Click(object sender, EventArgs e){calcul(9);}
        private void btn0_Click(object sender, EventArgs e){calcul(0);}
        private void btnAdunare_Click(object sender, EventArgs e) { disableFloatMode(); calcul(0, "+"); }
        private void btnInmultire_Click(object sender, EventArgs e){ disableFloatMode(); calcul(0, "*"); }
        private void btnImpartire_Click(object sender, EventArgs e){ disableFloatMode(); calcul(0, "/"); }
        private void btnScadere_Click(object sender, EventArgs e)  { disableFloatMode(); calcul(0, "-"); }
        private void btnSqrt_Click(object sender, EventArgs e)     { disableFloatMode(); calcul(0, "sqrt"); }
        private void btnSemn_Click(object sender, EventArgs e)     { disableFloatMode(); schimbareSemn(); }
        private void btnPoint_Click(object sender, EventArgs e)    { enableFloatMode(); }


        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbAfisare.Clear();
            left = right = 0;
            operand = "";
            floatMode = false;
            floatValue = 0;
        }


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}