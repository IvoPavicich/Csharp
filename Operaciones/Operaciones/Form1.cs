using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Frmoperaciones : Form
    {
        public Frmoperaciones()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalular_Click(object sender, EventArgs e)//procedimiento
        {
            //declaracon de variables locales
            double num1, num2;
            double suma, resta, div, mul, potencia, raiz;

            num1 = double.Parse(txtnumero1.Text);//instruccion "Parse" toma los datos ingresados en la caja de texto(ambas sirven)
            num2 = Convert.ToDouble(txtnumero2.Text);//"      Convert.ToDouble toma datos de cajas de texto(ambas sirevn)     
            //procesos
            suma = num1 + num2;
            resta = num1 - num2;
            div = num1 / num2;
            mul= num1 * num2;
            potencia = Math.Pow(num1, num2);//Math.Pow es una libreria matematica recibe (base,exponente)
            raiz = Math.Pow(num1, (1 / num2));
            
            //mostar calculos
            txtsuma.Text = Convert.ToString(suma);
            txtresta.Text = Convert.ToString(resta);
            txtmultiplicacion.Text = Convert.ToString(mul);
            txtdivision.Text = Convert.ToString(div);
            txtpotencia.Text = Convert.ToString(potencia);
            txtraiz.Text = Convert.ToString(raiz);
        }

        private void txtraiz_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtsuma.Clear();
            txtresta.Clear();
            txtmultiplicacion.Clear();
            txtdivision.Clear();
            txtpotencia.Clear();
            txtraiz.Clear();
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtsuma.Focus();

        }

       
    }
}
