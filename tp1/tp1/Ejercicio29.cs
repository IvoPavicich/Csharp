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
    public partial class Ejercicio29 : Form
    {
        public Ejercicio29()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int valor = int.Parse(textBox1.Text);
                if (valor >= 0 && valor <= 10)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        textBox2.Text += valor.ToString() + "x" + i + "=" + (valor * i) + "\r\n";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void Ejercicio29_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
