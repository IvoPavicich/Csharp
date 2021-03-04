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
    public partial class Ejercicio25 : Form
    {
        public Ejercicio25()
        {
            InitializeComponent();
        }

        int general = 0;
        int contamayor = 0;
        int contamenor = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(textBox1.Text);
           
            if (general < 10)
            {
                if (valor > 80)
                {
                    contamayor++;
                }
                else if (valor < 80)
                {
                    contamenor = contamenor + 1; //conta++= conta= conta+1= conta+=1 todos son iguales
                }
                else
                {
                    MessageBox.Show("NO SE ACEPTAN VALORES IGUALES A 80");
                }
            }

            else
            {
                MessageBox.Show("Ya ingreso los 10 números");
            }
            general++;
            //ahora debemos ir limpiando la caja
            textBox1.Text = "";
            textBox2.Text = contamayor.ToString();
            textBox3.Text = contamenor.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void Ejercicio25_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
