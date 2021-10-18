using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exercitiul7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            incarcareEchipe();
        }


        private void incarcareEchipe()
        {
            flowLayoutPanel1.Controls.Clear();
            cmbEchipe.Items.Clear();

            foreach(string dirPath in Directory.EnumerateDirectories(Application.StartupPath))
            {
                // adaugare nume director, fara cale
                DirectoryInfo dirName = new DirectoryInfo(dirPath);
                cmbEchipe.Items.Add(dirName.Name);
            }
        }


        private void incarcareJucatori(string echipa)
        {
            flowLayoutPanel1.Controls.Clear();
            string path = Application.StartupPath + "\\" + echipa;


            foreach(string fileName in Directory.EnumerateFiles(path, "*.lpf"))
            {
                using(StreamReader streamReader = new StreamReader(fileName))
                {
                    string cnp = Path.GetFileNameWithoutExtension(fileName);
                    string nume = streamReader.ReadLine();
                    Post post = (Post)Enum.Parse(typeof(Post), streamReader.ReadLine());
                    Jucator jucator = new Jucator(nume, cnp, post);


                    Button btn = new Button();
                    btn.Text = jucator.Nume;
                    btn.Width = 200;
                    btn.Tag = jucator;
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }


        private void Btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            Jucator jucator = (Jucator)btn.Tag;
            txtNume.Text = jucator.Nume;
            txtPost.Text = jucator.CurrentPost.ToString();
            txtCNP.Text = jucator.Cnp;
        }


        private void cmbEchipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            incarcareJucatori(cmbEchipe.Text);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime dataNasterii = dateTimePicker1.Value;
            DateTime dataCurenta = DateTime.Now;
            int varsta = dataCurenta.Year - dataNasterii.Year;


            if (dataCurenta.Month > dataNasterii.Month || (dataCurenta.Month == dataNasterii.Month && dataCurenta.Day > dataNasterii.Day))
            {
                txtVarsta.Text = varsta.ToString();
            }
            else
            {
                varsta--;
                txtVarsta.Text = varsta.ToString();
            }
        }

        private void btnEchipaNoua_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btnJucatorNou_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
