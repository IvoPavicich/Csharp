using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoPrueba
{
    class Program
    {
        static void Main(string[] args)
        {

            string encargado = "";
            string tipo_tarea = "";
            
            DateTime fecha;
            int duracion = 0;


            Museo newMuseo = new Museo();
            Obras obraArte = new Obras();
            
            obraArte.titulo = "Gioconda";
            obraArte.tipo = "Surrealista";
            obraArte.autor = "Miguel Angel";
            obraArte.modelo = "marta sanchez";
            obraArte.año = 1700;
            newMuseo.listaObras.Add(obraArte);
            Console.WriteLine("INVENTARIO DE OBRAS DE ARTE DEL MUSEO : \n");
            for (int i = 0; i < newMuseo.listaObras.Count; i++)
            {


                Console.WriteLine("=================================================================\n");
                Console.WriteLine($"Código {i + 1}=>> Titulo: {newMuseo.listaObras[i].titulo} \n");
                Console.WriteLine($"Autor: {newMuseo.listaObras[i].autor} \n");
                Console.WriteLine($"Modelo: {newMuseo.listaObras[i].modelo} \n");
                Console.WriteLine($"Año de creacion: {newMuseo.listaObras[i].año} \n");

                Console.WriteLine("=================================================================\n");


            }
            if (newMuseo.listaObras.Count == 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("NO HAY OBRAS DE ARTE CARGADAS A LA LISTA DEL MUSEO!!!!!\n");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("SELECCIONE LA OBRA PARA REALIZARLE MANTENIMIENTO:\n");
                int seleccion = Convert.ToInt32(Console.ReadLine());
                bool found = false;
                for (int i = 0; i < newMuseo.listaObras.Count; i++)
                {
                    if ((seleccion - 1) == i)
                    {
                        found = true;

                    }

                }
                if (found == false)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("##### NO SE ENCONTRO LA OBRA DE ARTE BUSCADA!!! ######\n");
                    Console.WriteLine(" ");
                }
                else
                {

                    Console.WriteLine("POR FAVOR INGRESE EL NOMBRE DEL ENCARGADO DEL MANTENIMIENTO:\n");
                    Console.WriteLine("\n");
                    encargado = Console.ReadLine();
                    int selecMant = 0;
                    do
                    {
                        Console.WriteLine("#_Seleccion el tipo de tarea a realizar\n");
                        Console.WriteLine("1-Restauracion    2-Arreglo    3-Limpieza");
                        selecMant = Convert.ToInt32(Console.ReadLine());
                        if (selecMant == 1)
                        {
                            tipo_tarea = "Restauracion";
                        }
                        else if (selecMant == 2)
                        {
                            tipo_tarea = "Arreglo";
                        }
                        else if (selecMant == 3)
                        {
                            tipo_tarea = "Limpieza";
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("ERROR, opcion incorrecta!!!\n");

                        }

                    } while (selecMant != 1 && selecMant != 2 && selecMant != 3);
                }


                Console.WriteLine("Fecha de inicio de mantenimiento :\n");
                fecha = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Dias de duracion de la tarea de mantenimiento:\n");
                duracion = Convert.ToInt32(Console.ReadLine());
                Mantenimiento nuevoMant = new Mantenimiento(encargado, tipo_tarea, fecha, duracion);
                newMuseo.listaObras[seleccion - 1].mante.Add(nuevoMant);

            }









            Console.ReadKey();





        }
    }
}
