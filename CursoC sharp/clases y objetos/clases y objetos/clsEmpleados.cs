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
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }
        public string Nombre;
        public decimal SueldoDiario;
        public int Edad;

        /////metodo///////////
        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
            
        }





    }
}
