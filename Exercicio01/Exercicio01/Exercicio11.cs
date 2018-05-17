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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = mtbData.Text;
            string[] numero = data.Split('/');

            int dia = Convert.ToInt32(numero[0]);
            int mes = Convert.ToInt32(numero[1]);
            int ano = Convert.ToInt32(numero[2]);
            int idade = 2018 - ano;
            int diasVivos = idade * 365;
            int mesesVivos = idade * 12;
            int horasVivos = diasVivos * 25;
            int minutosVivos = horasVivos * 60;
            int segundosVivos = minutosVivos * 60;

            string status = string.Format("Qunaditade de Anos vivo: {0:n}\r\nQunaditade de Meses vivo: {1:n}\r\nQunaditade de Dias vivo: {2:n}\r\nQunaditade de Horas vivo: {3:n}\r\nQunaditade de Minutos vivo: {4:n}\r\nQunaditade de Segundos vivo: {5:n}",
                idade, mesesVivos, diasVivos, horasVivos, minutosVivos, segundosVivos);

            txtStatus.Text = status;
           

           

            

        }
    }
}
