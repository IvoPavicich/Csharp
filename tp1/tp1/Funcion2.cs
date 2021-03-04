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
    public partial class Funcion2 : Form
    {
        public Funcion2()
        {
            InitializeComponent();
        }


        // Funcion para calcular el valor de el numero ingresado elevado a la potencia dada
        public static decimal calcular_exponente(double num, double exp)
        {
            return (Convert.ToDecimal(Math.Pow(num, exp)));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            decimal resultado = calcular_exponente(x, y);
            textBox3.Text = Convert.ToString(resultado);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
