using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaUdemy
{
    public class Cuenta
    {
        private string titular{get;set;}
        private double cantidad { get; set; }

        ///////metodos get y set////////////////
        public string getTitular()
        {
            return titular;

        }
        public void setTitular(string titular)
        {
            this.titular = titular;

        }

        public double getCantidad()
        {
            return cantidad;

        }
        public void setCantidad(double cantidad)
        {
            if (cantidad >= 0) this.cantidad = cantidad;
            else this.cantidad = 0;

        }
        ////////////Metodos Ingresar y Retirar/////////////

        public void Ingresar(double cantidad)
        {
            if (cantidad >= 0) this.cantidad = this.cantidad + cantidad;
            else this.cantidad = this.cantidad + 0;

        }


        public void Retirar(double cantidad)
        {
            if (this.cantidad - cantidad < 0) this.cantidad = 0;
            else this.cantidad = this.cantidad - cantidad;

        }






    }

}
