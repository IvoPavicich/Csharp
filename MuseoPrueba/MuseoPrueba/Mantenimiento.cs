using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseoPrueba
{
    public class Mantenimiento
    {
        public string encargado;
        public string tipo_tarea;
        public DateTime fecha;
        public int duracion;


        public Mantenimiento(string encargado, string tipo_tarea, DateTime fecha, int duracion)
        {
            this.encargado = encargado;
            this.tipo_tarea = tipo_tarea;
            this.fecha = fecha;
            this.duracion = duracion;

        }

        public void MostraMantenimiento()
        {




            Console.WriteLine("##########-MANTENIMIENTO-############\n");
            Console.WriteLine($"Encargado {encargado} \n");
            Console.WriteLine($"Tarea realizada {tipo_tarea} \n");
            Console.WriteLine($"Inicio de la tarea {fecha} \n");
            Console.WriteLine($"Dias de duracion de tarea {duracion} \n");

        }

    }
}
