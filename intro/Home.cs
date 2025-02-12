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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sarrus sarrus = new Sarrus();
            sarrus.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Laplace laplace = new Laplace();
            laplace.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 calculaorra=new Form2();
            calculaorra.Show();
        }
    }
}
