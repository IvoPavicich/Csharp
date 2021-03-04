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
    public partial class Ejercicio05 : Form
    {
        public Ejercicio05()
        {
            InitializeComponent();
        }

        private void Ejercicio05_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //al hacer click en el boton se limpian todas las cajas de texto  
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();// el cursor queda en la primer caja de texto
            //se deshabilitan las cajas de texto
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();//cierra el formulario actual
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaracion de las variables
            
            float Base = float.Parse(textBox1.Text);
            float Altura = float.Parse(textBox2.Text);
            //se realiza el calculo de la sueperficie
            if (Base < 0 || Altura < 0)
            { MessageBox.Show("NO SE PERMITEN VALORES NEGATIVOS"); }
            else
            {
                float Superficie = (Base * Altura) / 2;
                textBox3.Text = Superficie.ToString();

                textBox3.Enabled = true;
            }


        }



        

       

        private void Ejercicio05_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();//al abrirse el formulario el cursor se encuentra en la 1er caja de texto
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textBox2.Enabled = true;
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                button1.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
