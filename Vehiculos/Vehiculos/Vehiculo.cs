using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{

     public class Vehiculo
     {
        protected string marca { get; set; }
        protected string modelo { get; set; }
        protected string patente { get; set; }

        public Vehiculo(string marca,string modelo,string patente)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.patente = patente;
        }

        public virtual String mostrarDatos()
        {
            return "Patente : " + patente + "\nMarca :" + marca + "\nModelo :" + modelo + "\n\n";


        }




     }
}
