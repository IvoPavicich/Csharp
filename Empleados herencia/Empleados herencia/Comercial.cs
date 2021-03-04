using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_herencia
{
    public class Comercial:Empleado
    {
        public double comision { get; set; }

        public Comercial() { }
        public Comercial(string nombre, int edad, double salario, int plus, double comision) : base(nombre, edad, salario, plus)
        {
            this.comision=comision;
        }


        public override double Plus()
        {
            if (edad > 20 && comision > 300)
                salario = salario +comision+ plus;

            return salario;
        }


    }
}
