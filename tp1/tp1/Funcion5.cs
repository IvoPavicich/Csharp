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
    public partial class Funcion5 : Form
    {
        public Funcion5()
        {
            InitializeComponent();
        }
        public int Factorial(int numero)//FUNCION QUE CALCULA EL FACOTRIAL
        {
            int resultado = 1;

            for (int i = 0; i < numero; i++)
            {

                resultado = resultado * (numero - i);

            }
            if (numero == 0)
            {
                return 0;
            }
            else
            {
                return resultado;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = (int)numericUpDown1.Value;
            int numero2 = (int)numericUpDown2.Value;

            textBox1.Text = Factorial(numero1).ToString();
            textBox2.Text = Factorial(numero2).ToString();
        }
    }
}
