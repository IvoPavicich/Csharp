using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class VehiculoFamiliar:Vehiculo
    {
        int nPuertas { get; set; }
        public VehiculoFamiliar(int nPuertas,string marca,string modelo,string patente)
            :base(marca,modelo,patente)
        {
            this.nPuertas = nPuertas;


        }


        public override String mostrarDatos()
        {
            return "Patente : " + patente + "\nMarca :" + marca + "\nModelo :" + modelo + "\nNro Puertas :" + nPuertas + "\n";


        }


    }
}
