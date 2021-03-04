using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrenos_Modificados
{
    
    class Program
    {
        
        public struct Terrenos
        {
            public string titular;
            public string ubicacion;
            public int superficie;
            public string estado;
            public string tipo;

            public Terrenos(string titular,string ubicacion, string tipo, int superficie,  string estado)
            {
                this.titular = titular;
                this.ubicacion = ubicacion;
                this.tipo = tipo;
                this.superficie = superficie;
               
                this.estado = "en venta";
            }

            //public double Valor()
            //{
            //    double valor = 0;
            //    if (tipo == "urbano")
            //    {
            //        valor = superficie * 1000;

            //    }
            //    else if (tipo == "rural")
            //    {
            //        valor = superficie * 90000;

            //    }
            //    return valor;
            //}



        }
///////////////////////////////* AGREGAR*//////////////////////////////////////////////////////////////////
        static double[] valor;/*variable global*/

        static void Agregar(List<Terrenos> terrenos, string titular,  string ubicacion, string tipo, int superficie, string estado)
        {
            Terrenos terreno = new Terrenos
            {
                titular = titular,
                ubicacion = ubicacion,
                tipo = tipo,
                superficie = superficie,
               
                estado = estado,
               

            };

            terrenos.Add(terreno);
        }
/**********************************************************************************************************/

/////////////////////////////*BORRAR*///////////////////////////////////////////////////////////////////      
        public static void Eliminar(List<Terrenos> terrenos, string search)
        {
            int index;
            index = terrenos.FindIndex(x => x.titular == search);
            terrenos.Remove(terrenos[index]);

        }
/*******************************************************************************************************/

/////////////////////////////*VENDER*//////////////////////////////////////////////////////////////////
        static void Vender(List<Terrenos> terrenos, string search)
        {
            bool encontrado = false;
            int i = 0;
            Console.WriteLine(" ");
            string esta2 = "vendido";
            while (encontrado == false && i < terrenos.Count)
            {
                if (terrenos[i].titular == search)
                {
                    encontrado = true;
                    Terrenos terreno = terrenos[i];
                    terreno.estado = esta2;
                    terrenos[i] = terreno;
                    Console.WriteLine("TERRENO VENDIDO!!");
                }
                else
                {
                    i++;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine(" ");
                Console.WriteLine("El titular buscado no se encontro.");
            }
           
        }
/*****************************************************************************************/

/////////////////////////////////////*FUNCION VALUAR* ///////////////////////////////////////// 
        static double [] Valuar(List<Terrenos> terrenos)
        {
            valor = new double[terrenos.Count];
            for (int i = 0; i < terrenos.Count; i++)
            {
               
                if (terrenos[i].tipo=="rural")
                {
                    valor[i] = terrenos[i].superficie * 90000;

                }
                else if (terrenos[i].tipo == "urbano")
                {
                    valor[i] = terrenos[i].superficie * 1000;

                }

              
            }

            return valor;

        }

        /*****************************************************************************************/
        


        /////////////////////////////////////* LISTAR* /////////////////////////////////////////
        static void Listar(List<Terrenos> terrenos)
        {
            
            Console.WriteLine("TERRENOS CARGADOS\n");
            Console.WriteLine("\n"+
"%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% \n");
            for(int i=0; i< terrenos.Count;i++)
            {
                Console.WriteLine("Titular : \n" + terrenos[i].titular + "\n");
                Console.WriteLine("Ubicacion : \n" + terrenos[i].ubicacion + "\n");
                Console.WriteLine("Tipo: \n" + terrenos[i].tipo + "\n");
                if (terrenos[i].tipo == "rural")
                {
                    Console.WriteLine("Superficie en Hectareas : \n" + terrenos[i].superficie + "\n");
                }
                else if (terrenos[i].tipo == "urbano")
                {
                    Console.WriteLine("Superficie en mtrs cuadrados : \n" + terrenos[i].superficie + "\n");
                }

                Console.WriteLine("Estado : \n" + terrenos[i].estado + "\n");
                if (valor == null)
                {
                    Console.WriteLine($"Valor ${0}");
                }
                else { Console.WriteLine($"Valor ${valor[i]}"); }
                
                Console.WriteLine("\n" +
"%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% \n");

            }
        }
/*************************************************************************************/


//######################### PROGRAMA PRINCIPAL ########################################//
       
      
        static void Main(string[] args)
        {

            List<Terrenos> terrenos = new List<Terrenos>();
            //double[] valores = new double[terrenos.Count];
            string titular, ubicacion, search, tipo;
            string estado = "En Venta";
            int  sup;
            Console.WriteLine(" ------------ ");
            Console.WriteLine("|INMOBILIARIA|");
            Console.WriteLine(" ------------ \n");
            Console.WriteLine("Elija una opcion:\n");
            Console.WriteLine("=> 1.ABM\n"+
                              "=> 2.Valuar\n"+
                              "=> 3.Lista\n" +
                              "=> 4.Vender\n" +
                              "=> 0.Salir \n");
            var opcion = Console.ReadLine();
           
            while (Convert.ToInt32(opcion) != 0)
            {
                switch (Convert.ToInt32(opcion))
                {
                    case 1:////AGREGAR
                        {
                            int op;
                            Console.WriteLine(" 1-Agregar 2-Borrar 3- Modificar");
                            op = Convert.ToInt32(Console.ReadLine());
                            if (op == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Nombre del titular :");
                                titular = Console.ReadLine();
                                Console.WriteLine("Ubicacion :");
                                ubicacion = Console.ReadLine();
                                Console.WriteLine("Tipo :");
                                tipo = Console.ReadLine();
                                Console.WriteLine("Superficie:");
                                sup = Convert.ToInt32(Console.ReadLine());
                               
                                Console.WriteLine($"Estado : {estado}");

                                Agregar(terrenos, titular, ubicacion,tipo,sup, estado);

                            }
                            else if (op == 2)
                            {

                                Console.WriteLine("Ingrese el nombre del titular\n");
                                search = Console.ReadLine();
                                Eliminar(terrenos, search);

                            }
                            else if (op == 3)
                            {
                                bool encontrado = false;
                                int i = 0;
                                Console.WriteLine(" ");
                                Console.WriteLine("Ingrese el nombre del titular ");
                                search = Console.ReadLine();
                                while (encontrado == false && i < terrenos.Count)
                                {
                                    if (terrenos[i].titular == search)
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
                                    Console.WriteLine("Terreno no encontrado");
                                }
                                else
                                {  
                                    Console.WriteLine("Nombre del titular :");
                                    titular = Console.ReadLine();
                                    Console.WriteLine("Ubicacion :");
                                    ubicacion = Console.ReadLine();
                                    Console.WriteLine("Tipo :");
                                    tipo = Console.ReadLine();
                                    Console.WriteLine("Superficie:");
                                    sup = Convert.ToInt32(Console.ReadLine());
                                    
                                    Console.WriteLine($"Estado : {estado}");
                                    Terrenos terreno = new Terrenos(titular,ubicacion,tipo,sup,estado);
                                    terrenos.RemoveAt(i);
                                    terrenos.Insert(i,terreno);
                                        

                                }


                            }


                            break;
                        }

                    case 2:////VALUAR

                        
                        Valuar(terrenos);

                        break;

                    case 3:////LISTAR
                        {
                            
                            Listar(terrenos);

                            break;
                        }


                    case 4:////VENDER
                        {
                            Console.WriteLine("Ingrese el Nombre del titular");
                            search = Console.ReadLine();
                            Vender(terrenos, search);
                            break;
                        }
                   

                }
                Console.WriteLine("******************************************************************");

                
                Console.WriteLine("Elija una opcion\n");
                Console.WriteLine("=> 1.ABM\n" +
                                  "=> 2.Valuar\n" +
                                  "=> 3.Lista\n" +
                                  "=> 4.Vender\n" +
                                  "=> 0.Salir \n");

                opcion = Console.ReadLine();
                
            }


            
        }
    }
}
