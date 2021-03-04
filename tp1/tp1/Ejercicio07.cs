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
    public partial class Ejercicio07 : Form
    {
        public Ejercicio07()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            float numero = float.Parse(textBox1.Text);
            if ((numero %2) == 0)
            
                textBox1.Text = "Par";
            
            else
            
                textBox1.Text = "IMPAR";

            Limpiar.Focus();
        }

        private void Ejercicio07_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
