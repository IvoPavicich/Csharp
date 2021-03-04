using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTA_SIN_HERENCIA
{
    public abstract class Cuentas
    {
        private string titular;
        private double saldo;
        private int ncuenta;
        

        protected Cuentas(string titular, int ncuenta)
        {
            this.titular = titular;
            this.ncuenta = ncuenta;

        }




        public double Saldo /*{ get => cantidad; set => cantidad = value; }*/
        {
            get { return saldo; }
            set { saldo = value; }

        }

        public string Titular 
        {
            get { return titular; }
            set { titular = value; }

        }
       public int Ncuenta { get => ncuenta; set => ncuenta = value; }


        public abstract void Ingresar(double monto1);

        public abstract void Retirar(double monto2);

        public abstract void Actualizar();
        

        public override string ToString()
        {
            return "Titluar: "+ titular + "\n" + "Saldo: " + saldo + "\n" + "N° de cuenta: " + ncuenta + "\n" ;
        }


    }
}
