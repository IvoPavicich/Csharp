using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta2
{
    class Corriente:Cuenta
    {
        public double saldoc;
        public double importe;
        public Corriente(int ncuenta, string cliente,double saldo ,double saldoc,double importe) :base(ncuenta,cliente,saldo,importe)
        {
            this.importe = importe;
            saldoc = saldoc+Ingresar(importe);
        }

        public override double Ingresar(double importe)
        {


            return saldoc + importe;
        }

        public override double Retirar(double importe)
        {
            return saldoc - importe;
        }

        public override string MostrarDatos()
        {
            return "Numero de cuenta" + ncuenta + "Nombre de Cliente" + cliente+"El saldo es: "+ saldoc;
        }

    }
}
