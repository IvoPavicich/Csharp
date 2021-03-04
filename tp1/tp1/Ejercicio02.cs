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
    public partial class Ejercicio02 : Form
    {
        public Ejercicio02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calcularcuadrado_Click(object sender, EventArgs e)
        {
            decimal numero;
            decimal calcularcuadrado;
            if (numericUpDown1.Value <= 0)

            {
               
                MessageBox.Show("ERROR, VOLVER A INGRESAR OTRO NÚMERO!!!!");
                
            }
            else
            {
                //numericUpDown1.Focus;
                 
                numero = numericUpDown1.Value;
            calcularcuadrado = numero * numero;
            textcuadrado.Text = calcularcuadrado.ToString();
            }

        }

        private void textcuadrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            
            
        }
    }
}
