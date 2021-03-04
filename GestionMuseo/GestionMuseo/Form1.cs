using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionMuseo
{
    public partial class Form1 : Form
    {
        Obras misObras = new Obras();
        Mantenimiento misMantenimientos = new Mantenimiento();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnREGISTRAR_Click(object sender, EventArgs e)
        {
            misObras.Obra_arte = txtobra_arte.Text;
            misObras.Titulo = txttitulo.Text;
            misObras.Año = Convert.ToInt16(txtaño.Text);
            misObras.Autor = txtautor.Text;
            misObras.Tipo = txttipo.Text;
            misMantenimientos.Persona = txtpersona.Text;
            misMantenimientos.Tarea_realizada = txttarea.Text;
            misMantenimientos.Fecha_inicio = txtfecha.Text;
            misMantenimientos.Hora =Convert.ToDecimal (txthora.Text);
            misMantenimientos.Duracion = txtduracion.Text;
            MessageBox.Show("Se Guardo correctamente!!!!");
            txtobra_arte.Focus();
        }

        private void btnNUEVO_Click(object sender, EventArgs e)
        {
            txtobra_arte.Clear();
            txttitulo.Clear();
            txtaño.Clear();
            txtautor.Clear();
            txttipo.Clear();
            txtpersona.Clear();
            txttarea.Clear();
            txtfecha.Clear();
            txthora.Clear();
            txtduracion.Clear();
            txtobra_arte.Focus();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
