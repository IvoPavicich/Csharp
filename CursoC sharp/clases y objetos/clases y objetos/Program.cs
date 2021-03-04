using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_y_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado;
            empleado = new clsEmpleados();///"new" para instanciar la clase y despues se llama al constructor clsEmpleado
            empleado.Nombre = "PABLO EMILIO";
            empleado.Edad = 25;
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalculaSalario(30);
            Console.WriteLine("El salario mensual del empleado"+ empleado.Nombre);
            Console.WriteLine("es" + total.ToString("C"));//valor em formato moneda $
            Console.ReadKey();
        }
    }
}
