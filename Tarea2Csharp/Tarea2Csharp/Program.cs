using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingrese un Numero : ");
            //int numero = int.Parse(Console.ReadLine());
            //if(( numero % 5).Equals(0))
            //    Console.WriteLine("Es multiplo de 5");
            //else
            //    Console.WriteLine("NO es multiplo de 5 !!");
            //Console.ReadKey();

            //Console.WriteLine("La cantidad de horas trabajadas : ");
            //int horas = int.Parse(Console.ReadLine());
            //int sueldo;
            //if (horas < 30)
            //{
            //    sueldo = horas * 10;
            //}
            //else
            //{
            //    sueldo = horas * 20;
            //}

            //Console.WriteLine($"El empleado gana :  {sueldo}");



            //Console.ReadKey();

            Console.WriteLine("Ingrese un numero :");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero :");
            decimal num2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Que operacion desea realizar");
            string operacion = Console.ReadLine();
            decimal resultado;
            switch (operacion)
            {
                case "+": resultado = num1 + num2; break;
                case "-": resultado = num1 - num2; break;
                case "*": resultado = num1 * num2; break;
                case "/": resultado = num1 / num2; break;
                default: resultado = 0;break;
            }
            decimal op = resultado;
            Console.WriteLine($"Resultado {resultado}");
            Console.ReadKey();

        }
    }
}
