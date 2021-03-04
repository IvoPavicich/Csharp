using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNomina
{
    public class Empleado
    {
        private string nombre;
        private string identificacion;
        private decimal asignacionDia;
        
        //contructores para cada atributo
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public decimal AsignacionDia { get; set; }

    }
}
