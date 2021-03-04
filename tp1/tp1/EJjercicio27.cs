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
    public partial class Ejercicio27 : Form
    {
        public Ejercicio27()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnro1.Text != "" && txtnro2.Text != "" && txtnro3.Text != "")
            {
                float liminf = float.Parse(txtnro1.Text);
                float limsup = float.Parse(txtnro2.Text);
                float valor = float.Parse(txtnro3.Text);

                if (valor <= limsup && valor >= liminf)
                {
                    label5.Text = "Conclusión: El valor ingresado está dentro del intervalo";

                }
                else
                {
                    label5.Text = "Conclusión: El valor ingresado no está dentro del intervalo";
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnro1.Clear(); txtnro2.Clear(); txtnro3.Clear();
            txtnro1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
