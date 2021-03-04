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
    public partial class Ejercicio21 : Form
    {
        public Ejercicio21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int i, j;
            int resto, conta_divisor;
            bool bandera = false;
            for (i = 2; i <= 100; i++)
            {
                conta_divisor = 0;
                j = 2;
                while (conta_divisor < 2 && j <= i && bandera == false)
                {
                    resto = i % j;
                    if (resto == 0)
                        conta_divisor++;
                    else
                    {
                        if (conta_divisor == 1 && j == 1)
                            bandera = true;
                    }
                    j++;
                }
                if (conta_divisor == 1)

                    textBox1.Text = textBox1.Text + i + ";"+"\r";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
