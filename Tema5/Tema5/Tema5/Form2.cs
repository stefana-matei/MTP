using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema5
{
    public partial class Form2 : Form
    {
        string nume, test;


        public Form2(string nume, string test)
        {
            InitializeComponent();
            this.nume = nume;
            this.test = test;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
