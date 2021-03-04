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
    public partial class Funcion6 : Form
    {
        public Funcion6()
        {
            InitializeComponent();
        }
        public bool esPrimo(int numero)
        {
            int i = 0;
            int div = 0;
            bool resultado = false;

            for (i = 1; i < (numero + 1); i++)
            {
                if (numero % i == 0)
                {
                    div++;
                }
            }
            if (div == 2)
            {
                resultado = true;
            }
            return resultado;
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            String resultado = "Primos: ";
            int numero = (int)numericUpDown1.Value;
            for (int i = 0; i < numero; i++)
            {
                if (esPrimo(numero - i))
                {
                    resultado = resultado + "[" + (numero - i).ToString() + "]";
                }


            }

            textBox1.Text = resultado;
        }
    }
}
