using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    public class Cuadro:ObraArte
    {
        public string pintura;
        public Cuadro() { }
        public Cuadro(string titulo, string tipo, string autor, string modelo, int año,Mantenimiento mante,  string pintura) : base(titulo,tipo, autor, modelo,año,mante)
        {
            this.pintura = pintura;

        }

        public override void AgregaMant(Mantenimiento man)
        {
            if (mante== null)
            {
                mante=man;
            }
        }


        public override void MostraObra()
        {
           


                if (mante!=null)


                {
                    Console.WriteLine($"Titulo de la obra {titulo} \n");
                    Console.WriteLine($"Tipo de arte => 'Surrealista'-'Renacetista'-'Impresionista'  {tipo} \n");
                    Console.WriteLine($"Creador de la obra {autor} \n");
                    Console.WriteLine($"Modelo de la obra {modelo} \n");
                    Console.WriteLine($"Año de creacion {año} \n");

                    mante.MostraMantenimiento();
                }



                else
                {
                    Console.WriteLine($"Titulo de la obra {titulo} \n");
                    Console.WriteLine($"Tipo de arte => 'Surrealista'-'Renacetista'-'Impresionista' >>>> {tipo} \n");
                    Console.WriteLine($"Creador de la obra {autor} \n");
                    Console.WriteLine($"Modelo de la obra {modelo} \n");
                    Console.WriteLine($"Año de creacion {año} \n");
                }


            



        }
    }
}
