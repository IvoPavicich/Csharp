using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fORMAS_GEOMETRICAS
{
    class Program
    {
       

        static void Cuadrado()
        {
            int lado, area;

            Console.WriteLine("ingrese un lado del cuadrado");
            lado = Convert.ToInt16(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine($"El area del cuadrado es = {area} \n");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void Rectangulo()
        {
            int b, h,area;
            Console.WriteLine("ingrese la base del rectangulo");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo");
            h = Convert.ToInt16(Console.ReadLine());
            area = b * h;
            Console.WriteLine($"El area del rectanglo es = {area} \n");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void Circulo()
        {
            double radio, pi = 3.1416,area1;

            Console.WriteLine("ingrese un radio del circulo");
            radio = Convert.ToDouble(Console.ReadLine());
            area1 = pi * Math.Pow(radio,2);
            Console.WriteLine($"El area del circulo es = {area1} \n");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void Triangulo()
        {
            double bas, altura, area2;


            Console.WriteLine("ingrese la base del triangulo");
            bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo");
            altura = Convert.ToDouble(Console.ReadLine());
            area2 = (bas * altura) / 2;
            Console.WriteLine($"El area del triangulo es = {area2}\n");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }

        static void Menu()
        {
            byte opcion = 0;
            do
            {
                try
                {
                    Console.WriteLine("Menu de opciones \n");
                    Console.WriteLine("1.Cuadrado");
                    Console.WriteLine("2.Rectangulo");
                    Console.WriteLine("3.Circulo");
                    Console.WriteLine("4.Triangulo");
                    Console.WriteLine("5.Salir");
                    Console.WriteLine("Que opcion desea elegir?");
                    opcion = Convert.ToByte(Console.ReadLine());//Lee la opcion ingresada

                    switch (opcion)
                    {

                        case 1:
                            Cuadrado();
                            break;

                        case 2:
                            Rectangulo();
                            break;
                        case 3:
                            Circulo();
                            break;
                        case 4:
                            Triangulo();
                            break;
                        case 5:
                            Console.WriteLine("********************************");
                            Console.WriteLine("*****Aplicacion Finalizada******");
                            Console.WriteLine("********************************");
                            break;

                        default:
                            Console.WriteLine("********************************");
                            Console.WriteLine("*****Opcion Incorrecta******");
                            Console.WriteLine("********************************");
                            break;
                    }
                    ////////////////////////EXCEPCIONES EJ:numero en lugar de letras y viceversa////////
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("Erroor" + fe.Message);
                    Console.WriteLine("********************************");
                }
                catch (Exception e)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("Erroor" + e.Message);
                    Console.WriteLine("********************************");
                }
                
            } while (opcion != 5);
        }



        static void Main(string[] args)
        {
            Menu();
            
            Console.ReadKey(true);
        }
    }
}
