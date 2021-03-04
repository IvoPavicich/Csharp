using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1
{
    public partial class Ejercicio13 : Form
    {
        public Ejercicio13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) //resto = 0 , entonces el nro sería par
                {
                    contador++;
                    textBox2.Text += i.ToString() + "," + "\r"; //r retorno de carro, n salto de linea
                }
            }
            textBox1.Text = contador.ToString();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

