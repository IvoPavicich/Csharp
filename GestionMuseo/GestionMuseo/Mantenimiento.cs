using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMuseo
{
    public class Mantenimiento
    {
        private string persona;
        private string tarea_realizada;
        private string fecha_inicio;
        private decimal hora;
        private string duracion;
        ///////contstructor/////////////////////////////////////////////////////////////////////
        public string Persona { get => persona; set => persona = value; }
        public string Tarea_realizada { get => tarea_realizada; set => tarea_realizada = value; }
        public string Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public decimal Hora { get => hora; set => hora = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        //////////////////////////////////////////////////////////////////////////////////////////
       
    }
}
