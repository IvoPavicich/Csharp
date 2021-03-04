using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class VehiculoCarrera : Vehiculo
    {
        double Hp { get; set; }
        public VehiculoCarrera(double hp,string marca,string modelo,string patente): base(marca,modelo,patente)
        {

            this.Hp = hp;

        }

        public override String mostrarDatos()
        {
            return "Patente : " + patente + "\nMarca :" + marca + "\nModelo :" + modelo + "\nHp :"+ Hp +"\n";


        }

    }
}
