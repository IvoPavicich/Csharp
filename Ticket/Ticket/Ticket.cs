using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    public class Ticket
    {
        private int tipo { get; set; }
        private int cantidad { get; set; }
        private string color { get; set; }
        private double tamaño { get; set; }
       
        ///////////////METODOS get y set///////////////////////////////////////
        public int getTipo()
        {
            return tipo;

        }
        public void setTipo(int tipo)
        {

            if (tipo == 1 || tipo == 2 || tipo == 3) this.tipo = tipo;
            else this.tipo = 1;


        }
        public string getColor()
        {
            return color;

        }
        public void setColor(string color)
        {

            this.color = color;


        }
        public double getTamaño()
        {
            return tamaño;

        }
        public void setTamaño(double tamaño)
        {

            this.tamaño = tamaño;


        }

        
        public double Precio()
        {
            switch(tipo)
            {
                case 1:return 5.00;
                    
                case 2:
                    return  8.00;
                    
                case 3:
                    return  10.00;
                default:
                    return 0;
                    
            }

        }
        public int getCantidad()
        {
            return cantidad;

        }
        public void setCantidad(int cantidad)
        {

            this.cantidad = cantidad;


        }

        public double totalPagar()
        {
               
            return Precio() * cantidad;

        }


    }
}
