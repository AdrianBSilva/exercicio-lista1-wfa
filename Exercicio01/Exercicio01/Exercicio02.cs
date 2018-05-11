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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }
        double totalLitros = 0;
        double valorTotal = 0;
        private void btnGerar_Click(object sender, EventArgs e)
        {
            double litros = 0;
            
            int anos = 0;
            try
            {
                litros = Convert.ToDouble(txtLitros.Text);
                if(litros < 0)
                {
                    MessageBox.Show("Quantidade de litros deveria ser apenas numeros positivos");
                }
            }
            catch
            {
                MessageBox.Show("Na Quantidade de litros deveria apresentar apenas numeros");
            }

            try
            {
                anos = Convert.ToInt32(txtAnos.Text);
                if (litros < 0)
                {
                    MessageBox.Show("Quantiadae de anos deveria conter apenas numeros positivos");
                }
            }
            catch
            {
                MessageBox.Show("Quantidade de anos deveria apresentar apenas numeros");
            }
            
                
           
              double valor = Convert.ToDouble(mtbValor.Text);

            totalLitros = litros * (anos * 365);
            valorTotal = valor * totalLitros;
            string resultado = string.Format("Quantidae de litros consumidos: {0}\r\nValor total pago: {1}", totalLitros, valorTotal);
            txtResultado.Text = resultado;
        }

       
       
    }
}
