using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_herencia
{
    public abstract class Empleado
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public double salario { get; set; }
        public const int plus = 400;
        public Empleado() { }
        public Empleado(string nombre,int edad,double salario,int plus)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.salario = salario;
            
        }
        public abstract double Plus();




    }
}
