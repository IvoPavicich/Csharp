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
    public partial class Ejercicio08 : Form
    {
        public Ejercicio08()
        {
            InitializeComponent();
        }

        private void SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void COVERTIR_Click(object sender, EventArgs e)
        {
            Double valor = Convert.ToDouble(numericUpDown1.Value);
            Double pie= (valor*0.0328084);
            Double pulgada= (valor * 0.393701);
            textBox1.Text = pie.ToString();
            textBox2.Text = pulgada.ToString();


        }
    }
           
}
