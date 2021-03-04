using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTA_SIN_HERENCIA
{
    public class Corriente : Cuentas
    {
        
        private double interes;
        private double limite;
        public double saldoAc;
        
        public Corriente(string titular, int ncuenta) : base(titular, ncuenta)
        {
            limite = 100;
            interes = 0.015;
        }
        public double Intereses { get => interes; set => interes = value; }
        public double Monto_limite { get => limite; set => limite = value; }
       

        public override void Ingresar(double monto1)
        {
            Saldo = saldoAc;
            Saldo += monto1;
            Console.WriteLine($"Movimiento/s en la cuenta => Se Depositaron ${monto1} a la cuenta");
        }
        public void Limite(double nuevo_limite)
        {
            limite = nuevo_limite;
            Console.WriteLine($"*El limite se a modificado a -${limite}\n");
        }

        public override void Retirar(double monto2)
        {
           
            Saldo = saldoAc;
            if (((Saldo - monto2) > (-1*limite)))
            {
                Saldo -= monto2;

                Console.WriteLine($"Movimiento/s en la cuenta => Se Retiraron ${monto2} ");
            }
            else
            {Console.WriteLine("Ha excedido el Monto limite de  $-"+ limite+"!!!!");}

        }

        public override void Actualizar()
        {



            if (Saldo > saldoAc)
            {
                saldoAc = Saldo + ((Saldo * interes));
            }
            else if (Saldo < saldoAc)
            {
                saldoAc = Saldo - (-1*(Saldo * interes));
            }
            
 

        }

        public override string ToString() => base.ToString() + 
            "Interes fijo (1.5%) del saldo actual " + Intereses * 100 + "\n" +
            "Saldo Actualizado =>" + saldoAc + "\n" +
            "Monto limite de giro hasta => -"+ limite + "\n" +
            "\n################################################################\n";



    }
}
