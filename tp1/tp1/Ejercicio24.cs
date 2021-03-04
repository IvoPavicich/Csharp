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
    public partial class Ejercicio24 : Form
    {
        public Ejercicio24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
        }

        

        private void Ejercicio24_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int cuadrado = 0;
            int cubo = 0;

            int num = int.Parse(textBox1.Text);

            //cuadrado

            cuadrado = num * num;
            textBox2.Text = cuadrado.ToString();

            //cubo
            cubo = num * num * num;

            textBox3.Text = cubo.ToString();
        }
    }
}
