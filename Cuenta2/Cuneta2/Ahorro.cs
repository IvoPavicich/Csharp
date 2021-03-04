using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta2
{
    class Ahorro:Cuenta
    {
        public double saldoa;
        public double importe;
        public Ahorro(int ncuenta, string cliente, double saldo ,double saldoa,double importe) : base(ncuenta, cliente,saldo,importe)
        {
            this.importe = importe;
            saldoa = saldoa + Ingresar(importe);
        }

        public override double Ingresar(double importe)
        {


            return saldoa + importe;
        }

        public override double Retirar(double importe)
        {
            return saldoa - importe;
        }

        public override string MostrarDatos()
        {
            return "Numero de cuenta" + ncuenta + "Nombre de Cliente" + cliente + "El saldo es: " + saldoa;
        }

    }




}

