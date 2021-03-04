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
    public partial class Ejercicio06 : Form
    {
        public Ejercicio06()
        {
            InitializeComponent();
            
        }
    
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            textIngrese_numero.Clear();
            
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(textIngrese_numero.Text);
            //calculo para saber si el numero ingresado en la caja de texto es positivo o negativo
            if (valor1 > 0)
            {
                textIngrese_numero.Text = "EL NUMERO INGRESADO ES POSITIVO";
                
            }

            else if (valor1 < 0)
            {
                textIngrese_numero.Text = "EL NUMERO INGRESADO ES NEGATIVO";
                
            }
            else
            {
                textIngrese_numero.Text = "INGRESE UN NUEVO NUMERO DISTINTOS DE 0";
                textIngrese_numero.Focus();
            }

            
        }
        
        private void Ejercicio06_Load(object sender, EventArgs e)
        {
            textIngrese_numero.Focus();
        }

       
    }
}
