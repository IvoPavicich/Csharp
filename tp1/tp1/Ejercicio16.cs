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
    public partial class Ejercicio16 : Form
    {
        public Ejercicio16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (int i = 0; i <= 100; i++)
            {

                if (i % 3==0)
                {
                    contador--;
                    textBox2.Text += i.ToString() + "," + "\r"; //r retorno de carro, n salto de linea
                }
            }
        }

        private void Ejercicio16_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
