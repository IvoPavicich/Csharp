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
    public partial class Funcion4 : Form
    {
        public Funcion4()
        {
            InitializeComponent();
        }
        private static double area(double radio)
        {
            double pi = 3.14;
            radio = Math.Pow(radio, 2);
            return (pi * radio);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(area(radio));
        }
    }
}
