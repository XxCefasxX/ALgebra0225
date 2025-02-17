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
    public partial class Gauss : Form
    {
        public Gauss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num11 = Convert.ToInt32(tb_11.Text);
            int num12 = Convert.ToInt32(tb_12.Text);
            int num13 = Convert.ToInt32(tb_13.Text);
            int num14 = Convert.ToInt32(tb_14.Text);

            int num21 = Convert.ToInt32(tb_21.Text);
            int num22 = Convert.ToInt32(tb_22.Text);
            int num23 = Convert.ToInt32(tb_23.Text);
            int num24 = Convert.ToInt32(tb_24.Text);

            int num31 = Convert.ToInt32(tb_31.Text);
            int num32 = Convert.ToInt32(tb_32.Text);
            int num33 = Convert.ToInt32(tb_33.Text);
            int num34 = Convert.ToInt32(tb_34.Text);

            int num41 = Convert.ToInt32(tb_41.Text);
            int num42 = Convert.ToInt32(tb_42.Text);
            int num43 = Convert.ToInt32(tb_43.Text);
            int num44 = Convert.ToInt32(tb_34.Text);


            decimal res11 = 0;
            decimal res12 = 0;
            decimal res13 = 0;
            decimal res14 = 0;
            decimal res21 = 0;
            decimal res22 = 0;
            decimal res23 = 0;
            decimal res24 = 0;
            decimal res31 = 0;
            decimal res32 = 0;
            decimal res33 = 0;
            decimal res34 = 0;
            decimal res41 = 0;
            decimal res42 = 0;
            decimal res43 = 0;
            decimal res44 = 0;



            //resolver columna 1

            //resolver columna 2

            //resolver columna 3









            //Mostrar  resultados
            lb_11.Text = res11.ToString("0.00");
            lb_12.Text = res12.ToString("0.00");
            lb_13.Text = res13.ToString("0.00");
            lb_14.Text = res14.ToString("0.00");

            lb_21.Text = res21.ToString("0.00");
            lb_22.Text = res22.ToString("0.00");
            lb_23.Text = res23.ToString("0.00");
            lb_24.Text = res24.ToString("0.00");

            lb_31.Text = res31.ToString("0.00");
            lb_32.Text = res32.ToString("0.00");
            lb_33.Text = res33.ToString("0.00");
            lb_34.Text = res34.ToString("0.00");

            lb_41.Text = res41.ToString("0.00");
            lb_42.Text = res42.ToString("0.00");
            lb_43.Text = res43.ToString("0.00");
            lb_44.Text = res44.ToString("0.00");




        }
    }
}
