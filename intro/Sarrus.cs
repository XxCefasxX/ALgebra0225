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
    //este mensaje es de prueba
    public partial class Sarrus : Form
    {
        public Sarrus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num11 = Convert.ToInt32(tb_11.Text);
            int num12 = Convert.ToInt32(tb_12.Text);
            int num13 = Convert.ToInt32(tb_13.Text);

            int num21 = Convert.ToInt32(tb_21.Text);
            int num22 = Convert.ToInt32(tb_22.Text);
            int num23 = Convert.ToInt32(tb_23.Text);

            int num31 = Convert.ToInt32(tb_31.Text);
            int num32 = Convert.ToInt32(tb_32.Text);
            int num33 = Convert.ToInt32(tb_33.Text);

            int i1 = Convert.ToInt32(tb_i1.Text);
            int i2 = Convert.ToInt32(tb_i2.Text);
            int i3 = Convert.ToInt32(tb_i3.Text);


            //diagonales superiores
            int d1 = CalcDiagonal(num11, num22, num33);
            int d2 = CalcDiagonal(num21, num32, num13);
            int d3 = CalcDiagonal(num31, num12, num23);
            //sumatoria diagonales superiores
            int ds = CalcSumatoria(d1, d2, d3);


            //diagonales inferiores
            int d4 = CalcDiagonal(num13 , num22, num31);
            int d5 = CalcDiagonal(num23 , num32 , num11);
            int d6 = CalcDiagonal(num33 , num12 , num21);
            //sumatoia diagonales inferiores
            int di = CalcSumatoria(d4, d5, d6);

            //determinante general
            int det = ds - di;

            //calcular X
            d1 = CalcDiagonal(i1, num22, num33);
            d2 = CalcDiagonal(i2, num32, num13);
            d3 = CalcDiagonal(i3, num12, num23);
            ds = CalcSumatoria(d1, d2, d3);

            d4 = CalcDiagonal(num13, num22, i3);
            d2 = CalcDiagonal(num23, num32, i1);
            d2 = CalcDiagonal(num33, num12, i2);
            //sumatoia diagonales inferiores
            di = CalcSumatoria(d4, d5, d6);

            //calcular determinante de x
            int detx = ds - di;
            //calcular X dividiendo la detrminante de x entre la determinante general
            decimal x = detx / det;

            //aqui agregar valor de y y z
            lb_x.Text = x.ToString();
            lb_det.Text = det.ToString();
        }
        //calcula diagonal
        private int CalcDiagonal(int num1, int num2, int num3)
        {
            int diagonal = num1 * num2 * num3;
            return diagonal;
        }

        //calcula la sumatoria de diagonales
        private int CalcSumatoria(int diagonal1, int diagonal2, int diagonal3)
        {
            int sumatoria = diagonal1 + diagonal2 + diagonal3;
            return sumatoria;
        }

    }
}
