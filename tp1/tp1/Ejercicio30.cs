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
    public partial class Ejercicio30 : Form
    {
        public Ejercicio30()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            caja1.Clear(); caja2.Clear(); cajasalida.Clear();
            caja1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (caja1.Text != "" && caja2.Text != "")
            {
                int num1, num2 = 0;
                int cantidad = 0;
                int pares = 0;
                num1 = (int)Convert.ToSingle(caja1.Text);
                num2 = (int)Convert.ToSingle(caja2.Text);
                if (num1 > num2)
                {
                    for (int i = num2; i <= 1; i++)
                    {
                        cajasalida.Text += i + "\r\n";
                        if (i % 2 == 0)
                        {
                            pares++;
                        }
                        cantidad++;
                    }
                }
                else if (num2 > num1)
                {
                    for (int i = num1; i <= num2; i++)
                    {
                        cajasalida.Text += i + "\r\n";
                        if (i % 2 == 0)
                        {
                            pares++;
                        }
                        cantidad++;
                    }
                }
                salidacantidad.Text = "CANTIDAD: " + cantidad;
                salidapares.Text = "PARES: " + pares;

            }
        }
    }
}
