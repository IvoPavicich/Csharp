using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONDICIONALES
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor1 = 0, valor2 = 0;
            string cadena;
            Console.WriteLine("primer valor:" );
            cadena = Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);
            Console.WriteLine("segundo  valor:");
            cadena = Console.ReadLine();
            valor2 = Convert.ToInt32(cadena);
            if (valor1 <= valor2)
            
                if (valor1 == valor2)
                   Console.WriteLine("SON IGUALES ");
                else
            
                Console.WriteLine("EL VALOR 2 es  MAYOR que EL VALOR 1 ");
            else
               Console.WriteLine("EL VALOR 1 es  MAYOR que EL VALOR 2 ");
             Console.ReadKey();
        }
    }
}