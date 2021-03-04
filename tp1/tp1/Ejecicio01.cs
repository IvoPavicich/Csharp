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
    public partial class Ejercicio01 : Form
    {
        public Ejercicio01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal v1, v2, v3, v4, v5;
            decimal promedio;
            v1 = numericUpDown1.Value;
            v2= numericUpDown2.Value;
            v3 =numericUpDown3.Value;
            v4 = numericUpDown4.Value;
            v5 = numericUpDown5.Value;

            promedio = (v1 + v2 + v3 + v4 + v5) / 5;

            numericUpDown6 .Value = promedio;
        }
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
