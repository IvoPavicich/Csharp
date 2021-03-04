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
    public partial class Ejercicio15 : Form
    {
        public Ejercicio15()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (int i = 100; i >= 0; i--)
            {


                contador--;
                textBox2.Text += i.ToString() + "," + "\r"; //r retorno de carro, n salto de linea

            }
            
        }
    }
}
