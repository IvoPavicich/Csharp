using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    public class ObraArte
    {
        public string titulo;
        public string tipo;
        public string autor;
        public string modelo;
        public int año;
        public  Mantenimiento mante=null ;

        public ObraArte() { }
        public ObraArte(string titulo, string tipo,string autor,string modelo,int año,Mantenimiento mante)
        {
            this.titulo = titulo;
            this.tipo = tipo;
            this.autor = autor;
            this.año = año;
            
        }

        public virtual void AgregaMant(Mantenimiento man)
        {
            if (mante==null)
            {
                mante=man;
            }
        }


        public virtual void MostraObra()
        {
            

                if (mante != null)

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
