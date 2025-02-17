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
            decimal num11 = Convert.ToInt32(tb_11.Text);
            decimal num12 = Convert.ToInt32(tb_12.Text);
            decimal num13 = Convert.ToInt32(tb_13.Text);
            decimal num14 = Convert.ToInt32(tb_14.Text);

            decimal num21 = Convert.ToInt32(tb_21.Text);
            decimal num22 = Convert.ToInt32(tb_22.Text);
            decimal num23 = Convert.ToInt32(tb_23.Text);
            decimal num24 = Convert.ToInt32(tb_24.Text);

            decimal num31 = Convert.ToInt32(tb_31.Text);
            decimal num32 = Convert.ToInt32(tb_32.Text);
            decimal num33 = Convert.ToInt32(tb_33.Text);
            decimal num34 = Convert.ToInt32(tb_34.Text);

            decimal num41 = Convert.ToInt32(tb_41.Text);
            decimal num42 = Convert.ToInt32(tb_42.Text);
            decimal num43 = Convert.ToInt32(tb_43.Text);
            decimal num44 = Convert.ToInt32(tb_34.Text);


            decimal res11 = num11;
            decimal res12 = num12;
            decimal res13 = num13;
            decimal res14 = num14;
            decimal res21 = num21;
            decimal res22 = num22;
            decimal res23 = num23;
            decimal res24 = num24;
            decimal res31 = num31;
            decimal res32 = num32;
            decimal res33 = num33;
            decimal res34 = num34;
            decimal res41 = num41;
            decimal res42 = num42;
            decimal res43 = num43;
            decimal res44 = num44;




            //resolver fila 2
            if (res21 > 0 || res21 < 0)
            {
                res21 = Calc(num21, num11, num11, num21);
                res22 = Calc(num21, num11, num12, num22);
                res23 = Calc(num21, num11, num13, num23);
                res24 = Calc(num21, num11, num14, num24);
            }

            //resolver fila 3
            if (res31 > 0 || res31 < 0)
            {
                res31 = Calc(num31, num11, num11, num31);
                res32 = Calc(num31, num11, num12, num32);
                res33 = Calc(num31, num11, num13, num33);
                res34 = Calc(num31, num11, num14, num34);
            }

            //resolver fila 4
            if (res41 > 0 || res41 < 0)
            {
                res41 = Calc(num41, num11, num11, num41);
                res42 = Calc(num41, num11, num12, num42);
                res43 = Calc(num41, num11, num13, num43);
                res44 = Calc(num41, num11, num14, num44);
            }


            //resolver fila 3 columna 2
            if (res32 > 0 || res32 < 0)
            {
                res31 = Calc(res32, res22, res21, res31);
                res32 = Calc(res32, res22, res22, res32);
                res33 = Calc(res32, res22, res23, res33);
                res34 = Calc(res32, res22, res24, res34);
            }

            //resolver fila 4 columna 2
            if (res42 > 0 || res42 < 0)
            {
                res41 = Calc(res42, res22, res21, res41);
                res42 = Calc(res42, res22, res22, res42);
                res43 = Calc(res42, res22, res23, res43);
                res44 = Calc(res42, res22, res24, res44);
            }





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

        /// <summary>
        /// FUncion que convierte en 0 el valor
        /// </summary>
        /// <param name="fr1">numeor de fila 1</param>
        /// <param name="fr2">numero de fila 2</param>
        /// <param name="num1">numero de fila 1</param>
        /// <param name="num2">numero a convertir en 0</param>
        /// <returns></returns>
        private decimal Calc(decimal fr1, decimal fr2, decimal num1, decimal num2)
        {
            decimal result = 0;

            //(F1*(F2 / F1)) - F2
            //1- fila 2 entre fila 1
            decimal multiplo1 = fr2 / fr1;
            //2- multiplo por fila1
            decimal aux = num1 * multiplo1;
            //3- aux menos fila2
            result = aux - num2;


            return result;
        }
    }
}
