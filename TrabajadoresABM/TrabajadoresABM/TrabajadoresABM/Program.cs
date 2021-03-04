using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajadoresABM
{
    class Program
    {
        struct Trabajadores
        {
            public string nombre;
            public string apellido;
            public int dni;
            public int hrs;
            public double vhrs;
        }
        /////////////////////////////////////////////////////// AGREGAR//////////////////////////////////////////////
        static void agregar(List<Trabajadores> trabajadores, string nombre, string apellido, int dni, int hrs, double vhrs)
        {
            Trabajadores trabajador = new Trabajadores
            {
                nombre = nombre,
                apellido = apellido,
                dni = dni,
                hrs = hrs,
                vhrs = vhrs,

            };

            trabajadores.Add(trabajador);
        }

        static void eliminar(List<Trabajadores> trabajadores, int search)
        {
            int index;
            index = trabajadores.FindIndex(x => x.dni == search);
            trabajadores.Remove(trabajadores[index]);

        }


        static void modificar(List<Trabajadores> trabajadores, string nombre, string apellido, int dni, int hrs, double vhrs,int search)
        {
            int index;
            index = trabajadores.FindIndex(x => x.dni == search);
            trabajadores.RemoveAt(index);
            Trabajadores trabajador = new Trabajadores
            {
                nombre = nombre,
                apellido = apellido,
                dni = dni,
                hrs = hrs,
                vhrs = vhrs,

            };


            trabajadores.Insert(index,trabajador);
            
        }




        static void Liquidar_Listar(List<Trabajadores> trabajadores)
        {


            double sueldobruto = 0;
            double sueldoneto = 0;//aportes personales
            foreach (var i in trabajadores)
            {
                sueldobruto = i.hrs * i.vhrs;
                sueldoneto= sueldobruto - (sueldobruto *0.17);
                Console.WriteLine("Nombre \n" + i.nombre + " \n Apellido \n" + i.apellido + "\n DNI \n" + i.dni + "\n Horas trabajadas \n " + i.hrs+ "\n Sueldo bruto \n "+ sueldobruto +"\n Sueldo neto \n" + sueldoneto );


            }
 
        }
        static void Listar(List<Trabajadores> trabajadores)
        {
            
            
            Console.WriteLine("Trabajadores CARGADOS\n");
            foreach (var i in trabajadores)
            {
                Console.WriteLine("Nombre \n" + i.nombre + "Apellido \n" + i.apellido + " DNI \n " + i.dni + " Horas trabajadas \n" + i.hrs );
              

            }
        }


        static void Main(string[] args)
        {


            List<Trabajadores> trabajadores = new List<Trabajadores>();
            string nombre, apellido;
            int dni,hrs, search;
            double vhrs;

            Console.WriteLine("Nomina \n");
            Console.WriteLine("Elija una opcion\n");
            Console.WriteLine("1.Agregar\n  2.Listar \n  3.Listar y Liquidar\n 4.Eliminar\n 5.Modificar\n 0.Salir \n");
            var opcion = Console.ReadLine();
            while (Convert.ToInt32(opcion) != 0)
            {
                switch (Convert.ToInt32(opcion))
                {
                    case 1:////AGREGAR
                        {
                            Console.WriteLine("Nombre  :");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Apellido :");
                            apellido = Console.ReadLine();
                            Console.WriteLine("DNI:");
                            dni = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Horas:");
                            hrs = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Valor por hora :");
                            vhrs = Convert.ToDouble(Console.ReadLine());
                            agregar(trabajadores, nombre, apellido,dni,hrs, vhrs);
                            break;
                        }


                    

                    case 2:////LISTAR
                        {
                            Console.WriteLine("Lista de trabajadoes :\n");
                            Listar(trabajadores);

                            break;
                        }

                    case 3:////LISTAR_liquidar
                        {

                            Liquidar_Listar(trabajadores);

                            break;
                        }



                    case 4:////ELIMINAR
                        {
                            Console.WriteLine("Indique el dni del trabajador\n");
                            search = Convert.ToInt32(Console.ReadLine());
                            eliminar(trabajadores, search);

                            break;
                        }
                    case 5:////Modificar
                        {
                            Console.WriteLine("Indique el dni del trabajador\n");
                            search = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Nombre  :");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Apellido :");
                            apellido = Console.ReadLine();
                            Console.WriteLine("DNI:");
                            dni = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Horas:");
                            hrs = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Valor por hora :");
                            vhrs = Convert.ToDouble(Console.ReadLine());


                            modificar(trabajadores, nombre, apellido, dni, hrs, vhrs,search);

                            break;
                        }
                }
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Elija una opcion\n");
                Console.WriteLine("1.Agregar\n  2.Listar \n  3.Listar y Liquidar\n 4.Eliminar\n 5.Modificar\n 0.Salir \n");
                opcion = Console.ReadLine();
            }








        }
    }
}
