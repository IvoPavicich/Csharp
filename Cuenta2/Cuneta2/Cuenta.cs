using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta2

{
    public class Cuenta
    {
        public int ncuenta{get;set;}
        public double saldo { get; set; }
        public string cliente { get; set; }
        public double importe { get; set; }
        public Cuenta(int ncuenta,string cliente,double saldo,double importe)
        {
            this.ncuenta = ncuenta;
            this.cliente = cliente;
            this.saldo = saldo;
        }
        public virtual double Ingresar(double importe)
        {

            return saldo+importe;
        }
        public virtual double Retirar(double importe)
        {
            return saldo - importe;
        }


        public virtual double actualizarSaldo()
        {
            return saldo;
        }


        public virtual string MostrarDatos()
        {
            return "Numero de cuenta" + ncuenta + "Nombre de Cliente" + cliente;
        }
    }
}
