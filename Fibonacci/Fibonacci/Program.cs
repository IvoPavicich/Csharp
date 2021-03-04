using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        

        static int Fibonacci(int termino)
        {
            int n1, n2, suma, count;
            n1 = 0;
            n2 = 1;
            suma = 1;
            count = 1;
            for (count = 1;count < termino;count++)
            {
                suma = n1 + n2;
                n1 = n2;
                n2 = suma;


            }


            return suma;
        }




        static void Main(string[] args)
        {
            int termino , resultado;

            termino = Convert.ToInt32(Console.ReadLine());
            resultado = Fibonacci(termino);
            Console.WriteLine("El termino N° " +  termino  +"de la"+ "sucesion de Fibonacci es :" + resultado);
            Console.ReadKey();
        }
    }
}
