using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Fotografica
{
    public class Memoria
    {
        public string marca;
        public string tipo;
        public int capacidad;
        public double vel;

        public Memoria(string marca, string tipo, int capacidad, double vel)
        {

            this.marca = marca;
            this.tipo = tipo;
            this.capacidad = capacidad;
            this.vel = vel;

        }

        public void MostrarMemoria()
        {
            Console.WriteLine("MEMORIA COMPATIBLES\n");
            Console.WriteLine($"Marca : {marca}\n");
            Console.WriteLine($"Tipo: {tipo}\n");
            Console.WriteLine($"Capacidad : {capacidad}\n");
            Console.WriteLine($"Velocidad de transferencia Gbps : {vel}\n");

        }





    }
}
