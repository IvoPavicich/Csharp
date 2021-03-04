using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajadoresABM
{
    class Program
    {
        static double bruto, neto;
        struct Trabajadores
        {
            public string nombre;
            public string apellido;
            public int hrs;
            public double vhrs;

            /////////////////////////////////////////////////////// AGREGAR//////////////////////////////////////////////
            public Trabajadores(string nombre, string apellido, int hrs, double vhrs)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.hrs = hrs;
                this.vhrs = vhrs;
                

            }
            static void sueldoBruto(int hrs, double vhrs)
            {

                bruto = (hrs * vhrs);


            }

            static void sueldoNeto(double bruto)
            {

                neto = bruto - (bruto * 0.17);


            }

            static String MostrarDatos(string nombre,string apellido,int hrs,double vhrs)////Metodo
            {

                return "Nombre  "+nombre+ " Apellido " +apellido +" Horas en el mes "+ hrs +" Valor dde la hora "+ vhrs+ " Sueldo Bruto "+ bruto + " Sueldo Neto " + neto ;


            }






        }












        



















        

        static void Main(string[] args)
        {
            List<Trabajadores> trabajadores = new List<Trabajadores>();
            string nombre, apellido, search;
            int hrs;
            double vhrs;

            Console.WriteLine("NOMINA DE TRBAJADORES \n");
            Console.WriteLine("Elija una opcion\n");
            Console.WriteLine("1.Agregar\n  2.Listar\n  3.Buscar\n 4.Eliminar\n  5.Salir \n");
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
                            Console.WriteLine("Horas trbajadas:");
                            hrs= Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Valor por hora :");
                            vhrs = Convert.ToDouble(Console.ReadLine());
                            Trabajadores trabajador = new Trabajadores(nombre, apellido, hrs,vhrs);
                            trabajadores.Add(trabajador);
                            break;
                        }


                    case 2:////LISTAR
                        {
                            Console.WriteLine("Lista de terrenos :\n");
                            

                            break;
                        }

                    //case 3:////BUSCAR
                    //    {
                    //        Console.WriteLine("Indique el nombre del titular\n");
                    //        search = Console.ReadLine();
                    //        buscar(terrenos, search);
                    //        break;
                    //    }

                    //case 4:////ELIMINAR
                    //    {
                    //        Console.WriteLine("Indique el nombre del titular\n");
                    //        search = Console.ReadLine();
                    //        eliminar(terrenos, search);

                    //        break;
                    //    }

                }
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Elija una opcion\n");
                Console.WriteLine("1.Agregar\n  2.Listar\n  3.Buscar\n 4.Eliminar\n  5.Salir \n");
                opcion = Console.ReadLine();
            }






        }
    }
}
