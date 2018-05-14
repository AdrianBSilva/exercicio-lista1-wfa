using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 0;
            try
            {
                numero = Convert.ToInt32(txtNumero.Text);

            }
            catch
            {
                MessageBox.Show("O valor digitado nao é um número");
                txtNumero.Focus();
                return;
            }

            int tabuada0 = numero * 0;
            int tabuada1 = numero * 1;
            int tabuada2 = numero * 2;
            int tabuada3 = numero * 3;
            int tabuada4 = numero * 4;
            int tabuada5 = numero * 5;
            int tabuada6 = numero * 6;
            int tabuada7 = numero * 7;
            int tabuada8 = numero * 8;
            int tabuada9 = numero * 9;
            int tabuada10 = numero * 10;


            string tabuada = string.Format(
                                           @"
                                           {0} x0 = {1}
                                           {0} X1 = {2}
                                           {0} X2 = {3}
                                           {0} X3 = {4}
                                           {0} X4 = {5}
                                           {0} X5 = {6}
                                           {0} X6 = {7}
                                           {0} X7 = {8}
                                           {0} X8 = {9}
                                           {0} X9 = {10}
                                           {0} X10 = {11}", numero, tabuada0, tabuada1, tabuada2, tabuada3,
                                                          tabuada4, tabuada5, tabuada6, tabuada7, tabuada8, tabuada9, tabuada10);

            txtTabuada.Text = tabuada;




        }
    }
}
