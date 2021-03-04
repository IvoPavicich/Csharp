using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta2
{
    class Program
    {

        static void Main(string[] args)
        {
            int ncuenta=0;
            double saldoc=0;
            double saldo = 0;
            string cliente="";
            double importe = 0;
            List<Cuenta> Cuentas = new List<Cuenta>();
            Console.WriteLine("Ingrese el numero de cuenta");
            ncuenta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Nombre y Apellido del cliente");
            cliente = Console.ReadLine();
            Console.WriteLine("Importe");
            importe= Convert.ToDouble(Console.ReadLine());
            Corriente newcorriente = new Corriente(ncuenta,cliente,saldoc,importe);
            Cuentas.Add(newcorriente);
            foreach (var micuenta in Cuentas)
            {
                Console.WriteLine(micuenta.MostrarDatos());
            }
        }
    }
}
