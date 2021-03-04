using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{

    class Program
    {

        static void Main(string[] args)
        {


            Museo newMuseo = new Museo();////NUEVO OBJETO DE LA CLASE MUSEO
            /////////inicializamos las variables////////////
            bool exit = false;
            int option = 0;
            string title = "";
            string type = "";
            string incharge = "";
            string autorObra = "";
            int age = 0;
            string model = " ";
            string tasktype = "";
            DateTime date;
            int durationMant=0;
            string pintura=" ";
            string material="";

            do
            {
                    Console.WriteLine
                ("###############################################\n");
                    
                    Console.WriteLine("SELECCIONE LA OPCION QUE DESEE REALIZAR \n");
                    Console.WriteLine("1-Agregar cuadro");
                    Console.WriteLine("2-Agregar escultura");
                    Console.WriteLine("3-Hacer mantenimiento");
                    Console.WriteLine("4-Listar Obras de Arte");
                    Console.WriteLine("5-SALIR");
                    Console.WriteLine("");
                    Console.WriteLine
                ("###############################################\n");
                    option = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                if (option == 1)////SI LA OBRA ES UN CUADRO
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el titulo de la obra:");
                    title = Console.ReadLine();
                    int selec = 0;
                    do
                    {
                        Console.WriteLine("Seleccione el tipo de obra => 1)- Surrealismo. 2)- Impresionismo. 3)- Abstracto ");
                        selec = Convert.ToInt32(Console.ReadLine());
                        if (selec == 1)
                        {
                            type = "Surrealismos";
                        }
                        else if (selec == 2)
                        {
                            type = "Impresionismo";
                        }
                        else if (selec == 3)
                        {
                            type = "Abstracto";
                        }
                        else { Console.WriteLine("## OPCION INCORRECTA!!! ###"); }



                    } while (selec != 1 && selec != 2 && selec != 3);


                    Console.WriteLine("Ingrese el año de creacion: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del autor: ");
                    autorObra = Console.ReadLine();
                    Console.WriteLine("Modelo de la obra: ");
                    model = Convert.ToString( Console.ReadLine());
                    Console.WriteLine("Tipo de pintura: ");
                    pintura = Console.ReadLine();
                    Cuadro nuevoCuadro = new Cuadro(title, type, age, autorObra,model,pintura);
                    newMuseo.listadeObras.Add(nuevoCuadro);
                    Console.Clear();
                    Console.WriteLine("--------EL CUADRO SE AGREGO CON EXITO-------\n");
                    

                }

                else if (option == 2)///SI LA OBRA ES UNA ESCULTURA
                 {
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el titulo de la obra:");
                    title = Console.ReadLine();
                    int selec = 0;
                    do
                    {
                        Console.WriteLine("Seleccione el tipo de obra=> 1)- Surrealismo. 2)- Impresionismo.3)- Abstracto ");
                        selec = Convert.ToInt32(Console.ReadLine());
                        if (selec == 1)
                        {
                            type = "Surrealimos";
                        }
                        else if (selec == 2)
                        {
                            type = "Impresionismo";
                        }
                        else if (selec == 3)
                        {
                            type = "Abstracto";
                        }
                        else { Console.WriteLine("## OPCION INCORRECTA!!! ###"); }



                    } while (selec != 1 && selec != 2 && selec != 3);


                    Console.WriteLine("Ingrese el año de creacion: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre del autor: ");
                    autorObra = Console.ReadLine();
                    Console.WriteLine("Modelo de la obra: ");
                    model =Convert.ToString (Console.ReadLine());
                    Console.WriteLine("Tipo de material: ");
                    material= Console.ReadLine();
                    Escultura nuevaEscultura = new Escultura(title, type, age, autorObra, model, material);
                    newMuseo.listadeObras.Add(nuevaEscultura);
                    Console.Clear();
                    Console.WriteLine("-----LA ESCULTURA SE AGREGO CON EXITO-------\n");

                    ;

                    

                 }
                 else if (option == 3)///HACER MANTENIMIENTO A UN OBRA DE ARTE
                 {

                     Console.WriteLine("INVENTARIO DE OBRAS DE ARTE DEL MUSEO : \n");
                     for (int i = 0; i < newMuseo.listadeObras.Count; i++)
                     {
                       
                            Console.WriteLine("=================================================================\n");
                            Console.WriteLine($"Código {i + 1}\n");
                            newMuseo.listadeObras[i].MostrarObra();
                            Console.WriteLine("=================================================================\n");
                        
                        
                     }
                     if (newMuseo.listadeObras.Count == 0)
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
                         for (int i = 0; i < newMuseo.listadeObras.Count; i++)
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
                             incharge = Console.ReadLine();
                             int selecMant = 0;
                             do
                             {
                                 Console.WriteLine("#_Seleccion el tipo de tarea a realizar\n");
                                 Console.WriteLine("1-Restauracion    2-Arreglo    3-Limpieza");
                                 selecMant = Convert.ToInt32(Console.ReadLine());
                                 if (selecMant == 1)
                                 {
                                     tasktype = "Restauracion";
                                 }
                                 else if (selecMant == 2)
                                 {
                                     tasktype = "Arreglo";
                                 }
                                 else if (selecMant == 3)
                                 {
                                     tasktype = "Limpieza";
                                 }
                                 else
                                 {
                                     Console.WriteLine(" ");
                                     Console.WriteLine("ERROR, opcion incorrecta!!!\n");
                                     
                                 }

                             } while (selecMant != 1 && selecMant != 2 && selecMant != 3);
                         }

                         Console.WriteLine("Fecha de inicio de mantenimiento :\n" );
                         date = Convert.ToDateTime(Console.ReadLine());
                         Console.WriteLine("Dias de duracion de la tarea de mantenimiento:\n");
                         durationMant = Convert.ToInt32(Console.ReadLine());
                         Mantenimiento nuevoMant = new Mantenimiento(incharge, tasktype, date, durationMant);
                         
                         newMuseo.listadeObras[seleccion -1].listMant.Add(nuevoMant);

                     }

                 }
                 else if (option == 4)// LISTAR OBRAS DE ARTE DEL MUSEO
                 {

                    
                     for (int i = 0; i < newMuseo.listadeObras.Count; i++)
                     {

                           Console.WriteLine("=================================================================\n");
                            Console.WriteLine($"Código {i + 1}\n");
                            newMuseo.listadeObras[i].MostrarObra();
                            Console.WriteLine("=================================================================\n");
 
                     } 

                     
                     if (newMuseo.listadeObras.Count == 0)
                     {
                         Console.WriteLine("\n");
                         Console.WriteLine(" ¡¡¡¡¡NO HAY OBRAS DE ARTE CARGADAS A LA LISTA DEL MUSEO!!!!!");
                         Console.WriteLine("");
                     }
                     else
                     {
                        Console.WriteLine(" --------------------------------------------------------------------------------------\n");
                        Console.WriteLine("Por favor seleccione la obra para ver datos sobre mantenimientos.");
                        int seleccion = Convert.ToInt32(Console.ReadLine());
                         bool found = false;
                         for (int i = 0; i < newMuseo.listadeObras.Count; i++)
                         {
                             if ((seleccion - 1) == i)
                             {
                                 found = true;

                             }

                         }
                         if (found == false)
                         {
                             Console.WriteLine(" ");
                             Console.WriteLine("## NO SE ENCONTRO LA OBRA DE ARTE BUSCADA");
                             Console.WriteLine(" ");
                         }
                         else
                         {
                             newMuseo.listadeObras[seleccion - 1].MostrarObra();
                             for (int i = 0; i < newMuseo.listadeObras[seleccion - 1].listMant.Count; i++)
                             {
                                 newMuseo.listadeObras[seleccion - 1].listMant[i].MostrarMantenimiento();



                             }
                         }


                     }


                 }
            } while (option != 5);
        }
    }
}
