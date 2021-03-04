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
    public partial class Funcion3 : Form
    {
        public Funcion3()
        {
            InitializeComponent();
        }
        //FUNCION QUE CALCULA LOS TERMINOS DE LA SERIE
        private static int fibonacci(int termino)
        {
            //Creacion de una variable entera para el resultado y un arreglo para que almacene la serie
            int resultado = 0;
            int[] serie = new int[termino];
            // Si el termino es igual a 1
            if (termino == 1)
            {
                return (resultado = 1);
            }

            else
            {
                //Ciclo para calcular la serie
                for (int i = 0; i < termino; i++)
                {
                    if (i == 1)
                    {
                        resultado = 1;
                    }
                    else if (i == 0)
                    {
                        resultado = 1;
                    }
                    else
                    {
                        resultado = ((serie[i - 1]) + (serie[i - 2]));
                    }
                    //Se almacene en el arreglo la serie en su termino correspondiente
                    serie[i] = resultado;
                }
                return (resultado);
            }

        }




        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(numericUpDown1.Value);

            if (x > 0)
            {
                textBox1.Text = Convert.ToString(fibonacci(x));
            }
            else
            {
                MessageBox.Show("ERROR ingrese numero entero positivo");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
