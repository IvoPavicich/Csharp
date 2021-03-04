using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Fotografica
{
    class Program
    {
        static void Main(string[] args)
        {
            Tienda_Fotografica nuevaTienda = new Tienda_Fotografica();

            bool salir = false;
            int selec;
            string marca;
            string modelo;
            string soporte="";
            string tipo="";
            string dir_reparacion="";
            string memoria;
            string referencia="";
            string pelicula = "";
            string nombre="";
            string sensibilidad="";
            string formato="";
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

                if (selec == 1)
                {
                    Console.WriteLine("");
                    Console.Write("Ingrese la Marca: ");
                    marca = Console.ReadLine();
                    Console.Write("Ingrese el Modelo: ");
                    modelo = Console.ReadLine();

                    int selec2;
                    do
                    {
                        Console.WriteLine(" ¿ La camara posee Soporte Flash ? ");
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
                    Console.Write("Memoria : ");
                    memoria = Console.ReadLine();
                    Digital nuevaDigital = new Digital(marca, modelo, soporte, tipo, dir_reparacion, memoria);
                    nuevaTienda.listadodeCamaras.Add(nuevaDigital);








                }



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
                    Analogica nuevaAnalog = new Analogica(marca, modelo, soporte, tipo, dir_reparacion, pelicula );
                    nuevaTienda.listadodeCamaras.Add(nuevaAnalog);

                    Console.WriteLine("INVENTARIO DE Camaras : \n");
                    for (int i = 0; i < nuevaTienda.listadodeCamaras.Count; i++)
                    {


                        Console.WriteLine("=================================================================\n");
                        Console.WriteLine($"Código {i + 1} \n");
                        nuevaTienda.listadodeCamaras[i].MostrarCamaras();

                        Console.WriteLine("=================================================================\n");


                    }
                    if (nuevaTienda.listadodeCamaras.Count == 0)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("NO HAY Camaras!!!!!\n");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("Numero de la Camara:\n");
                        int seleccion = Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        for (int i = 0; i < nuevaTienda.listadodeCamaras.Count; i++)
                        {
                            if ((seleccion - 1) == i)
                            {
                                found = true;

                            }

                        }
                        if (found == false)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("##### NO SE ENCONTRO la camara BUSCADA!!! ######\n");
                            Console.WriteLine(" ");
                        }
                        else
                        {

                            Console.WriteLine("POR FAVOR INGRESE la marca de la pelicula:\n");
                            Console.WriteLine("\n");
                            marca = Console.ReadLine();

                            Console.WriteLine("Nombre :\n");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Modelo:\n");
                            modelo = Console.ReadLine();
                            Console.WriteLine("Sensibilidad:\n");
                            sensibilidad = Console.ReadLine();
                            Console.WriteLine("Formato:\n");
                            formato = Console.ReadLine();

                            Pelicula nuevaPeli = new Pelicula(marca, nombre, sensibilidad, formato);

                            nuevaTienda.listadodeCamaras[seleccion - 1].peliculas.Add(nuevaPeli);
                        }
                    }














                }

                else if (selec == 3)///AGREGAR PELICULAS
                {

                    //Console.WriteLine("INVENTARIO DE Camaras : \n");
                    //for (int i = 0; i < nuevaTienda.listadodeCamaras.Count; i++)
                    //{


                    //    Console.WriteLine("=================================================================\n");
                    //    Console.WriteLine($"Código {i + 1} \n");
                    //    nuevaTienda.listadodeCamaras[i].MostrarCamaras();
                        
                    //    Console.WriteLine("=================================================================\n");


                    //}
                    //if (nuevaTienda.listadodeCamaras.Count == 0)
                    //{
                    //    Console.WriteLine("\n");
                    //    Console.WriteLine("NO HAY Camaras!!!!!\n");
                    //    Console.WriteLine("");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("------------------------------------------------------------------");
                    //    Console.WriteLine("Numero de la Camara:\n");
                    //    int seleccion = Convert.ToInt32(Console.ReadLine());
                    //    bool found = false;
                    //    for (int i = 0; i < nuevaTienda.listadodeCamaras.Count; i++)
                    //    {
                    //        if ((seleccion - 1) == i)
                    //        {
                    //            found = true;

                    //        }

                    //    }
                    //    if (found == false)
                    //    {
                    //        Console.WriteLine(" ");
                    //        Console.WriteLine("##### NO SE ENCONTRO la camara BUSCADA!!! ######\n");
                    //        Console.WriteLine(" ");
                    //    }
                    //    else
                    //    {

                    //        Console.WriteLine("POR FAVOR INGRESE la marca de la pelicula:\n");
                    //        Console.WriteLine("\n");
                    //        marca = Console.ReadLine();

                    //        Console.WriteLine("Nombre :\n");
                    //        nombre = Console.ReadLine();
                    //        Console.WriteLine("Modelo:\n");
                    //        modelo = Console.ReadLine();
                    //        Console.WriteLine("Sensibilidad:\n");
                    //        sensibilidad = Console.ReadLine();
                    //        Console.WriteLine("Formato:\n");
                    //        formato = Console.ReadLine();

                    //        Pelicula nuevaPeli = new Pelicula(marca,nombre,sensibilidad,formato);

                    //        nuevaTienda.listadodeCamaras[seleccion - 1].peliculas.Add(nuevaPeli);
                    //    }
                    //}

                }

                else if (selec == 4)//EDITAR ITEMS
                {

                    Console.WriteLine("LISTA DE CAMARAS.");
                    for (int i = 0; i < nuevaTienda.listadodeCamaras.Count; i++)
                    {
                        Console.WriteLine("=================================================================\n");
                        Console.WriteLine($"Código {i + 1} \n");
                        nuevaTienda.listadodeCamaras[i].MostrarCamaras();

                        Console.WriteLine("=================================================================\n");

                    }
                    if (nuevaTienda.listadodeCamaras.Count == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("NO HAY CAMARAS DISPONIBLES");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("________________________________________________");
                        Console.WriteLine("Seleccione la Camara para agregar Item.");
                        int seleccion = Convert.ToInt32(Console.ReadLine());
                        bool encontrado = false;
                        for (int i = 0; i <= nuevaTienda.listadodeCamaras.Count; i++)
                        {
                            if ((seleccion - 1) == i)
                            {
                                encontrado = true;
                            }
                        }

                        if (encontrado == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("### No se encontro la camara buscada ###");
                            Console.WriteLine("");
                        }
                        else
                        {
                            int selecMan = 0;
                            do
                            {
                                Console.WriteLine("Seleccione el estado de la CAMARA");
                                Console.WriteLine("1-Disponible        2-Alquilada        3-Con Retraso   4-En Reparacion");
                                selecMan = Convert.ToInt32(Console.ReadLine());
                                if (selecMan == 1)
                                {
                                    referencia = "Disponible";
                                }
                                else if (selecMan == 2)
                                {
                                    referencia = "Alquilada";
                                }
                                else if (selecMan == 3)
                                {
                                    referencia = "Con Retraso";
                                }

                                else if (selecMan == 4)
                                {
                                    referencia = "En Reparacion";
                                }


                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Error, Opcion incorrecta");
                                    Console.WriteLine("");
                                }

                            } while (selecMan != 1 && selecMan != 2 && selecMan != 3 && selecMan != 4);

                            Item nuevoItem = new Item(referencia);
                            nuevaTienda.listadodeCamaras[seleccion - 1].list_Items.Add(nuevoItem);
                        }
                    }
                }
                else if (selec == 5)
                {
                    Console.WriteLine("LISTA DE CAMARAS.");
                    for (int i = 0; i < nuevaTienda.listadodeCamaras.Count; i++)
                    {
                        Console.WriteLine("=================================================================\n");
                        Console.WriteLine($"Código {i + 1} \n");
                        nuevaTienda.listadodeCamaras[i].MostrarCamaras();

                        Console.WriteLine("=================================================================\n");
                    }
                    if (nuevaTienda.listadodeCamaras.Count == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("LA TIENDA NO POSEE CAMARAS EN ESTE MOMENTO");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("________________________________________________");
                        Console.WriteLine("Seleccione una CAMARA para ver sus datos.");
                        int seleccion = Convert.ToInt32(Console.ReadLine());
                        bool encontrado = false;
                        for (int i = 0; i < nuevaTienda.listadodeCamaras.Count; i++)
                        {
                            if ((seleccion - 1) == i)
                            {
                                encontrado = true;
                            }
                        }

                        if (encontrado == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("### No se encontro la CAMARA buscada!!! ###");
                            Console.WriteLine("");
                        }
                        else
                        {
                            nuevaTienda.listadodeCamaras[seleccion - 1].MostrarCamaras();
                            for (int i = 0; i < nuevaTienda.listadodeCamaras[seleccion - 1].list_Items.Count; i++)
                            {
                                nuevaTienda.listadodeCamaras[seleccion - 1].list_Items[i].Mostrar_Item();

                            }

                            
                            for (int i = 0; i < nuevaTienda.listadodeCamaras[seleccion - 1].peliculas.Count; i++)
                            {
                                nuevaTienda.listadodeCamaras[seleccion - 1].peliculas[i].MostrarPelicula();

                            }






                        }
                    }
                }



                else if (selec == 6)
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error, Opcion incorrecta");
                    Console.WriteLine("");
                }


            } while(selec !=6);




        }
    }
}
