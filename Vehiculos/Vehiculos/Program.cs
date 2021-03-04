using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            var misVehiculos = new List<Vehiculo>
            {
                new Vehiculo("Fiat","Palio","flm237"),
                new VehiculoFamiliar(5,"Fiat","Duna Wknd","abc098"),
                new VehiculoCarrera(121.72,"Ford","Falcon","aa00a4"),
            };

            foreach (var miVehiculo in misVehiculos)
            {
                Console.WriteLine(miVehiculo.mostrarDatos());

            }

            Console.ReadKey();
        }
    }
}
