using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace tp1
{
    public partial class Ejercicio32 : Form
    {
        public Ejercicio32()
        {
            InitializeComponent();
        }

        private void Ejercicio32_Load(object sender, EventArgs e)
        {

        }
        ArrayList listaAgua = new ArrayList();
        ArrayList listaFecha = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            if (entradagua.Text != "")
            {
                listaAgua.Add(entradagua.Text);
                listaFecha.Add(entradafecha.Value);
                int indiceMenor = 0;
                int indiceMayor = 0;
                decimal menor = -1;
                decimal mayor = -1;

                decimal acum = 0;
                decimal promedio = 0;
                for (int i = 0; i < listaAgua.Count; i++)
                {
                    if (menor == -1)
                    {
                        menor = (Convert.ToDecimal(((String)listaAgua[i])));
                    }
                    if (mayor == -1)
                    {
                        mayor = (Convert.ToDecimal(((String)listaAgua[i])));
                    }
                    if (Convert.ToDecimal(((String)listaAgua[i])) > mayor)
                    {
                        mayor = Convert.ToDecimal(((String)listaAgua[i]));
                        indiceMayor = i;
                    }
                    if (Convert.ToDecimal(((String)listaAgua[i])) < menor)
                    {
                        menor = Convert.ToDecimal(((String)listaAgua[i]));
                        indiceMenor = i;
                    }
                    acum += Convert.ToDecimal(((String)listaAgua[i]));
                }

                promedio = acum / listaAgua.Count;
                lluviamayor.Text = ((DateTime)listaFecha[indiceMayor]).ToString();
                lluviamenor.Text = ((DateTime)listaFecha[indiceMenor]).ToString();
                salidapromedio.Text = promedio.ToString();
                entradagua.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaAgua.Clear();
            listaFecha.Clear();
            entradagua.Text = "";
            salidapromedio.Text = "";
            lluviamayor.Text = "";
            lluviamenor.Text = "";
            entradagua.Focus();
        }
    }
}
