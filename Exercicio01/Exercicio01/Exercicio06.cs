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
    public partial class Exercicio06 : Form
    {
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToInt32(txtNota1.Text);
            double nota2 = Convert.ToInt32(txtNota2.Text);
            double nota3 = Convert.ToInt32(txtNota3.Text);
            double nota4 = Convert.ToInt32(txtNota4.Text);

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            MessageBox.Show("Média: " + media);
        }


    }
}
