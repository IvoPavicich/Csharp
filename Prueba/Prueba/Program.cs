using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static double[,] ventas;
        //static double[,] compras;
        static double[,] ganancias;
        //static double[,] monto_compra;
        //static double[,] monto_venta;
        static double[] semanas;
        static int semana;
        static double suma=0;
        static int diag = 0; 
        static int diav = 0;
        static void Cargar_datos()
        {
            ventas = new double[4, 7];
            //compras = new double[2, 2];
            ganancias = new double[4, 7];
            semanas = new double[4];
            //monto_compra = new double[2, 2];
            //monto_venta = new double[2, 2];
            int dia = 0;
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    double venta;
                    double vventa;
                    double cantidadv;
                    dia = dia + 1;
                    Console.WriteLine($"Dia  {dia}");
                    Console.WriteLine("Ingrese valor venta \n");
                    vventa = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cantidad que desea vender \n");
                    if (c < 5)
                    {
                        
                        cantidadv = Convert.ToDouble(Console.ReadLine());
                        venta = vventa * cantidadv;
                        ventas[f, c] = venta;
                    }
                    else
                    {
                        venta = vventa * 0;
                        ventas[f, c] = venta;
                    }
                }
            }
            
            for (int f = 0; f < 4; f++)
            {

                for (int c = 0; c < 7; c++)
                {
                    ganancias[f, c] = ventas[f, c];
                    suma = suma + ganancias[f, c];
                }
            }
            for (int f = 0; f < 4; f++)
            {
                semanas[f] = 0;
                for (int c = 0; c < 7; c++)
                {

                    semanas[f] = semanas[f] + ganancias[f, c];

                }

            }

            Console.WriteLine("GANANCIA POR DIA : \n");
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    diag = diag + 1;
                    Console.Write($"dia {diag} = " + ganancias[f, c] + "  ");

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("******************************************\n");
            for (int f = 0; f < 4; f++)
            {
                semana = f + 1;
                Console.WriteLine($"Ganancia Semana N°{semana} = {semanas[f]}");
                Console.WriteLine("\n");
            }
            Console.WriteLine("******************************************\n");

            Console.WriteLine($"Ganacia en el mes {suma}\n");
            Console.WriteLine("******************************************\n");
        }





        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                Console.WriteLine("1-cargar");
                Console.WriteLine("2-salir");

                op = Convert.ToInt32(Console.ReadLine());


                if (op == 1)
                {
                    Cargar_datos();
                }









            } while (op != 2);






            Console.ReadKey();
        }


    }


        
        
    
}
