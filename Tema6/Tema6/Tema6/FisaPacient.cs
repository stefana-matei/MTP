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
    public partial class FisaPacient : Form
    {
        string cnp;
        public FisaPacient(string cnp)
        {
            InitializeComponent();
            this.cnp = cnp;
        }
    }
}
