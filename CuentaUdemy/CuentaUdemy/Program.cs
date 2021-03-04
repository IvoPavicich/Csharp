 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta nueva = new Cuenta();
            nueva.setTitular("Ivo");
            nueva.setCantidad(5000);

            nueva.Ingresar(100);
            nueva.Retirar(200);

            Console.WriteLine($"Datos de la cuenta de {nueva.getTitular()} su dinero es {nueva.getCantidad()}");

            Console.ReadKey();
        }   
    }
}
