using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_herencia
{
    public class Repartidor:Empleado
    {
        public string zona{ get; set; }
       
        public Repartidor() { }
        public Repartidor(string nombre, int edad, double salario, int plus,string zona,string chofer) : base(nombre, edad, salario,plus)
        {
            
            this.zona = zona;
        }

       






        public override double Plus()
        {
            if (edad < 35 && zona.Equals( "zona 3")) salario = salario + plus;
            return salario;
        }



    }
}
