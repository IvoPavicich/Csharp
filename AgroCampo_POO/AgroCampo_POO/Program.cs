using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCampo_POO
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double superficie=0;
            string tipo_cultivo="";
            double gastos=0;
            double cosecha=0;
            double precio_m = 0;
            double precio_s = 0;
            double ingreso=0;
            double ib=0;
            double gtotal = 0;
            double itotal = 0;
            double ibtotal = 0;
            int nLote = 0;
            List<Lote> listaLotes = new List<Lote>();
            ////////////////////////////////////////////////Ingreso de Datos///////////////////////////////////////////////////////
            Console.WriteLine("Ingrese lotes sembrados");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                
                nLote = i+ 1;
                Console.WriteLine($"LOTE N° : {nLote}");
                Console.WriteLine("La superficie sembrada :");
                superficie = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gastos : ");
                gastos = Convert.ToDouble(Console.ReadLine());
                gtotal = gtotal + gastos;
                Console.WriteLine("Cantidad de toneladas cosechadas por hectarea : ");
                cosecha= Convert.ToDouble(Console.ReadLine());
               
                Console.WriteLine("Tipo de Cultivo : ");
                tipo_cultivo = Console.ReadLine();
                if (tipo_cultivo == "maiz")
                {
                    Console.WriteLine("Precio de venta por tonelada : ");
                    precio_m = Convert.ToDouble(Console.ReadLine());
                    
                    LoteMaiz maiz = new LoteMaiz(nLote=i+1,superficie, tipo_cultivo, gastos, cosecha, precio_m,ingreso,ib);
                   
                    listaLotes.Add(maiz);

                } else if (tipo_cultivo == "soja")
                {
                    Console.WriteLine("Precio de venta por tonelada : ");
                    precio_s = Convert.ToDouble(Console.ReadLine());
                    
                    LoteSoja soja = new LoteSoja(nLote=i+1,superficie, tipo_cultivo, gastos, cosecha, precio_s, ingreso, ib);
                    
                    listaLotes.Add(soja);
                }


                itotal = itotal + listaLotes[i].ingreso;
                ibtotal = ibtotal + listaLotes[i].ib;



            }



            //////////////////////////////////Mostrar///////////////////////////////////////////////////////////////////////////////
            Console.Clear();
            foreach (var misLotes in listaLotes)
            {
                Console.WriteLine(misLotes.mostrarDatos());



            }


            Console.WriteLine($"El Gasto total es : {gtotal}");
            Console.WriteLine($"El Ingreso total es : {itotal}");
            Console.WriteLine($"El Ingreso Bruto total es : {ibtotal}");
            Console.ReadKey();
         }

    }
}

