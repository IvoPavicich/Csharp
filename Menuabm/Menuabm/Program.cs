using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Menuabm
{

    class Program
    {
        //variables globales
        static StreamReader Lectura;
        static StreamWriter escritura, temporal;
        static string cadena, respuesta;
        static string noSerie, modelo, fabricante, color;
        static short año;
        static double precio;
        static bool encontrado;
        static string[] campos = new string[6];



        static void Main(string[] args)
        {



            menu();
            Console.ReadKey(true);
        }
        //creacion del menu(metodo)

        static void menu()
        {
            byte opcion = 0;
            do
            {
                try
                {
                    Console.WriteLine("Menu de opciones");
                    Console.WriteLine("1.Altas");
                    Console.WriteLine("2.Bajas");
                    Console.WriteLine("3.Consultas");
                    Console.WriteLine("4.Modificaciones");
                    Console.WriteLine("5.Listar");
                    Console.WriteLine("6.Salir");
                    Console.WriteLine("Que opcion desea elegir?");
                    opcion = Convert.ToByte(Console.ReadLine());//Lee la opcion ingresada

                    switch (opcion)
                    {

                        case 1:
                            crearArchivo();
                            altas();
                            break;

                        case 2:
                            bajas();
                            break;
                        case 3:
                            Consultas();
                            break;
                        case 4:
                            Modificaciones();
                            break;
                        case 5:
                            Listar();
                            break;
                        case 6:
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
                } catch (FormatException fe)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("Erroor" + fe.Message);
                    Console.WriteLine("********************************");
                } catch (Exception e)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("Erroor" + e.Message);
                    Console.WriteLine("********************************");
                }
            } while (opcion != 6);
        }
        ///Metodo crearArchivo
        static void crearArchivo() {
            escritura = File.AppendText("autos.txt");
            escritura.Close();
        }
        /////////////////////////////////METODO DE ALTAS///////////////////////////////////////
        static void altas() {

            encontrado = false;
            try
            {///try-catch se usa para excepciones(es opcional)
                Lectura = File.OpenText("autos.txt");
                Console.WriteLine("ingrese el numero de serie :" + " ");
                noSerie = Console.ReadLine();
                noSerie = noSerie.ToUpper();
                cadena = Lectura.ReadLine();
                //se busca si no existe un auto con igual numero de serie//
                while (cadena != null)
                {
                    campos = cadena.Split(',');
                    if (campos[0].Trim().Equals(noSerie))
                    {
                        encontrado = true;
                        break;
                    }
                    cadena = Lectura.ReadLine();
                } Lectura.Close();
                escritura = File.AppendText("autos.txt");
                if (encontrado == false)
                {
                    Console.Write("Ingrese el modelo del auto :" + " ");
                    modelo = Console.ReadLine();
                    Console.Write("Ingrese año del auto :" + " ");
                    año = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Ingrese el fabricante del auto:" + " ");
                    fabricante = Console.ReadLine();
                    Console.Write("Ingrese el color del auto:" + " ");
                    color = Console.ReadLine();
                    Console.Write("Ingrese el precio del auto :" + " ");
                    precio = Convert.ToDouble(Console.ReadLine());
                    //ESCRIBIR DATOS EN EL ARCHIVO
                    escritura.WriteLine(noSerie + "," + modelo + "," + año + "," + fabricante + "," + color + "," + precio + ",");
                    Console.WriteLine("********************************");
                    Console.WriteLine("¡¡¡¡FUE CARGADO CON EXITO!!!!!");
                    Console.WriteLine("********************************");
                }
                else
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("YA EXISTE UN AUTO CON EL NUMERO DE SERIE" + noSerie + ",intente de nuevo");
                    Console.WriteLine("********************************");

                } escritura.Close();

            } catch (FileNotFoundException fn)

            {
                Console.WriteLine("********************************");
                Console.WriteLine("Erroor" + fn.Message);
                Console.WriteLine("********************************");
            }
            catch (Exception e)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Erroor" + e.Message);
                Console.WriteLine("********************************");
            }
            finally { escritura.Close(); Lectura.Close(); }//si se produce o no una excepcion nos aseguramos de que si se cierre
        }
        //////////////////////////////////////////////METODO PARA BAJAS///////////////////////////
        static void bajas() {
            encontrado = false;
            try {
                Lectura = File.OpenText("autos.txt");
                temporal = File.CreateText("tmp.txt");

                Console.WriteLine("ingrese el numero de serie que se quiere eliminar :" + " ");
                noSerie = Console.ReadLine();
                noSerie = noSerie.ToUpper();
                cadena = Lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(',');
                    if (campos[0].Trim().Equals(noSerie))
                    {
                        encontrado = true;
                        Console.WriteLine("                              ");
                        Console.WriteLine("***********AUTO ENCONTRADO*****");
                        Console.WriteLine("N° Serie" + campos[0]);
                        Console.WriteLine("Modelo" + campos[1]);
                        Console.WriteLine("Año" + campos[2]);
                        Console.WriteLine("Fabricante " + campos[3]);
                        Console.WriteLine("Color" + campos[4]);
                        Console.WriteLine("Precio" + campos[5]);
                        Console.WriteLine("*******************************");
                        Console.WriteLine("DESEAS ELIMINARLO (si/no)??...");
                        respuesta = Console.ReadLine();
                        if (!respuesta.Equals("si"))
                        {

                            temporal.WriteLine(cadena);
                        }
                    }
                    else
                    {
                        temporal.WriteLine(cadena);
                    }

                    cadena = Lectura.ReadLine();
                }

                if (encontrado == false)
                {

                    Console.WriteLine("*********************************************");
                    Console.WriteLine("****El AUTO CON N° DE SERIE" + noSerie + " NO EXISTE EN LA BASE DE DATOS****");
                    Console.WriteLine("*********************************************");
                }
                else if (respuesta.Equals("si"))
                {

                    Console.WriteLine("****Auto Eliminado***");
                }
                else { Console.WriteLine("****Operacion Cancelada***"); }
                Lectura.Close();
                temporal.Close();
                File.Delete("autos.txt");
                File.Move("tmp.txt", "autos.txt");
            }
            catch (FileNotFoundException fn)

            {
                Console.WriteLine("********************************");
                Console.WriteLine("Erroor" + fn.Message);
                Console.WriteLine("********************************");
            }
            catch (Exception e)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Erroor" + e.Message);
                Console.WriteLine("********************************");
            }
            finally { temporal.Close(); Lectura.Close(); }

        }
        //////////////////////////metodo de consultas//////////////////////////////
       static void Consultas()
        {
            encontrado = false;
            try
            {
                Lectura = File.OpenText("autos.txt");
              

                Console.WriteLine("ingrese el nombre del fabricante :" + " ");
                fabricante = Console.ReadLine();
                fabricante = fabricante.ToUpper();
                cadena = Lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(',');
                    if (campos[3].Trim().Equals(fabricante))
                    {
                        encontrado = true;
                        Console.WriteLine("                              ");
                        Console.WriteLine("***********AUTO ENCONTRADO*****");
                        Console.WriteLine("N° Serie" + campos[0]);
                        Console.WriteLine("Modelo" + campos[1]);
                        Console.WriteLine("Año" + campos[2]);
                        Console.WriteLine("Fabricante " + campos[3]);
                        Console.WriteLine("Color" + campos[4]);
                        Console.WriteLine("Precio" + campos[5]);
                        Console.WriteLine("*******************************");
                    }

                    cadena = Lectura.ReadLine();
                        
                }
                if (encontrado == false)
                {
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("****NO HAY AUTOS CON EL FABRICANTE:" + fabricante + "***");
                    Console.WriteLine("*********************************************");
                }

                Lectura.Close();
            }
            catch (FileNotFoundException fn)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Erroor" + fn.Message);
                Console.WriteLine("********************************");
            }
            catch (Exception e)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Erroor" + e.Message);
                Console.WriteLine("********************************");
            }
            finally { Lectura.Close(); }
       }
        //////////////////////////////M O D I F I C A C I O N E S/////////////////
        static void Modificaciones() {
            encontrado = false;
            byte opcionM;
            opcionM = 0;
            string nuevoModelo, nuevoFabricante, nuevoColor;
            double nuevoPrecio;
            short nuevoAño;
            try
            {

                Lectura = File.OpenText("autos.txt");
                temporal = File.CreateText("tmp.txt");
                Console.WriteLine("ingrese el numero de serie");
                noSerie = Console.ReadLine();
                noSerie = noSerie.ToUpper();
                cadena = Lectura.ReadLine();
                while (cadena != null)
                {
                    campos = cadena.Split(',');
                    if (campos[0].Trim().Equals(noSerie))
                    {
                        encontrado = true;
                        Console.WriteLine("                              ");
                        Console.WriteLine("***********AUTO ENCONTRADO*****");
                        Console.WriteLine("N° Serie" + campos[0]);
                        Console.WriteLine("Modelo" + campos[1]);
                        Console.WriteLine("Año" + campos[2]);
                        Console.WriteLine("Fabricante " + campos[3]);
                        Console.WriteLine("Color" + campos[4]);
                        Console.WriteLine("Precio" + campos[5]);
                        Console.WriteLine("*******************************");
                        Console.WriteLine("es el registro que buscas (SI/NO)??...");

                        respuesta = Console.ReadLine();
                        respuesta = respuesta.ToUpper();

                        if (respuesta.Equals("SI"))
                        {
                            Console.WriteLine("OPCIONES PARA MODIFICAR");
                            Console.WriteLine("1.Modelo");
                            Console.WriteLine("2.Año");
                            Console.WriteLine("3.Fabricante");
                            Console.WriteLine("4.Color");
                            Console.WriteLine("5.Precio");
                            Console.WriteLine("QUE DESEAS MODIFICAR?");
                            opcionM = Convert.ToByte(Console.ReadLine());
                            switch (opcionM)
                            {

                                case 1:
                                    Console.WriteLine("ingrese el nuevo modelo");
                                    nuevoModelo = Console.ReadLine();
                                    nuevoModelo = nuevoModelo.ToUpper();
                                    temporal.WriteLine(campos[0] + " , " + nuevoModelo + "," + campos[2] + "," + campos[3] + "," + campos[4] + "," + campos[5]);
                                    Console.WriteLine("*****EL REGSITRO HA SIDO MODIFICADO****");
                                    break;

                                case 2:
                                    Console.WriteLine("ingrese el nuevo año");
                                    nuevoAño = Convert.ToInt16(Console.ReadLine());
                                    temporal.WriteLine(campos[0] + "," + campos[1] + " , " + nuevoAño + "," + campos[3] + "," + campos[4] + "," + campos[5]);
                                    Console.WriteLine("*****EL REGSITRO HA SIDO MODIFICADO****");

                                    break;
                                case 3:
                                    Console.WriteLine("ingrese el nuevo fabricante");
                                    nuevoFabricante = Console.ReadLine();
                                    nuevoFabricante = nuevoFabricante.ToUpper();
                                    temporal.WriteLine(campos[0] + " , " + campos[1] + "," + campos[2] + " , " + nuevoFabricante + "," + campos[4] + "," + campos[5]);
                                    Console.WriteLine("*****EL REGSITRO HA SIDO MODIFICADO****");
                                    break;
                                case 4:
                                    Console.WriteLine("ingrese el nuevo color");
                                    nuevoColor = Console.ReadLine();
                                    nuevoColor = nuevoColor.ToUpper();
                                    temporal.WriteLine(campos[0] + " , " + campos[1] + "," + campos[2] + " , " + campos[3] + " , " + nuevoColor + "," + campos[5]);
                                    Console.WriteLine("*****EL REGSITRO HA SIDO MODIFICADO****");
                                    break;
                                case 5:
                                    Console.WriteLine("ingrese el nuevo precio");
                                    nuevoPrecio = Convert.ToDouble(Console.ReadLine());
                                    temporal.WriteLine(campos[0] + " , " + campos[1] + "," + campos[2] + "," + campos[3] + " , " + campos[4] + " , " + nuevoPrecio);
                                    Console.WriteLine("*****EL REGSITRO HA SIDO MODIFICADO****");
                                    break;
                                default:
                                    Console.WriteLine("********************************");
                                    Console.WriteLine("*****Opcion Incorrecta******");
                                    Console.WriteLine("********************************");
                                    break;
                            }

                        }
                        else
                        {
                            temporal.WriteLine(cadena);

                        }
                    }
                    else { temporal.WriteLine(cadena); }
                    cadena =Lectura.ReadLine();


                }

                if (encontrado == false)
                {
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("****El AUTO CON N° DE SERIE" + noSerie + " NO EXISTE EN LA BASE DE DATOS****");
                    Console.WriteLine("*********************************************");
                }
                Lectura.Close();
                temporal.Close();
                File.Delete("autos.txt");
                File.Move("tmp.txt", "autos.txt");
            }
            catch (FileNotFoundException fn)

            {
                Console.WriteLine("********************************");
                Console.WriteLine("Erroor" + fn.Message);
                Console.WriteLine("********************************");
            }
            catch (Exception e)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Erroor" + e.Message);
                Console.WriteLine("********************************");
            }
            finally { temporal.Close(); Lectura.Close(); }
         }

        //////////////////////////// CONSULTAS EN GENERAL/////

        static void Listar()
        {
            encontrado = false;
            try
            {
                Lectura = File.OpenText("autos.txt");
                cadena = Lectura.ReadLine();
                while (cadena != null) {
                    campos = cadena.Split(',');
                    encontrado = true;
                    Console.WriteLine("N° Serie:  " + campos[0]);
                    Console.WriteLine("Modelo:  " + campos[1]);
                    Console.WriteLine("Año:   " + campos[2]);
                    Console.WriteLine("Fabricante :  " + campos[3]);
                    Console.WriteLine("Color:   " + campos[4]);
                    Console.WriteLine("Precio:   " + campos[5]);
                    Console.WriteLine("///////////////////////////");
                    cadena = Lectura.ReadLine();
                }
                if (encontrado==false)
                {
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("****NO EXISTEN AUTOS EN LA BASE DE DATOS****");
                    Console.WriteLine("*********************************************");
                }
            }
            catch(FileNotFoundException fn)

            {
                Console.WriteLine("********************************");
                Console.WriteLine("Erroor" + fn.Message);
                Console.WriteLine("********************************");
            }
            catch (Exception e)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("Erroor" + e.Message);
                Console.WriteLine("********************************");
            }
            finally { Lectura.Close(); }
        }

    }


}       


   
