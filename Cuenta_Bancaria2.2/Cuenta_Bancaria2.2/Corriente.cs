using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria2._2
{
    public class Corriente : Cuenta
    {
        private double _interes = 1.5;
        private double _monto_limite;
        public double saldoAc;
        public Corriente(int nro_cuenta, double saldo, string cliente, double monto_limite)
            : base(nro_cuenta, saldo, cliente)
        {
            this._monto_limite = monto_limite;
            this.saldo = saldo;
        }

        public double interes { get => _interes; set => _interes = value; }
        public double monto_limite { get => _monto_limite; set => _monto_limite = value; }

        public override void ingresar(double importei)
        {
            saldo += importei;

        }

        public override void retirar(double importer)
        {
            double limite = saldo - importer;
            if (limite >= monto_limite)
            {
                saldo -= importer;

            }
            else
            {
                Console.WriteLine("No se puede retirar porque queda por debajo del monto acordado que es de $" + monto_limite);
            }
        }
        public override void actualizarSaldo(double importei, double importer)
        {
            //double saldoAc;
            double intereses;
            intereses = (saldo*interes) / 100;
            saldoAc = (saldo + (importei - importer)-intereses);



        }



        public override string ToString() => base.ToString() + " - Interes: " + interes + "%." + "El saldo actualizado: " + saldo;
    }
}
