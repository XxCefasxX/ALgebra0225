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
    public partial class Laplace : Form
    {
        public Laplace()
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

            int det1 = 0;
            int det2 = 0;
            int det3 = 0;
            int det4 = 0;


            //diagonales superiores
            int d1 = CalcDiagonal(num22, num33, num44);
            int d2 = CalcDiagonal(num32, num43, num24);
            int d3 = CalcDiagonal(num23, num34, num42);
            int ds = CalcSumatoria(d1, d2, d3);
            //diagonales inferiores
            int d4 = CalcDiagonal(num24, num33, num42);
            int d5 = CalcDiagonal(num23, num32, num44);
            int d6 = CalcDiagonal(num34, num43, num22);
            //sumatoia diagonales inferiores
            int di = CalcSumatoria(d4, d5, d6);
            det1 = ds - di;


            //diagonales superiores
            d1 = CalcDiagonal(num21, num33, num44);
            d1 = CalcDiagonal(num31, num43, num24);
            d1 = CalcDiagonal(num23, num34, num41);
            d1 = CalcSumatoria(d1, d2, d3);
            //diagonales inferiores
            d1 = CalcDiagonal(num24, num33, num41);
            d1 = CalcDiagonal(num23, num31, num44);
            d1 = CalcDiagonal(num34, num43, num21);
            //sumatoia diagonales inferiores
            d1 = CalcSumatoria(d4, d5, d6);
            det2 = ds - di;


            //diagonales superiores
            d1 = CalcDiagonal(num21, num32, num44);
            d1 = CalcDiagonal(num31, num42, num24);
            d1 = CalcDiagonal(num22, num34, num41);
            d1 = CalcSumatoria(d1, d2, d3);
            //diagonales inferiores
            d1 = CalcDiagonal(num24, num32, num41);
            d1 = CalcDiagonal(num22, num31, num44);
            d1 = CalcDiagonal(num34, num42, num21);
            //sumatoia diagonales inferiores
            d1 = CalcSumatoria(d4, d5, d6);
            det3 = ds - di;


            //diagonales superiores
            d1 = CalcDiagonal(num21, num32, num43);
            d1 = CalcDiagonal(num31, num42, num23);
            d1 = CalcDiagonal(num22, num33, num41);
            d1 = CalcSumatoria(d1, d2, d3);
            //diagonales inferiores
            d1 = CalcDiagonal(num23, num32, num41);
            d1 = CalcDiagonal(num22, num31, num43);
            d1 = CalcDiagonal(num33, num42, num21);
            //sumatoia diagonales inferiores
            d1 = CalcSumatoria(d4, d5, d6);
            det4 = ds - di;



            int det = (num11 * (det1 * 1)) +
                (num12 * (det2 * -1)) + 
                (num13 * (det3 * 1)) +
                (num14 * (det4 * -1));
        }

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
