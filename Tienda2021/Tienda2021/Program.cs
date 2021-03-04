using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Tienda nuevaTienda = new Tienda();

            bool salir = false;
            int selec;
            string marca;
            string modelo;
            string soporte = "";
            string tipo = "";
            string dir_reparacion = "";
            string memoria;
            string referencia = "";
            string pelicula = "";
            string nombre = "";
            string sensibilidad = "";
            string formato = "";

            do
            {
                Console.WriteLine("################################");
                Console.WriteLine("SELECCIONE UNA OPCION:\n " +
                    "1- Agregar camara DIGITAL \n " +
                    "2 -Agregar camara ANALOGICA \n " +
                    "3 -Peliculas \n " +
                    "4-Editar Item\n " +
                    "5 -Listar Camaras\n " +
                    "6 -Salir");
                Console.WriteLine("################################");
                selec = Convert.ToInt32(Console.ReadLine());

                else if (selec == 2) //Si es ANALOGICA
                {
                    Console.WriteLine("");
                    Console.Write("Ingrese la Marca: ");
                    marca = Console.ReadLine();
                    Console.Write("Ingrese el Modelo: ");
                    modelo = Console.ReadLine();

                    int selec2;
                    do
                    {
                        Console.WriteLine(" ¿ La camara posee Soporte ? ");
                        Console.WriteLine("         1-SI    2-NO");
                        selec2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (selec2)
                        {
                            case 1: soporte = "SI"; break;
                            case 2: soporte = "NO"; break;
                            default: Console.WriteLine("### Opcion Incorrecta ###"); break;

                        }



                    } while (selec2 != 1 && selec2 != 2 && selec2 != 3);

                    Console.WriteLine("Tipo de camara :");
                    tipo = Console.ReadLine();
                    Console.WriteLine("Direccion de reparacion :");
                    dir_reparacion = Console.ReadLine();
                    Console.Write("Pelicula : ");
                    pelicula = Console.ReadLine();
                    Analogica nuevaAnalog = new Analogica(marca, modelo, soporte, tipo, dir_reparacion, pelicula);
                    nuevaTienda.listaCamaras.Add(nuevaAnalog);




                } while (selec!=2);








        }
    }
}
