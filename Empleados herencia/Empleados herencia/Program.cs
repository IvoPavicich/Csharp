using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Comercial oComercial = new Comercial();
            oComercial.nombre = "Ivo";
            oComercial.edad = 31;
            oComercial.salario = 25000;
            oComercial.comision = 1000;
            oComercial.Plus();
            Console.WriteLine($"El salario es :  {oComercial.salario}");

            Repartidor oRepartidor = new Repartidor();
            oRepartidor.nombre = "Roberto";
            oRepartidor.edad = 31;
            oRepartidor.salario = 25000;
            oRepartidor.zona = "zona 3";
            oRepartidor.Plus();
            Console.WriteLine($"El salario es :  {oRepartidor.salario}");





            Console.ReadKey();



        }
    }
}
