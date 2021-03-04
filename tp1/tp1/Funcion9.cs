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
    public partial class Funcion9 : Form
    {
        public Funcion9()
        {
            InitializeComponent();
        }

        private void Funcion9_Load(object sender, EventArgs e)
        {

        }


        public double jornal(double horas, string turno, string tipo_dia)
        {
            const float HORA_DIURNA = 10;
            const float HORA_NOCTURNA = 13.5f;
            double total;

            if (turno == "diurno")
            {
                total = HORA_DIURNA * horas;
                if (tipo_dia == "festivo")
                {
                    double porcentaje = 10 * total / 100;
                    total = total + porcentaje;
                }
            }
            else
            {
                total = HORA_NOCTURNA * horas;
                if (tipo_dia == "festivo")
                {
                    double porcentaje = 15 * total / 100;
                    total = total + porcentaje;
                }
            }

            return total;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Nombre
            string nombre = textBox1.Text;

            //Horas trabajadas
            double horas = Convert.ToDouble(textBox3.Text);
            //Turno
            string turno = (string)comboBox1.SelectedItem;
            if (turno == "Diurno")
            {
                turno = "diurno";
            }
            else if (turno == null)
            {
                MessageBox.Show("Seleccion un turno");
            }
            else
            {
                turno = "nocturno";
            }
            //Dia
            string dia = textBox4.Text;
            string mes = textBox5.Text;
            string anio = textBox6.Text;
            string tipo_dia = "no festivo";
            //DIAS FESTIVOS
            //Año nuevo, Carnaval, Dia Malvinas, Dia Trabajador, Revolucion de mayo, Inmortalidad Belgrano,Independencia, Navidad.
            string[] fechas_festivas = new string[] { "11", "43", "24", "15", "255", "206", "97", "2512" };

            for (int i = 0; i < fechas_festivas.Length; i++)
            {
                if ((dia + mes) == fechas_festivas[i])
                {
                    tipo_dia = "festivo";
                }
            }

            string total = Convert.ToString(jornal(horas, turno, tipo_dia));


            textBox2.Text = ("Nombre Trabajador: " + nombre + "\r\nTotal a Cobrar: " + total);


        }
    }
}
