using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Fotografica
{
    class Digital : Camara
    {
        public string memoria;
        
        public Digital(string marca, string modelo, string soporte, string tipo, string dir_reparacion, string memoria) : base(marca, modelo, soporte, tipo, dir_reparacion)
        {
            this.memoria = memoria;

        }
        public override void AgregarMemoria(Memoria memo)
        {
            memorias.Add(memo);
        }
        public override void MostrarCamaras()
        {

            Console.WriteLine("LISTADO DE CAMARAS\n");
            Console.WriteLine($"MARCA : {marca}\n");
            Console.WriteLine($"MODELO : {modelo}\n");
            Console.WriteLine($"SOPORTE : {soporte}\n");
            Console.WriteLine($"TIPO DE CAMARA : {tipo}\n");
            Console.WriteLine($"DIRECCON SERVICIO DE REPARACION {dir_reparacion}\n");
            Console.WriteLine($"MEMORIA {memoria}\n");

        }



    }
}
