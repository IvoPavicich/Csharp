using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTA_SIN_HERENCIA
{
    public class Ahorro:Cuentas
    {
        public double saldoAc;
        private double minimo;
        private double intereses=1.2;
        public Ahorro(string titular, int ncuenta): base(titular, ncuenta)

        {
            minimo=300;

        }
        public double Intereses { get => intereses; set => intereses =value; }
        public double Minimo { get => minimo; set => minimo = value; }

        public override void Ingresar(double monto1)
        {
                
                Saldo += monto1;
            Console.WriteLine($"Movimiento/s en la Cuenta  => Se Ingresaron ${monto1} a la cuenta");

        }
        public override void Retirar(double monto2)
        {
            double limite =Saldo - monto2;
            if (Saldo > 0 && (limite) >= minimo)
            {
                Saldo-= monto2;
                Console.WriteLine($"Movimiento/s en la cuenta => Se Retiraron ${monto2} ");
            }
            else
            {
                Console.WriteLine("No se puede extraer dinero, el monto ingresado es mayor al limite de extraccion" );
                Saldo = saldoAc;
            }
        }


        public void cambiarInteres(double interes)
        {
            intereses = interes;
            Console.WriteLine($"Intereses modificados a : {intereses}%");
        }

        public override void Actualizar()
        {
            //intereses = (Cantidad * intereses)/100;
            if (Saldo > saldoAc)
            {
                saldoAc = Saldo + (Saldo * intereses) / 100;
            }
            else if (Saldo < saldoAc)
            {
                saldoAc = Saldo - (Saldo * intereses) / 100;
            }
            
        }

        public override string ToString() => base.ToString() + 
            "Interes " + intereses +"% " + 
            "Saldo Actualizado   " + saldoAc+
            "\n################################################################\n";



    }
}
