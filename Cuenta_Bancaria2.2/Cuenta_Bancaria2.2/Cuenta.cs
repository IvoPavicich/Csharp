using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria2._2
{
    public abstract class Cuenta
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

        public abstract void ingresar(double importei);

        public abstract void retirar(double importer);

        public abstract void actualizarSaldo(double importei, double importer);

        public virtual string ToString()
        {
            return "Nro de cuenta: " + _nro_cuenta +
                " - Cliente: " + cliente +
                " - Saldo: $" + saldo;
        }

    }
}
