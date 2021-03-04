using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public struct Trabajador
    {
        public string nombre;
        public string apellido;
        public int dni;
        public string direccion;
        public string puesto;
        public double horasMensuales;
        public double valorHora;
        public string nivelAcademico;

        public Trabajador(string nombre, string apellido, int dni, string direccion, string puesto, double horasMensuales, double valorHora, string nivelAcademico)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.puesto = puesto;
            this.horasMensuales = horasMensuales;
            this.valorHora = valorHora;
            this.nivelAcademico = nivelAcademico;
        }
        public double LiquidarSueldo()
        {
            double sueldo = 0;
            double porcentaje = 0; //aportes personales
            sueldo = horasMensuales * valorHora;
            porcentaje = 17 * (sueldo / 100);
            sueldo = sueldo - porcentaje;
            return sueldo;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("Direccion: " + direccion);
            Console.WriteLine("Puesto de Trabajo: " + puesto);
            Console.WriteLine("horasMensuales: " + horasMensuales);
            Console.WriteLine("valorHora: " + valorHora);
            Console.WriteLine("nivelAcademico: " + nivelAcademico);
        }
    }


    class Program
    {

        static string SelecNivelAcademico()
        {
            string nivelAcademico = "";
            int selec2 = 0;
            do
            {
                Console.WriteLine("1-Primario:");
                Console.WriteLine("2-Secundario:");
                Console.WriteLine("3-Terciario:");
                Console.WriteLine("4-Universitario:");
                Console.WriteLine("5-Magister:");
                Console.WriteLine("6-Doctor:");

                selec2 = Convert.ToInt32(Console.ReadLine());

                if (selec2 == 1)
                {
                    nivelAcademico = "Primario";
                }
                else if (selec2 == 2)
                {
                    nivelAcademico = "Secundario";
                }
                else if (selec2 == 3)
                {
                    nivelAcademico = "Terciario";
                }
                else if (selec2 == 4)
                {
                    nivelAcademico = "Universitario";
                }
                else if (selec2 == 5)
                {
                    nivelAcademico = "Magister";
                }
                else if (selec2 == 6)
                {
                    nivelAcademico = "Doctor";
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Opcion incorrecta.");
                }

            } while (selec2 != 1 && selec2 != 2 && selec2 != 3 && selec2 != 4 && selec2 != 5 && selec2 != 6);
            return nivelAcademico;
        }
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int dni;
            string direccion;
            string puesto;
            double horasMensuales;
            double valorHora;
            string nivelAcademico;
            int selec = 0;
            List<Trabajador> listrabajador = new List<Trabajador>();

            do //MENU
            {
                Console.WriteLine("############################################");
                Console.WriteLine("SELECCIONE UNA OPCION:");
                Console.WriteLine("1-Agregar Trabajador:");
                Console.WriteLine("2-Modificar Trabajador:");
                Console.WriteLine("3-Eliminar Trabajador:");
                Console.WriteLine("4-Liquidar Sueldos y Listar Trabajadores:");
                Console.WriteLine("5-Salir");
                Console.WriteLine("############################################");
                selec = Convert.ToInt32(Console.ReadLine());
                if (selec != 1 && selec != 2 && selec != 3 && selec != 4 && selec != 5)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Opcion incorrecta.");
                    Console.WriteLine(" ");
                }
                else if (selec == 1) //SI SELECCIONO LA OPCION 1
                {
                    Console.WriteLine("Ingrese el nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido: ");
                    apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese el DNI: ");
                    dni = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el direccion: ");
                    direccion = Console.ReadLine();
                    Console.WriteLine("Ingrese el Puesto de Trabajo: ");
                    puesto = Console.ReadLine();
                    Console.WriteLine("Ingrese el total de horas mensuales trabajadas: ");
                    horasMensuales = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el Valor por hora trabajada: ");
                    valorHora = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Seleccione el Nivel Academico:");
                    nivelAcademico = SelecNivelAcademico(); //Seleccionar nivel Academico

                    Trabajador nuevotrabajador = new Trabajador(nombre, apellido, dni, direccion, puesto, horasMensuales, valorHora, nivelAcademico);
                    listrabajador.Add(nuevotrabajador);
                    Console.WriteLine("");
                    Console.WriteLine("----EL NUEVO TRABAJADOR SE HA GUARDADO CON EXITO----");
                    Console.WriteLine("");
                }
                else if (selec == 2)//SI SELECCIONO LA OPCION 2
                {
                    bool encontrado = false;
                    int i = 0;
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el dni del trabajador a editar");
                    int dnibuscado = Convert.ToInt32(Console.ReadLine());
                    while (encontrado == false && i < listrabajador.Count)
                    {
                        if (listrabajador[i].dni == dnibuscado)
                        {
                            encontrado = true;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    if (encontrado == false)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("El dni buscado no pertenece a ningun trabajador.");
                    }
                    else
                    {
                        int seleccion = 0;
                        do
                        {
                            Console.WriteLine("Ingrese el nombre: ");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese el apellido: ");
                            apellido = Console.ReadLine();
                            Console.WriteLine("Ingrese el DNI: ");
                            dni = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el direccion: ");
                            direccion = Console.ReadLine();
                            Console.WriteLine("Ingrese el Puesto de Trabajo: ");
                            puesto = Console.ReadLine();
                            Console.WriteLine("Ingrese el total de horas mensuales trabajadas: ");
                            horasMensuales = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el Valor por hora trabajada: ");
                            valorHora = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Seleccione el Nivel Academico:");
                            nivelAcademico = SelecNivelAcademico(); //Seleccionar nivel Academico

                            Trabajador nuevotrabajador = new Trabajador(nombre, apellido, dni, direccion, puesto, horasMensuales, valorHora, nivelAcademico);
                            listrabajador.RemoveAt(i);
                            listrabajador.Insert(i, nuevotrabajador);
                            Console.WriteLine("");
                            Console.WriteLine("----EL TRABAJADOR SE MODIFICO CON EXITO----");
                            Console.WriteLine("");

                        } while (seleccion != 1 && seleccion != 2 && seleccion != 3 && seleccion != 4 && seleccion != 5 && seleccion != 6 && seleccion != 7 && seleccion != 8);
                        Console.WriteLine("");
                        Console.WriteLine("----SE HA MODIFICADO CON EXITO----");
                        Console.WriteLine("");




                        Console.WriteLine("############################################");
                        Console.WriteLine("SELECCIONE UNA OPCION:");
                        Console.WriteLine("1-Agregar Trabajador:");
                        Console.WriteLine("2-Modificar Trabajador:");
                        Console.WriteLine("3-Eliminar Trabajador:");
                        Console.WriteLine("4-Liquidar Sueldos y Listar Trabajadores:");
                        Console.WriteLine("5-Salir");
                        Console.WriteLine("############################################");
                        selec = Convert.ToInt32(Console.ReadLine());
                        if (selec != 1 && selec != 2 && selec != 3 && selec != 4 && selec != 5)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Opcion incorrecta.");
                            Console.WriteLine(" ");
                        }






                    }





                }
                

                else if (selec == 3) //SI SELECCIONO LA OPCION 3
                {
                    bool encontrado = false;
                    int i = 0;
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese el dni del trabajador a borrar");
                    int dnibuscado = Convert.ToInt32(Console.ReadLine());

                    while (encontrado == false && i <= listrabajador.Count)
                    {
                        if (listrabajador.Count == 0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("NO EXISTE NINGUN TRABAJADOR.");
                            Console.WriteLine(" ");
                            i++;
                        }
                        else if (listrabajador[i].dni == dnibuscado)
                        {
                            encontrado = true;
                            listrabajador.Remove(listrabajador[i]);
                            Console.WriteLine("");
                            Console.WriteLine("----LOS DATOS SE HAN ELIMINADO CON EXITO----");
                            Console.WriteLine("");
                        }
                        else if (encontrado == false)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("El dni buscado no pertenece a ningun trabajador.");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                else if (selec == 4)//SI SELECCIONO LA OPCION 4
                {
                    //Liquidar Sueldos y Listar Trabajadores:
                    double sueldo;
                    for (int i = 0; i < listrabajador.Count; i++)
                    {
                        listrabajador[i].MostrarDatos();
                        sueldo = listrabajador[i].LiquidarSueldo();
                        Console.WriteLine("SUELDO: " + sueldo);
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine(" ");
                    }
                    if (listrabajador.Count == 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("NO EXISTE NINGUN TRABAJADOR.");
                        Console.WriteLine(" ");
                    }
                }
            } while (selec != 5); //FIN MENU
        }
    }
}
