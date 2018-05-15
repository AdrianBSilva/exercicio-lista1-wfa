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
    public partial class Exercicio08 : Form
    {
        public Exercicio08()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        double valorTelefone = 0;
        double demaisContas = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            double luz = Convert.ToDouble(mtbLuz.Text);
            double agua = Convert.ToDouble(mtbAgua.Text);
            double iptu = Convert.ToDouble(mtbIPTU.Text);
            double ipva = Convert.ToDouble(mtbIPVA.Text);
            double seguro = Convert.ToDouble(mtbSeguro.Text);
            double oi = Convert.ToDouble(mtbOI.Text);
            double vivo = Convert.ToDouble(mtbVivo.Text);
            double net = Convert.ToDouble(mtbNet.Text);
            if(radioButton1.Checked)
            {
                valorTelefone = net;
            }
            else
            {
                demaisContas = net;
            }
            valorTelefone = valorTelefone + oi + vivo;
            double valorDosImpostos = iptu + ipva;
            demaisContas = demaisContas + seguro + luz + agua;
            double valorTotal = valorTelefone + valorDosImpostos + demaisContas;

            string telefone = string.Format("{0:n}", valorTelefone);
            string impostos = string.Format("{0:n}", valorDosImpostos);
            string outras = string.Format("{0:n}", demaisContas);
            string total = string.Format("{0:n}", valorTotal);

            txtImpostos.Text = impostos;
            txtOutras.Text = outras;
            txtTelefone.Text = telefone;
            txtTotal.Text = total;
            
            
            

        }
    }
}
