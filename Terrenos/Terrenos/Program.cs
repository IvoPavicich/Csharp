using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrenos
{
    class Program
    {
        struct Terrenos
        {
            public string titular;
            public string ubicacion;
            public int superficie;
            public int dni;
            public string tipo;
        }
        /////////////////////////////////////////////////////// AGREGAR//////////////////////////////////////////////
        static void agregar(List<Terrenos> terrenos, string titular,int dni, string ubicacion, int superficie, string tipo)
        {
                Terrenos terreno = new Terrenos
                {
                    titular = titular,
                    dni=dni,
                    ubicacion = ubicacion,
                    superficie = superficie,
                    tipo = tipo,

                };

                terrenos.Add(terreno);
        }

        //////////////////////////////////////////////////////////////////////// LISTAR ////////////////////////////////
        static void Listar(List<Terrenos> terrenos)
        {
            Console.WriteLine("TERRENOS CARGADOS\n");
            foreach (var i in terrenos)
            {
                Console.WriteLine("Titular " + i.titular + "Ubicacion " + i.ubicacion + " Superficie " + i.superficie + " Tipo " + i.tipo);


            }
        }

        //////////////////////////////////////////////////////////////////////// BORRAR ////////////////////////////////
        static void eliminar(List<Terrenos> terrenos, string search)
        {
            int index;
            index = terrenos.FindIndex(x => x.titular == search);
            terrenos.Remove(terrenos[index]);

        }
        //////////////////////////////////////////////////////////////////////// BUSCAR ////////////////////////////////
        static void buscar(List<Terrenos> terrenos, string search)
        {
            int index;
            index = terrenos.FindIndex(x => x.titular == search);
           
                Console.WriteLine($"Titular {terrenos[index].titular} " +
                              $"ubicacion {terrenos[index].ubicacion} " +
                              $"superficie {terrenos[index].superficie}");
            

        }


        static void Main(string[] args)
        {


            List<Terrenos> terrenos = new List<Terrenos>();
            string titular, ubicacion, localizacion,search ;
            int dni,sup;

            Console.WriteLine("INMOBILIARIA \n");
            Console.WriteLine("Elija una opcion\n");
            Console.WriteLine("1.Agregar\n  2.Listar\n  3.Buscar\n 4.Eliminar\n  0.Salir \n");
            var opcion = Console.ReadLine();
            while (Convert.ToInt32(opcion)!=0)
            {
                switch(Convert.ToInt32(opcion))
                {
                    case 1:////AGREGAR
                        {
                            Console.WriteLine("Nombre del titular :");
                            titular = Console.ReadLine();
                            Console.WriteLine("DNI:");
                            dni= Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ubicacion :");
                            ubicacion = Console.ReadLine();
                            Console.WriteLine("Superficie:");
                            sup = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Localizacion :");
                            localizacion = Console.ReadLine();
                            agregar(terrenos, titular,dni, ubicacion, sup, localizacion);
                            break;
                        }
                    

                    case 2:////LISTAR
                        {
                            Console.WriteLine("Lista de terrenos :\n");
                            Listar(terrenos);

                            break;
                        }
                        
                    case 3:////BUSCAR
                        {
                            Console.WriteLine("Ingrese el nombre del titular");
                            search =Console.ReadLine();
                            buscar(terrenos, search);
                            break;
                        }
                        
                    //case 4:////ELIMINAR
                    //    {
                    //        Console.WriteLine("Indique el nombre del titular\n");
                    //        search = Console.ReadLine();
                    //        eliminar(terrenos,search);

                    //        break;
                    //    }

                }
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Elija una opcion\n");
                Console.WriteLine("1.Agregar\n  2.Listar\n  3.Buscar\n 4.Eliminar\n  0.Salir \n");
                opcion = Console.ReadLine();
            }


        }
    }
}

