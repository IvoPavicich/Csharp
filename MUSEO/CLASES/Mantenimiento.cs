using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Mantenimiento
    {
        public string incharge;
        public string tasktype;
        public DateTime date;
        public int durationMant;
        //////////////////////////////////////CONSTRUCTOR/////////////////////////////
        public Mantenimiento(string incharge, string tasktype, DateTime date, int durationMant)

        {
            this.incharge = incharge;
            this.tasktype = tasktype;
            this.date = date;
            this.durationMant = durationMant;

        }

        ////////////////////////////////////METODO//////////////////////////////////
        public void MostrarMantenimiento()
        {
            Console.WriteLine("#########################");
            Console.WriteLine(" ");
            Console.WriteLine("MANTENIMIENTO REALIZADO");
            Console.WriteLine("* Encargado:" + incharge);
            Console.WriteLine("* Tipo de tare hecha:" + tasktype);
            Console.WriteLine("* Fecha de inicio:" + date);
            Console.WriteLine($"* Duracion de la tarea:  {durationMant} dias");
            Console.WriteLine(" ");


        }


    }
}
