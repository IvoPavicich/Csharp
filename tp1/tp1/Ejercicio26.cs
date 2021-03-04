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
    public partial class Ejercicio26 : Form
    {
        public Ejercicio26()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                float lado1 = float.Parse(textBox1.Text);
                float lado2 = float.Parse(textBox2.Text);
                float lado3 = float.Parse(textBox3.Text);
                float mayor = 0, sumar = 0;
                int i, j, auxi = 0, flag = 0;

                float[] lado = { lado1, lado2, lado3 }; //matriz unidemensional
                for (i = 0; i < 3; i++)
                    if (lado[i] > mayor)
                    {
                        mayor = lado[i];
                        auxi = i;
                    }
                for (i = 0; i < 3; i++)
                    if (auxi != i)
                    {
                        sumar += lado[i];
                    }


                if (mayor < sumar)
                {
                    MessageBox.Show("Es un triangulo");

                    for (i = 0; i < 2; i++)
                        for (j = i + 1; j < 3; j++)
                            if (lado[i] == lado[j])
                                flag++;
                    if (flag == 3)
                        MessageBox.Show(" Triángulo Equilatero");
                    else
                    {
                        flag = 0;
                        for (i = 0; i < 2; i++)
                            for (j = i + 1; j < 3; j++)
                                if (lado[i] != lado[j])
                                    flag++;
                        if (flag == 3)
                            MessageBox.Show(" Triángulo Escaleno");
                        else
                            MessageBox.Show(" Triángulo Isosceles");
                    }
                }
                else
                {
                    MessageBox.Show("No es un triangulo");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            textBox1.Focus();
        }

        private void Ejercicio26_Load(object sender, EventArgs e)
        {

        }

        private void enter(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
