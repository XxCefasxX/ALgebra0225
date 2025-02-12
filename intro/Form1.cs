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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HolaMundo(object sender, EventArgs e)
        {
            string msg=tb_name.Text;


            lb_msg.Text ="Hola "+ msg;
        }
    }
}
