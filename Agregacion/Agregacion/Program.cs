using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Museo newMuseo = new Museo();
            Cuadro obraArte = new Cuadro();
            Mantenimiento mantenimiento = new Mantenimiento("roberto gomez", "limpieza", new DateTime( 12 / 12 / 2020),31);
            Mantenimiento mantenimiento2 = new Mantenimiento("robert sanchez", "restauracion", new DateTime(12 / 12 / 2021), 365);
            obraArte.titulo="Gioconda";
            obraArte.tipo = "Surrealista";
            obraArte.autor = "Miguel Angel";
            obraArte.modelo = "marta sanchez";
            obraArte.año = 1700;
            obraArte.pintura = "oleo";
            
           
            //obraArte.MostraObra();
            obraArte.AgregaMant(mantenimiento);
            obraArte.AgregaMant(mantenimiento2);
            obraArte.MostraObra();


            //Esculturas oEsculturas = new  Esculturas();
            //Mantenimiento man = new Mantenimiento("pablo perez", "restauraion", new DateTime(10 / 12 / 2019), 365);
            //oEsculturas.titulo = "David";
            //oEsculturas.tipo = "Impresionismo";
            //oEsculturas.autor = "Miguel Angel";
            //oEsculturas.modelo = "Daavid";
            //oEsculturas.año = 1500;
            //oEsculturas.material = "yeso";


            ////obraArte.MostraObra();
            //oEsculturas.AgregaMant(man);
            //oEsculturas.MostraObra();

            newMuseo.lista_ObraArte.Add(obraArte);
            //newMuseo.lista_ObraArte.Add(oEsculturas);
            Console.Clear();
            for (int i=0;i< newMuseo.lista_ObraArte.Count; i++)
            {
                Console.WriteLine("=================================================================\n");
                Console.WriteLine($"Código {i + 1}  ");
                newMuseo.lista_ObraArte[i].MostraObra();
            }







            Console.ReadKey();






        }
    }
}
