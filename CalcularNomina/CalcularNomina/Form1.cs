using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularNomina
{
    public partial class Form1 : Form
    {   //se instancian las clases Empelado y Nomina
        Empleado miEmpleado = new Empleado();
        Nomina miNomina = new Nomina();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {//validacion de campos
            if (txtNombre.Text=="")
            {
                error.SetError(txtNombre, "Debe ingresar nombre");
                txtNombre.Focus();
                return;
            }
            error.SetError(txtNombre, "");
            decimal AsigancionDia;
            if (!Decimal.TryParse(txtAsignacionDia.Text, out AsigancionDia))
            {
                error.SetError(txtAsignacionDia, "Debe ingresar un numero");
                txtAsignacionDia.Focus();
                return;
            }
            error.SetError(txtAsignacionDia, "");


            miEmpleado.Nombre = txtNombre.Text;
            miEmpleado.Identificacion = txtIdentificacion.Text;
            miEmpleado.AsignacionDia = Convert .ToDecimal (txtAsignacionDia.Text);
            miNomina.DiasTrabajados = Convert.ToInt32(txtDiasTrabajados.Text);
            MessageBox.Show("Se Guardo correctamente!!!!");
            txtSueldoTotal.Focus();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            txtSueldoTotal.Text = miNomina.CalcularNomina(Convert.ToInt32(miNomina.DiasTrabajados),Convert.ToDecimal (miEmpleado.AsignacionDia)).ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtAsignacionDia.Clear();
            txtDiasTrabajados.Clear();
            txtSueldoTotal.Clear();
            txtNombre.Focus();
        }
    }
}
