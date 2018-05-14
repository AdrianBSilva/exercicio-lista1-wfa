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
    public partial class Exercicio05 : Form
    {

        
        public Exercicio05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double valorCarro = Convert.ToDouble(txtValorCarro.Text);
            double quantidade = Convert.ToDouble(txtQuantidade.Text);
            double parcelas = Convert.ToDouble(txtValorParcelas.Text);
            double financiamento = quantidade * parcelas;
            double diferenca = financiamento - valorCarro;

            string resultado = string.Format("Nome do carro: {0}\r\nValor do carro: {1}\r\nQuantidade de meses: {2}\r\nValor das parcelas: {3}\r\nValor do financiamento: {4}\r\nDiferença entre o financiamento e o Valor do carro: {5}",
                nome, valorCarro, quantidade, parcelas, financiamento, diferenca);

            txtResultado.Text = resultado;
        }

      
    }
}
