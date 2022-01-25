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
using ClassLibrary; 

namespace FuvarGOUI
{
    public partial class Form1 : Form
    {
        List<Fuvar> taxik = new List<Fuvar>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void btnBetolt_Click(object sender, EventArgs e)
        {
            foreach (var s in File.ReadAllLines("fuvar.csv").Skip(1))
            {
                taxik.Add(new Fuvar(s));
            }

            listBox.Items.Clear(); //ne jelenjen meg kétszer
            foreach (var f in taxik) //taxik = fent
            {
                listBox.Items.Add(f);
            }
            listBox.DisplayMember = "id"; //mit akarunk?s
        }

        private void btnRendez_Click(object sender, EventArgs e)
        {
            
                taxik = taxik.OrderBy(x => x.id).ToList();
                listBox.DataSource = taxik;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
