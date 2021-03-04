using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    class Escultura : ObraArte
    {
        public string material;
        public Escultura(string title, string type, int age, string autorObra, string model, string material) : base(title, type, age, autorObra, model)
        {
           this.material = material;
        }
        //////////Metodos heredados y Polimorfimo/////////////////////////////////////
        public override void AgregarMantenimiento(Mantenimiento mante)
        {
            listMant.Add(mante);
        }

        public override void MostrarObra()
        {

            Console.WriteLine(" ");
            Console.WriteLine("OBRA DE ARTE ");
            Console.WriteLine("* Titulo: " + title);
            Console.WriteLine("* Tipo :" + type);
            Console.WriteLine("* Autor de la obra :" + autorObra);
            Console.WriteLine("* Año de creacion :" + age);
            Console.WriteLine("* Modelo:" + model);
            Console.WriteLine("* Tipo de material:" + material);
            Console.WriteLine(" ");


        }

    }
}
