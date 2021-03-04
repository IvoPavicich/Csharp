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
    public partial class Ejercicio31 : Form
    {
        public Ejercicio31()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cajalegajo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cajasueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cajalegajo.Clear();cajasueldo.Clear();comboBox1.Text = null;
        }
        int hombres = 0;
        int mujeres = 0;
        int cantidad = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            cajalegajo.Focus();
            if (cajalegajo.Text != "" && cajasueldo.Text != "" && comboBox1.Text != "")
            {

                if (cantidad < 10)
                {
                    switch (comboBox1.Text)
                    {
                        case "Masculino":
                            {
                                if (Convert.ToDecimal(cajasueldo.Text) < 400)
                                {
                                    hombres += 1;
                                }
                            }
                            break;
                        case "Femenino":
                            {

                                if (Convert.ToDecimal(cajasueldo.Text) > 500)
                                {
                                    mujeres++;
                                }
                            }
                            break;
                    }
                    cajalegajo.Text = "";
                    cajasueldo.Text = "";
                    comboBox1.SelectedItem = null;
                    salidahombres.Text = hombres.ToString();
                    salidamujeres.Text = mujeres.ToString();
                    cantidad++;
                }
            }
        }

        private void Ejercicio31_Load(object sender, EventArgs e)
        {
            button1.Focus();
        }
    }
}
