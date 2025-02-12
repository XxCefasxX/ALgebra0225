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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void CalcSuma(object sender, EventArgs e)
        {
            int num1 =Convert.ToInt32( tb_num1.Text);
            int num2 = Convert.ToInt32(tb_num2.Text);

            int suma = num1 + num2;

            lb_result.Text = suma.ToString();
        }

        private void CalcResta(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(tb_num1.Text);
            int num2 = Convert.ToInt32(tb_num2.Text);

            int resta = num1 - num2;

            lb_result.Text = resta.ToString();
        }

        private void CalcMulti(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(tb_num1.Text);
            int num2 = Convert.ToInt32(tb_num2.Text);

            int multi = num1 * num2;

            lb_result.Text = multi.ToString();
        }


        private void CalcDiv(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToInt32(tb_num1.Text);
            decimal num2 = Convert.ToInt32(tb_num2.Text);

            decimal div = num1 / num2;

            lb_result.Text = div.ToString();
        }
    }
}
