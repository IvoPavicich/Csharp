using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    class ObraArte
    {

        public string title;
        public string type;
        public int age;
        public string autorObra;
        public string model;
        
        


        public List<Mantenimiento> listMant;
        ////////////CONSTRUCTOR/////////////////////////////////////////////////////////////////////
        public ObraArte(string title, string type, int age, string autorObra, string model)
        {
            
                this.title = title;
                this.type = type;
                this.age = age;
                this.autorObra = autorObra;
                this.model = model;
               
                

               listMant =new List<Mantenimiento>();
        }

        public Mantenimiento Mantenimiento
        {
            get => default(Mantenimiento);
            set
            {
            }
        }




        //////////////////METODOs HEREDADOS Y Polimorfismo///////////////////////////////////////////////

        public virtual void AgregarMantenimiento(Mantenimiento mante)
        {
            listMant.Add(mante);
        }

        public virtual void MostrarObra()
        {
             
                Console.WriteLine(" ");
                Console.WriteLine("OBRA DE ARTE ");
                Console.WriteLine("* Titulo: " + title);
                Console.WriteLine("* Tipo :" + type);
                Console.WriteLine("* Autor de la obra :" + autorObra);
                Console.WriteLine("* Año de creacion :" + age);
                Console.WriteLine("* Modelo:" + model);
                Console.WriteLine(" ");
           

        }

    }
}
