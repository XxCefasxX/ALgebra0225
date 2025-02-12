using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox1.Text.Trim() == "")
            {
                label1.Text = "Ingrese algun valor";
            }
            else 
            {
                label1.Text = "ha ingresado un valor";
            }
        }
    }
}
