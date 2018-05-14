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
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        int numero1 = 0;
        int numero2 = 0;
        double soma = 0;
        double subtracao = 0;
        double multipicacao = 0;
        double divisao = 0;
        double produto1 = 0;
        double produto2 = 0;

        public void Informacoes()
        {

            
            try
            {
                numero1 = Convert.ToInt32(txtNumero1.Text);

            }
            catch
            {
                MessageBox.Show("1°número deve conter apenas números seu animal");
                txtNumero1.Focus();
                return;
            }

            try
            {
                numero2 = Convert.ToInt32(txtNumero2.Text);

            }
            catch
            {
                MessageBox.Show("2°número deve conter apenas números seu animal");
                txtNumero2.Focus();
                return;
            }

            soma = numero1 + numero2;
            subtracao = numero1 - numero2;
            divisao = numero1 / numero2;
            multipicacao = numero1 * numero2;
            produto1 = numero1 * numero1;
            produto2 = numero2 * numero2;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Informacoes();
            if (rbSomar.Checked)
            {
                MessageBox.Show("A soma é: " + soma);
            }
            else if (rbSubtrair.Checked)
            {
                MessageBox.Show("A subtração é: " + subtracao);
            }
            else if (rbDividir.Checked)
            {
                MessageBox.Show("A divisão é: " + divisao);
            }
            else if (rbMultiplicar.Checked)
            {
                MessageBox.Show("A multiplicação é: " + multipicacao);
            }
            else if (rbProdutos.Checked)
            {
                MessageBox.Show("O produto do 1°número é: " + produto1 + "\r\nO produto do 2°número é: " + produto2);
            }
        }



    }
}
