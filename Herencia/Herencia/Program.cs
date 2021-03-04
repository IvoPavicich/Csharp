using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesdeVentas Cliente;/////instanciacion de un nuevo cliente
            Cliente = new clsClientesdeVentas();
            Cliente.IdCliente = 123;
            Cliente.Apellidos ="PEREZ" ;
            Cliente.Nombres = "JUAN";
            Cliente.RFC = "RHMM";
            Cliente.Direccion = "TUCUMAN 360";
            Cliente.Provincia = "CHACO";
            Cliente.Municipio= "QUITILIPI";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellidos+" "+Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Provincia+" "+Cliente.Municipio);
            Console.WriteLine(Cliente.RFC );

            if (Cliente.EsCredito == true)

                Console.WriteLine("el cliente tiene credito");
            else

                Console.WriteLine("el cliente NO tiene credito");



            Console.ReadKey();





        }
    }
}
