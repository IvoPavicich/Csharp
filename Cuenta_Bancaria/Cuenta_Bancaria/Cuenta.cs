using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria
{
    public class Cuenta
    {
        private double _saldo;
        private string _cliente;

        public Cuenta(int nro_cuenta, double saldo, string cliente)
        {
            this._nro_cuenta = nro_cuenta;
            this._cliente = cliente;
        }

        protected int _nro_cuenta { get; set; }
        protected virtual double saldo { get => _saldo; set => _saldo = value; }
        protected string cliente { get => _cliente; set => _cliente = value; }

        //public virtual double cantidad { get => this._cantidad; set =>this. _cantidad = value; }

        //public virtual void ingresar(double importe)
        //{
        //    cantidad = cantidadi;
        //    cantidadi += importe;
            
            
        //}

        //public virtual void retirar(double importe)
        //{
        //    cantidadr -= importe;
           
            
        //}

        //public virtual void actualizarSaldo()
        //{


        //    cantidad = cantidadi + cantidadr;

            
        //}

        public override String ToString()
        {
            return "Nro de cuenta: " + _nro_cuenta+ " - Saldo: $" + saldo +" - Cliente: " + cliente ;
        }


    }
}
