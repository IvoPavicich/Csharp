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
    public partial class Ejercicio03 : Form
    {
        public Ejercicio03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            mayor = 0;
            menor = 0;
            cantidad = 0;
            textBox1.Enabled = true;
            textBox1.Focus();
            button2.BackColor = Color.Gray;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            

            int n = int.Parse(textBox1.Text);

            if (cantidad < 10)
            {
                if (n > 0)
                {
                    mayor++;
                }
                else if (n < 0)
                {
                    menor++;
                }
                else
                {
                    MessageBox.Show("Error,Ingrese un número distinto de 0");
                }
            }
            else if (cantidad == 10)
            {
                textBox1.Enabled = false;
                button2.BackColor = Color.Red;

                MessageBox.Show("Se Ingresaron los 10 números");
                

            }

            cantidad++;
            //se limpian las cajas de texto
            textBox1.Clear();
            textBox2.Text = mayor.ToString();
            textBox3.Text = menor.ToString();
            textBox1.Focus();
        }

        private void Ejercicio03_Load(object sender, EventArgs e)
        {
           // textBox1.Enabled = false;
        }
        int cantidad = 0;
        int mayor = 0;
        int menor = 0;
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    

    }

