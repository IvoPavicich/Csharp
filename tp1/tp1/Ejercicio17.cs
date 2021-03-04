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
    public partial class Ejercicio17 : Form
    {
        public Ejercicio17()
        {
            InitializeComponent();
        }

        private void Ejercicio17_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0) //multiplo de 2
                {

                    textBox1.Text += i.ToString() +","+ "\r"; //r retorno de carro, n salto de linea
                }
                if (i % 3 == 0) //multiplo de 3
                {
                    textBox2.Text += i.ToString() +"," +"\r";

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
