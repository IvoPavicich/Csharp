using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrenosNuvos
{
    class Program
    {

        public struct Terreno
        {
            public String titular;
            public double superficie;
            public String tipo;
            public String ubicacion;
            //public String estado;
            public double valor;


        };

        //Agregar
        static void addTerreno(List<Terreno> terrenos, String titular, double superficie, String tipo, String ubicacion)
        {
            var terreno = new Terreno //nuevo nodo
            {
                titular = titular,
                superficie = superficie,
                tipo = tipo,
                ubicacion = ubicacion,
                //estado=estado,
               



            };

            terrenos.Add(terreno); //agrego el nuevo nodo a la lista
        }

        static void Valuar(List<Terreno> terrenos)
        {
            double[] valor = new double[terrenos.Count];
            for (int i = 0; i < terrenos.Count; i++)
            {


                if (terrenos[i].tipo == "urbano")
                {
                    valor[i] = terrenos[i].superficie * 1000;
                }
                else if (terrenos[i].tipo == "rural")
                {
                    valor[i] = terrenos[i].superficie * 90000;
                }

                //Console.WriteLine("SU Valor ES: " + valor[i]);
                Console.WriteLine("/#######################################/n");


            }


        }

            //Mostrar/Listar Terrenos
            static void showTerrenos(List<Terreno> terrenos,double [] valor)
            {
                double[] valor2 = new double[valor.Length];
                for (int i = 0; i < terrenos.Count; i++)
                {
               
                    Console.WriteLine(" Nombre Titular: " + terrenos[i].titular);
                    Console.WriteLine(" Nombre superficie: " + terrenos[i].superficie);
                    Console.WriteLine(" Nombre Tipo: " + terrenos[i].tipo);
                    Console.WriteLine(" Nombre ubicacion: " + terrenos[i].ubicacion);
                    valor2[i] = valor[i];


                    Console.WriteLine("El valor es" + valor2[i]);

                }


                //Console.WriteLine("TERRENOS REGISTRADOS ");
                //foreach (var i in terrenos)
                //{
                //    Console.WriteLine(" Nombre Titular: " + i.titular +  "\n Superficie: " + i.superficie + "\n Tipo: " + i.tipo + "\n Ubicacion: " + i.ubicacion );
                //}

            }


        //Eliminar
        static void deleteTerreno(List<Terreno> terrenos, String search)
        {
            int index;
            index = terrenos.FindIndex(x => x.titular == search); //busca y guarda el indice del nodo a borrar 

            terrenos.Remove(terrenos[index]); //elimina el nodo
        }

        //Buscar
        static void searchTerreno(List<Terreno> terrenos, String search)
        {
            int index;
            index = terrenos.FindIndex(x => x.titular == search);//busca y guarda el indice del nodo busca
            Console.WriteLine(terrenos[index].titular + terrenos[index].superficie + terrenos[index].tipo + terrenos[index].ubicacion); // muestra
            
               

        }

            static double[] valor;
            static void Main(string[] args)
            {
                List<Terreno> terrenos = new List<Terreno>();
                double[] valor = new double[terrenos.Count];
                String titular, ubicacion, tipo, search;
                String estado;
                int sup;
                
                Console.WriteLine("INMOBILIARIA\n");
                Console.WriteLine("Elige una opcion\n");
                Console.WriteLine("1. Agregar terreno\n 2. Eliminar terreno\n 3. Buscar terreno\n 4. Listar terrenos\n 5. Valuar\n 0. Para salir");

                var opcion = Console.ReadLine(); //guarda la opcion ingresada para determinar el camino que tomara la ejecucion

                while (Convert.ToInt32(opcion) != 0)
                {
                    switch (Convert.ToInt32(opcion))
                    {
                        case 1: //Agregar
                            {
                                Console.WriteLine("Nombre titular: ");
                                titular = Console.ReadLine();
                                Console.WriteLine("Ubicacion: ");
                                ubicacion = Console.ReadLine();
                                Console.WriteLine("Superficie: ");
                                sup = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Tipo: ");
                                tipo = Console.ReadLine();

                                addTerreno(terrenos, titular,sup, tipo,ubicacion);
                                break;
                            }
                        case 2://Eliminar
                            {
                                Console.WriteLine("Indique el nombre del titular: \n");
                                search = Console.ReadLine();

                                deleteTerreno(terrenos, search);
                                break;
                            }



                        case 3: //Buscar
                            {
                                Console.WriteLine("Indique el nombre del titular: \n");
                                search = Console.ReadLine();

                                searchTerreno(terrenos, search);
                                break;
                            }
                        case 4: //Listar
                            {
                                Console.WriteLine("Listado de terrenos: \n");
                                showTerrenos(terrenos,valor);
                                break;
                            }
                    case 5: //Valuar
                        {


                            Console.WriteLine("Listado de terrenos: \n");

                            Valuar(terrenos);




                            break;
                        }



                    default:
                            {
                                Console.WriteLine("Reingresar opcion");
                                break;
                            }
                    }
                    Console.WriteLine("*****************************************************************\n");
                    Console.WriteLine("Elige una opcion\n");
                    Console.WriteLine("1. Agregar terreno\n 2. Eliminar terreno\n 3. Buscar terreno\n 4. Listar terrenos\n 5. Valuar\n 0. Para salir");

                    opcion = Console.ReadLine();
                }
            }
    }
}

 

