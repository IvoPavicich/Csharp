using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CuentaAhorro ca1 = new CuentaAhorro(1, 2000, "Juan Perez", 1.2F, 300);
            Corriente cc1 = new Corriente(2, 3500, "Pedro Perez", -2000);

            //Console.WriteLine(ca1.ToString());
            //ca1.ingresar(3000);
            //Console.WriteLine(ca1.ToString());
            //ca1.retirar(1000);
            //ca1.cambiarInteres(1.1F);
            //Console.WriteLine(ca1.ToString());

            Console.WriteLine(cc1.ToString());
            cc1.ingresar(3000);
            Console.WriteLine(cc1.ToString());
            cc1.retirar(4000);
            cc1.actualizarSaldo(3000, 4000);
            Console.WriteLine(cc1.ToString());

            Console.ReadKey();


        }
    }
}
