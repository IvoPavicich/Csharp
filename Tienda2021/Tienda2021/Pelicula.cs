using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2021
{
    public class Pelicula
    {
        public string marca;
        public string nombre;
        public string sensibilidad;
        public string formato;

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
