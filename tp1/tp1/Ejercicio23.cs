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
    public partial class Ejercicio23 : Form
    {
        public Ejercicio23()
        {
            InitializeComponent();
        }
        int aux1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            aux1 = num1;
            num1 = num2;
            num2 = aux1;

            textBox3.Text = num1.ToString();
            textBox4.Text = aux1.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ejercicio23_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
