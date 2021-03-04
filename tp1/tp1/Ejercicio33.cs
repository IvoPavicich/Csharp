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
    public partial class Ejercicio33 : Form
    {
        public Ejercicio33()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                numeros[i] = 0;
            }
        }
        int cantidad = 0;
        decimal[] numeros = new decimal[5];

        decimal menor = -1;
        decimal mayor = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (cantidad < 5)
                {
                    numeros[cantidad] = Convert.ToDecimal(textBox1.Text);
                    if (menor == -1)
                    {
                        menor = Convert.ToDecimal(textBox1.Text);
                    }
                    if (mayor == -1)
                    {
                        mayor = Convert.ToDecimal(textBox1.Text);
                    }
                    for (int i = 0; i <= cantidad; i++)
                    {
                        if (numeros[i] < menor)
                        {
                            menor = numeros[i];
                        }
                        if (numeros[i] > mayor)
                        {
                            mayor = numeros[i];
                        }
                    }
                    cantidad++;
                    textBox1.Text = "";
                    SALIDAMAYOR.Text = mayor.ToString();
                    SALIDAMENOR.Text = menor.ToString();

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cantidad = 0;
            decimal[] numeros = new decimal[5];
            menor = -1;
            mayor = -1;
            textBox1.Text = "";
            SALIDAMENOR.Text = "";
            SALIDAMAYOR.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ejercicio33_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
