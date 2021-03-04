using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cc1 = new Cuenta(2, 1000, "Pedro Perez");
            Console.WriteLine(cc1.ToString());
            
           




            Console.ReadKey();
        }
    }
}
