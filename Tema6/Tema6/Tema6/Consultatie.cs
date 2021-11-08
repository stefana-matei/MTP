using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema6
{
    public partial class Consultatie : Form
    {
        string cnp;
        public Consultatie(string cnp)
        {
            InitializeComponent();
            this.cnp = cnp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            txtCNPPacient.Text = cnp;
        }
    }
}
