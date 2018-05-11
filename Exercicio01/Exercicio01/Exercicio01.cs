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
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            double numero = 0;

            try
            {
                numero = Convert.ToDouble(txtNumero.Text);

            }
            catch
            {
                MessageBox.Show("Apenas numeros animal");
                txtNumero.Focus();
                return;
            }

            double antecessor = numero - 1;
            double sucessor = numero + 1;
            string resultado = string.Format("Número: {0}\r\nAntecessor: {1}\r\nSucessor: {2}", numero, antecessor, sucessor);
            txtResultado.Text = resultado;

        }

        private void Exercicio01_Load(object sender, EventArgs e)
        {

        }

        
    }
}
