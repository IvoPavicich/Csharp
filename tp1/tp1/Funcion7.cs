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
    public partial class Funcion7 : Form
    {
        public Funcion7()
        {
            InitializeComponent();
        }

        public string eqBinario(int numero)
        {
            String resultado = " ";
            if (numero > 0 && numero < 16)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        resultado = "0" + resultado;
                    }
                    else
                    {
                        resultado = "1" + resultado;
                    }
                    numero = (int)(numero / 2);
                }

                if (resultado.Length < 5)
                {
                    //Longitud 5 por los 0000 y el espacio al final
                    int ceros = 5 - resultado.Length;
                    for (int i = 0; i < ceros; i++)
                    {
                        resultado = "0" + resultado;
                    }
                }

            }
            else if (numero == 0)
            {
                resultado = "0000";
            }
            else
            {
                resultado = "ERROR: numero ingresado invalido";
            }


            return resultado;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int numero_ingresado = (int)numericUpDown1.Value;

            textBox1.Text = eqBinario(numero_ingresado);
        }
    }
}
