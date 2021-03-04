using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2021
{
    public class Analogica:Camara
    {
        public string pelicula;
        Pelicula peli;
        public List<Pelicula> peliculas;
        public Analogica(Pelicula pelicula ,string marca, string modelo, string soporte, string tipo, string dir_reparacion) : base(marca, modelo, soporte, tipo, dir_reparacion)
        {
            peli = pelicula;
            peliculas = new List<Pelicula>();

        }
        public void AgregarPelicula(Pelicula peli)
        {
            peliculas.Add(peli);
        }
        public override void MostrarCamaras()
        {

            Console.WriteLine("LISTADO DE CAMARAS\n");
            Console.WriteLine($"MARCA : {marca}\n");
            Console.WriteLine($"MODELO : {modelo}\n");
            Console.WriteLine($"SOPORTE : {soporte}\n");
            Console.WriteLine($"TIPO DE CAMARA : {tipo}\n");
            Console.WriteLine($"DIRECCON SERVICIO DE REPARACION {dir_reparacion}\n");
            Console.WriteLine($"Pelicula {pelicula}\n");

        }






    }
}
