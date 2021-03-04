using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra_Venta
{
    class Program
    {

        static  double[,] ventas;
        static double[,] compras;
        static double[,] ganancias;
        static double[,] monto_compra;
        static double[,] monto_venta;
        static double [] semanas;
        static int semana;
        static int dia = 0;
        static int dia1 = 0;
        static int diag = 0;
        static int diav =0;
        static int diac = 0;
        static double suma = 0;
        static void Cargar_datos()
        {
            ventas = new double[2, 2];
            compras = new double[2, 2];
            ganancias = new double[2, 2];
            semanas = new double[2];
            monto_compra = new double[2,2];
            monto_venta = new double[2, 2];

             for (int f = 0; f < 2; f++)
             {
                 for (int c = 0; c < 2; c++)
                 {
                    double venta;
                    double vventa;
                    double cantidadv;
                    dia = dia + 1;
                    Console.WriteLine($"Dia {dia} valor venta \n");

                    vventa = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cantidad que desea vender \n");
                    cantidadv = Convert.ToDouble(Console.ReadLine());
                    monto_venta[f,c] = cantidadv;
                    venta = vventa * cantidadv;
                    ventas[f, c] = venta;




                 }
             }
            Console.Clear();
           
                
                for (int f = 0; f < 2; f++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        double vcompra;
                        double cantidadc;
                        double compra;
                        dia1 = dia1 + 1;
                        Console.WriteLine($"Dia {dia1} valor compra \n");
                        vcompra = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Cantidad que desea comprar \n");
                        cantidadc = Convert.ToDouble(Console.ReadLine());
                        monto_compra[f, c] = cantidadc;
                        compra = vcompra * cantidadc;

                        compras[f, c] = compra;


                    }
                }

            Console.Clear();
            for (int f = 0; f < 2; f++)
            {

                for (int c = 0; c < 2; c++)
                {
                    ganancias[f, c] = ventas[f, c] - compras[f, c];//ganancia por dia
                    suma = suma + ganancias[f, c];//ganacia en el mes
                }
            }


            for (int f = 0; f < 2; f++)
            {
                semanas[f] = 0;
                for (int c = 0; c < 2; c++)
                {

                    semanas[f] = semanas[f] + ganancias[f, c];//ganancia por semana

                }
            
            }


            Console.WriteLine("GANANCIA POR DIA : \n");
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 2; c++)
                {
                    diag = diag + 1;
                    Console.Write($"dia {diag} = " + ganancias[f, c] + "  ");

                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("******************************************\n");
            for (int f = 0; f < 2; f++)
            {
                semana = f + 1;
                Console.WriteLine($"Ganancia Semana N°{semana} = {semanas[f]}");
                Console.WriteLine("\n");
            }
            Console.WriteLine("******************************************\n");

            Console.WriteLine($"Ganacia en el mes {suma}\n");
            Console.WriteLine("******************************************\n");
        }

        static void Montos()
        {
            int selec = 0;
            do
            {
                Console.WriteLine("1- Montos vendidos");
                Console.WriteLine("2- Montos comprados");
                Console.WriteLine("3- Salir");
                selec = Convert.ToInt32(Console.ReadLine());

                if (selec==1)
                {


                    Console.WriteLine("Monto vendido x DIA : \n");
                    for (int f = 0; f < 2; f++)
                    {
                        for (int c = 0; c < 2; c++)
                        {
                            diav = diav + 1;
                            Console.Write($"dia {diav} = " + monto_venta[f, c] + "  ");

                        }
                        Console.WriteLine("\n");
                    }





                } else if (selec==2)
                {


                    Console.WriteLine("Monto comprado x DIA : \n");
                    for (int f = 0; f < 2; f++)
                    {
                        for (int c = 0; c < 2; c++)
                        {
                            diac = diac + 1;
                            Console.Write($"dia {diac} = " + monto_compra[f, c] + "  ");

                        }
                        Console.WriteLine("\n");
                    }



                }


            } while (selec != 3);




        }




        static void Main(string[] args)
        {

            Console.WriteLine("OPCIONES\n");
            Console.WriteLine("1-Ingreso de valores");
            Console.WriteLine("2-Montos diarios ");
            Console.WriteLine("3-Salir");
            var op = Console.ReadLine();
            while (Convert.ToInt32(op) != 0)
            {
                switch (Convert.ToInt32(op))
                {
                    case 1:
                        {
                            Cargar_datos();


                        }
                        break;

                    case 2:
                        {
                            Console.Clear();
                            Montos();
                            Console.WriteLine("\n");
                        }
                        break;

                }

                Console.WriteLine("OPCIONES\n");
                Console.WriteLine("1-Ingreso de valores");
                Console.WriteLine("2-Montos diarios ");
                Console.WriteLine("0-Salir");
                op = Console.ReadLine();

            }

           


            Console.ReadKey();
        }

      
    }
}
