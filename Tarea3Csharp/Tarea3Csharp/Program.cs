using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea3Csharp
{
    class Program
    {


        
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar 5 numeros :  ");
            int numero,suma=0;

            for (int i=0;i<5;i++)
            {
                Console.WriteLine($" Numero {i+1} = ");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                
            }

            Console.WriteLine($"La suma de los 5 numeros es : {suma}");
            Console.ReadKey();

        }

    }
}


//int n = 19;
//while (n <= 37)
//{
//    Console.WriteLine(n);
//    n += 2;
//}


//decimal num;
//int num2;
//do
//{


//    Console.WriteLine("Ingrese un numero");
//    num = decimal.Parse(Console.ReadLine());
//    Console.WriteLine($"Su mitad es {num/2}");
//    num2 = int.Parse(Console.ReadLine());


//}
//while (num2 >=  0 );
//1.Imprimir los números del 19 al 37 , de 2 en 2 . Usar la estructura While

//2.Imprimir la mitad de un numero, hasta que se ingrese un numero negativo.Usar el Do While

//3.Hallar la suma de 5 números (Usando la estructura For)