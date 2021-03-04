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
    public partial class Ejercicio10 : Form
    {
        public Ejercicio10()
        {
            InitializeComponent();
        }

       

        private void acepta_Click(object sender, EventArgs e)
        {
            string frase = textBox1.Text.ToUpper(); //ToUpper convierte lo ingresado a mayuscula y ToLower es todo a minuscula
            int longitud = frase.Length; //length me de vueelve la longitud de esa cadena de caracteres

            int contador = 0;

            for (int i = 0; i < longitud; i++) //arranca en 0, es menor que longitud y despues se aumenta, el arreglo siempre arranca en 0
            {
                if (((frase[i]) == 'A') || ((frase[i]) == 'E')
                  || ((frase[i]) == 'I') || ((frase[i]) == 'O')
                  || ((frase[i]) == 'U'))
                    contador++;
            }
            textBox2.Text = contador.ToString();
            
        }

        private void limpia_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}
    
