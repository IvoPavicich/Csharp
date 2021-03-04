using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{

    class Cuadro : ObraArte///////CUADRO HEREDA DE LA CLASE PADRE "ObradeArte"
    {
        public string pintura;
        public Cuadro(string title, string type, int age, string autorObra, string model, string pintura) : base(title, type, age, autorObra, model)
        {
            this.pintura = pintura;
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
            Console.WriteLine("* Tipo de Pintura:" + pintura);


            Console.WriteLine(" ");



        }

    }
}
