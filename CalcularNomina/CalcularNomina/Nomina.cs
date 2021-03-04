using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNomina
{
    public class Nomina
    {
        private int diasTrabajados;
        //constructor
        public int DiasTrabajados { get; set; }
        //metodo para calcular sueldo
        public decimal CalcularNomina(int diasTrab, decimal valorDia)
        {
            decimal totalSalario = diasTrab * valorDia;
            return totalSalario;
        }
    }
}
