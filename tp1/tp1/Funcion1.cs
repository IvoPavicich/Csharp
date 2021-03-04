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
    public partial class Funcion1 : Form
    {
        public Funcion1()
        {
            InitializeComponent();
        }

        //definimos el subprograma tipo funcion
        //public(tipo del resultado) (nombre funcion) (parametros)


        public double calculo_area(double ba, double alt)
        {
            double area = (ba * alt) / 2;
            return area; //valor que devuelve resultado
        }
        //para un procedimiento es lo mismo pero en (tipo de resultado) va void
        // y no se escribe el comando return

        //para sobrecargar una funcion, definir sus parametros con un tipo de diferente
        //al original, esto generará que el programa eligira como actuar en base a los tipos de parametros ingresados





        private void button1_Click(object sender, EventArgs e)
        {
            double bas = Convert.ToDouble(textBox1.Text);
            double altura = Convert.ToDouble(textBox2.Text);
            textBox3.Text = "El área del triángulo es: " + (calculo_area(bas, altura)).ToString();
        }
    }
}
