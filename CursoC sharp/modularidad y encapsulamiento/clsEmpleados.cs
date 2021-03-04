using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_y_objetos
{
    public class clsEmpleados///public o private alcance de la clase
    {
        ///constructor inicializa los valores///////
        public clsEmpleados()///siempre lleva = nombre de la clase
        {
            Nombre1 = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }
        private string Nombre;
        public decimal SueldoDiario { get; set; }
        public int Edad { get; set; }
       
        //encapsulamiento poniendo variable privada
        public string Nombre1
        { get => Nombre;
          set => Nombre = value;
        }

        /////metodo///////////
        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
            
        }

    }
}
