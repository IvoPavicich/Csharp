using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Fotografica
{
    class Pelicula
    {
        public string marca { get; set; }
        public string nombre { get; set; }
        public string sensibilidad { get; set; }
        public string formato { get; set; }

        public Pelicula(string marca, string nombre, string sensibilidad, string formato)
        {
            this.marca = marca;
            this.nombre = nombre;
            this.sensibilidad = sensibilidad;
            this.formato = formato;

        }

        public void MostrarPelicula()
        {
            Console.WriteLine("PELICULAS COMPATIBLES\n");
            Console.WriteLine($"Marca : {marca}\n");
            Console.WriteLine($"Nombre : {nombre}\n");
            Console.WriteLine($"Sensibilidad : {sensibilidad}\n");
            Console.WriteLine($"Formato : {formato}\n");


        }
        




    }
}
