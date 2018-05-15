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
    public partial class Exercicio09 : Form
    {
        public Exercicio09()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtN1.Text);
            double n2 = Convert.ToDouble(txtN2.Text);
            double n3 = n1 + n2;
            n1 = n3 - n1;
            n2 = n3 - n2;

            txtTroca1.Text = Convert.ToString(n1);
            txtTroca2.Text = Convert.ToString(n2);

        }

     
    }
}
