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
    public partial class Ejercicio14 : Form
    {
        public Ejercicio14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (int i = 0; i <= 100; i++)
            {
                
                
                    contador++;
                    textBox2.Text += i.ToString() + "," + "\r"; //r retorno de carro, n salto de linea
               
            }
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
