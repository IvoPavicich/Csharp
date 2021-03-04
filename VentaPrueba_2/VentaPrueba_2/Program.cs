using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaPrueba_2
{
    class Program
    {////////////////////////Programa-Principal//////////////////////////////////////////
        static double[] ganancias = new double[4];/*variable global*/
        static double[] gventas = new double[4];
        static double[] gcompras = new double[4];
        
        static void Main(string[] args)
        {

            double[] vventas = new double[4];
            double[] ventas = new double[4];
            double[] vcompras = new double[4];
            double[] compras = new double[4];


            Valores(vventas, vcompras);
            Console.WriteLine("\n***********\n");
            Montos(ventas, compras);
            Vender(vventas, ventas);
            Comprar(vcompras, compras);
            Ganancias(gventas, gcompras);
            Console.Clear();
            Console.WriteLine("1-Monto diarios\n" +
                   "2-Ganancia por dia\n" +
                   "3-Ganancia semanas\n" +
                   "4-Ganancia en el mes\n" +
                   "5-Imprimir Ganancias\n" +
                   " Presione 0 para salir!!!\n");
            var op = Console.ReadLine();
            while (Convert.ToInt32(op) != 0)
            {
                switch (Convert.ToInt32(op))

                {
                    case 1:
                        Monto_Dia(compras,ventas);
                        break;

                   
                    case 2:
                        Dia();
                        break;
                    case 3:
                        Por_Semana();
                        break;
                    //case 4:
                    //    Semanas(ganancias);
                    //    break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\nLa ganancia obtenida en el mes es de: $" + Mes(ganancias) + ".-");
                        break;
                    
                    case 5:
                        Console.WriteLine("GANANCIAS");
                        Console.WriteLine("Por dia:\n");
                        Ganancias(gventas, gcompras);
                        Console.WriteLine("\n################\n");
                        Console.WriteLine("\nLa ganancia por semana : ");
                        Semanas(ganancias);
                        Console.WriteLine("\n################\n");
                        Console.WriteLine("\nLa ganancia del mes es de: $" + Mes(ganancias) + ".");
                        break;
                }

                Console.WriteLine("\n");
                Console.WriteLine("************************************************************");
                Console.WriteLine("1-Monto diarios\n" +
                    "2-Ganancia por dia\n" +
                    "3-Ganancia semanas\n" +
                    "4-Ganancia en el mes\n" +
                    "5-Imprimir Ganancias\n" +
                    " Presione 0 para salir!!!\n");
                op = Console.ReadLine();


            }





            Console.ReadKey();
        }

        ////////////////////////////////////////////Sub-Programa//////////////////////////////////////////

        static void Valores(double[] vventas, double[] vcompras)
        {
            Console.WriteLine("Ingrese el Valor para la venta :");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"dia  {i + 1}");
                double valor_v = Convert.ToDouble(Console.ReadLine());
                vventas[i] = valor_v;


            }

            Console.WriteLine("Ingrese el Valor para la compra :");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"dia  {i + 1}");
                double valor_c = Convert.ToDouble(Console.ReadLine());
                vcompras[i] = valor_c;
            }

        }
        static void Montos(double[] ventas, double[] compras)
        {
            Console.WriteLine("Ingrese el Monto a vender");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"dia  {i + 1}");
                double monto_v = Convert.ToDouble(Console.ReadLine());
                ventas[i] = monto_v;
            }

            Console.WriteLine("Ingrese el Monto a comprar");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"dia  {i + 1}");
                double monto_c = Convert.ToDouble(Console.ReadLine());
                compras[i] = monto_c;
            }



        }
        static void Vender(double[] ventas, double[] vventas)
        {
            for (int i = 0; i < 4; i++)
            {
                gventas[i] = ventas[i] * vventas[i];

            }

        }
       
        static void Comprar(double[] compras, double[] vcompras)
        {
            for (int i = 0; i < 4; i++)
            {
                gcompras[i] = compras[i] * vcompras[i];

            }

        }
        static void Ganancias(double[] gventas, double[] gcompras)
        {

            for (int i = 0; i < 4; i++)
            {

                ganancias[i] = gventas[i] - gcompras[i];
                //mes =mes+ ganancias[i];
                Console.WriteLine($"Dia {i + 1} ganancia {ganancias[i]}");

            }


        }

        static void Monto_Dia(double[] compras, double[] ventas)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Monto comprado  el dia  {i + 1}==>{compras[i]}");


            }
            Console.WriteLine("\n************************************\n");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Monto vendido  el dia  {i + 1}==>{ventas[i]}");


            }


        }


        static void Dia()
        {
            int dia;
            do
            {
                Console.Write("\nIngrese el dia para saber la ganancia obtenida: ");
                if (int.TryParse(Console.ReadLine(), out dia))
                {
                    if (dia < 1 || dia > 4)
                    {
                        Console.WriteLine("\nError. Ingrese un dia valido (1 al 28).");
                    }
                    else
                    {
                        break; //Sale del bucle solo si es un numero y esta entre 1 y 20
                    }
                }
            } while (true);
            Console.WriteLine($"\nLa ganancia obtenida en el dia  { dia} es: $ { ganancias[dia - 1]}");
        }

        static void Semanas(double[] ganancias)
        {

            int j = -1;
            double[] semanas = new double[2];
            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    j++;

                }
                semanas[j] += ganancias[i];


            }
            for (j = 0; j < 2; j++) { Console.WriteLine($"Semana {j + 1} ganancia {semanas[j]}"); }
        }




        static void Por_Semana()
        {
            int semana;
            int j = -1;
            double[] semanas = new double[2];
            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                {
                    j++;

                }
                semanas[j] += ganancias[i];


            }

            do
            {
                Console.Write("\nIngrese la semana para saber la ganancia obtenida: ");
                if (int.TryParse(Console.ReadLine(), out semana))
                {
                    if (semana < 1 || semana > 2)
                    {
                        Console.WriteLine("\nError. Ingrese una semana valida (1 al 28).");
                    }
                    else
                    {
                        break; //Sale del bucle solo si es un numero y esta entre 1 y 20
                    }
                }
            } while (true);
            Console.WriteLine($"\nLa ganancia en semana  { semana} es: $ { semanas[semana - 1]}");
        }




 //////////////////////////FUNCION que devuelve la ganancia en el mes////////////////////////////////////

        static double Mes(double[] ganancias)
        {

            double ganancia = 0;
            foreach (double venta in ganancias)
            {
                ganancia += venta;
            }
            return ganancia;


        }
    }
}

