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
        List<Fuvar> taxi = new List<Fuvar>();
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

        }
        private void btnBetolt_Click(object sender, EventArgs e)
        {
            foreach (var s in File.ReadAllLines("fuvar.csv").Skip(1))
            {
                taxi.Add(new Fuvar(s));
            }
            //listBox.Items.Add("asd");

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
