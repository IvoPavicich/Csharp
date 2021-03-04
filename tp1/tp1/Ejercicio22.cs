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
    public partial class Ejercicio22 : Form
    {
        public Ejercicio22()
        {
            InitializeComponent();
        }
      
        int general = 0;
        int total_pos = 0, total_neg = 1;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//se ingresa un numero y se hace click para que realice los calculos//se repite hasta que la cantidad de numeros ingresados sea 10
        {
            int valor = int.Parse(textBox1.Text);

            if (general < 10)
            {
                if (valor > 0)
                {
                    total_pos = total_pos + valor;
                }
                else
                {
                    if (valor < 0)
                    {
                        total_neg = total_neg * valor;
                    }
                }


            }

            else
                MessageBox.Show("Ya ingreso los 10 numeros");
            general++;
            textBox1.Text = "";
            textBox2.Text = total_pos.ToString();
            textBox3.Text = total_neg.ToString();
            textBox1.Focus();

        }
    }
}
