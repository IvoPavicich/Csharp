using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda2021
{
    public class Camara
    {
        public string marca;
        public string modelo;
        public string soporte;
        public string tipo;
        public string dir_reparacion;
        public Camara(string marca, string modelo, string soporte, string tipo, string dir_reparacion)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.soporte = soporte;
            this.dir_reparacion = dir_reparacion;
            this.tipo = tipo;
           
        }

        public virtual void MostrarCamaras()
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
