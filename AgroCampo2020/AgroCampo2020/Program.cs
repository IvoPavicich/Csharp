using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCampo2020
{
    class Program
    {
        static double margen, gastos, ingresos;////////variables globales
        static void Main(string[] args)
        {
            int lotes, nlote = 0;
            double superficie, toneladas, precio, gastosh, gastoss, gastosi, gastosl;
            double totalIngresos = 0, totalGastos = 0, margenTotal = 0;
            string cultivo;

            Console.WriteLine("Lotes Sembrados: ");
            lotes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*********************\n");
            for (int i = 0; i < lotes; i++)
            {
                nlote = nlote + 1;
                Console.WriteLine($"Lote Numero {nlote}\n");
                Console.WriteLine("Tipo de cultivo {Maiz / Soja} : ");
                cultivo = Console.ReadLine();
                Console.WriteLine("Superficie sembrada : ");
                superficie = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Gasto total de herbicida:");
                gastosh = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Gasto total de semillas :");
                gastoss = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Gasto total de insecticida :");
                gastosi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Gasto total de servicio de laboreo  :");
                gastosl = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("************************************************\n");
                Console.WriteLine("Toneladas cosechadas por hectarea : ");
                toneladas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Precio de Venta : ");
                precio = Convert.ToDouble(Console.ReadLine());




                Gastos(gastosh, gastoss, gastosi, gastosl);
                Ingresos(superficie, toneladas, precio);
                MargenBruto(ingresos, gastos);

                totalIngresos = totalIngresos + ingresos;
                totalGastos = totalGastos + gastos;
                margenTotal = margenTotal + margen;

                Console.WriteLine(MostrarDatos(cultivo, superficie));

            }

           
            Console.WriteLine($" Gastos totales {totalGastos} " +
                $"              Ingresos totales {totalIngresos}" +
                $"              Margen Bruto Total {margenTotal}");
            Console.ReadKey();
        }

        //////////////////////////////Subprograma////////////////////////////////////////////////////////////////////////////////////////////////
        static double MargenBruto(double ingresos, double gastos)
        {
            margen = (ingresos - gastos);
            return margen;
        }

        static double Gastos(double gastosh, double gastoss, double gastosi, double gastosl)
        {
            gastos = gastosh + gastoss + gastosi + gastosl;
            return gastos;
        }

        static double Ingresos(double superficie, double toneladas, double precio)
        {
            ingresos = (superficie * toneladas * precio);
            return ingresos;
        }


        static String MostrarDatos(string cultivo, double superficie)
        {
            return "Tipo de cultivo :\n" + cultivo + "\nSuperficie sembrada:\n" + superficie + "\nGastos por lote:\n" + gastos + "\nIngreso:\n" + ingresos + "\nMargen Bruto:\n" + margen;
        }



    }











}
 
    
 
