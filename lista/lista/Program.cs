using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();
            int numero=0;
            for (int i=0;i<2;i++)
            {
                numero = Convert.ToInt32(Console.ReadLine());
                lista1.Add(numero);
                
            }
            Console.ReadKey();
        }
    }
}
