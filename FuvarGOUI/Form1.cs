using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuvarGOUI
{
    public partial class Form1 : Form
    {
        public int lajos = 0;
        public string valami = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            if (lajos == 1)
            {
                Close();
            }
            else if (lajos == 0)
            {
                valami = "Az igen";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = valami;
        }
    }
}
