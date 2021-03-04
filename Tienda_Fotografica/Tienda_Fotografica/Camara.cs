using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Fotografica
{
    class Camara
    {
        public string marca;
        public string modelo;
        public string soporte;
        public string tipo;
        public string dir_reparacion;
        public List<Item> list_Items;
        public List<Pelicula> peliculas;
        public List<Memoria> memorias;
        //////////// CONSTRUCTOR /////////////////////////////////////////////////////////////////////////
        public Camara(string marca,string modelo, string soporte,string tipo, string dir_reparacion)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.soporte = soporte;
            this.dir_reparacion = dir_reparacion;
            this.tipo = tipo;
            list_Items = new List<Item>();
            peliculas = new List<Pelicula>();
            memorias = new List<Memoria>();
        }
        /////////////////// METODOS //////////////////////////////////////////////////////////////

        public virtual void AgregarPelicula(Pelicula peli)
        {
            peliculas.Add(peli);
        }
        public virtual void AgregarMemoria(Memoria memo)
        {
            memorias.Add(memo);
        }


        public virtual void AgregarItem(Item item)
        {
            list_Items.Add(item);
        }

        public virtual void  MostrarCamaras()
        {

            Console.WriteLine("LISTADO DE CAMARAS\n");
            Console.WriteLine($"MARCA : {marca}\n");
            Console.WriteLine($"MODELO : {modelo}\n");
            Console.WriteLine($"SOPORTE : {soporte}\n");
            Console.WriteLine($"TIPO DE CAMARA : {tipo}\n");
            Console.WriteLine($"DIRECCON SERVICIO DE REPARACION {dir_reparacion}\n");
           
        }

    }
}
