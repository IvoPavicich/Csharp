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
    public partial class Funcion8 : Form
    {
        public Funcion8()
        {
            InitializeComponent();
        }


        public double ConversionMoneda(double monto, String tipo)
        {
            double pesos;

            if (tipo == "dolar")
            {
                pesos = monto / 0.75;
            }
            else if (tipo == "libra")
            {
                pesos = monto / 1.22;
            }
            else if (tipo == "yen")
            {
                pesos = monto / 0.009;
            }
            else
            {
                pesos = monto / 2.25;
            }

            return pesos;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(textBox1.Text);
            double resultado = 00;

            if (comboBox1.SelectedItem != null)
            {

                if (comboBox1.SelectedItem == "Dolar")
                {
                    resultado = ConversionMoneda(monto, "dolar");
                }
                else if (comboBox1.SelectedItem == "Libra")
                {
                    resultado = ConversionMoneda(monto, "libra");
                }
                else if (comboBox1.SelectedItem == "Yen")
                {
                    resultado = ConversionMoneda(monto, "yen");
                }
                else if (comboBox1.SelectedItem == "Euro")
                {
                    resultado = ConversionMoneda(monto, "euro");
                }
            }
            else
            {

                MessageBox.Show("Seleccione un tipo de moneda");

            }

            textBox2.Text = Convert.ToString(resultado);
        }
    }
}

