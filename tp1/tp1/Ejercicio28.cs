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
    public partial class Ejercicio28 : Form
    {
        public Ejercicio28()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox3.Clear(); textBox3.Clear(); textBox4.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TicketEjercicio28 ticket = new TicketEjercicio28();


            int horas = int.Parse(textBox1.Text);
            string nombre = textBox2.Text;
            int antig = int.Parse(textBox3.Text);
            int canti = int.Parse(textBox4.Text);


            int bruto = ((horas * canti) + antig) * 30;
            double descuento = bruto * 0.13;
            double neto = bruto - descuento;


            ticket.txbempleado.Text = nombre;
            ticket.txbhora.Text = horas.ToString() + " horas ";
            ticket.txbantig.Text = antig.ToString() + " años ";
            ticket.txbruto.Text = " $ " + bruto.ToString();
            ticket.txbtotal.Text = " $ " + neto.ToString();
            ticket.txbdescuento.Text = " $ " + descuento.ToString();
            ticket.Show();

        }
    }
}
