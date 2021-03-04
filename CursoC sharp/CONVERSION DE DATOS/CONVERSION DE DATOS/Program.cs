using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERSION_DE_DATOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =12;
            decimal x = 10.1m;
            bool bandera = false;
            string cadena = string.Empty;//inicia cadena vacia
            DateTime fecha=DateTime.MinValue;
            //////////////CONVERSION////////////////////////////////////
            //x = i;  conversion directa o implicita de entero a decimal(al reves no es posible)
            //i=(int)x; conversion explicita a traves de un cast
            //i = Convert.ToInt32(x);conversion explicita a traves convert.To.....(int,decimal,string etc)






            Console.WriteLine("EL VALOR DE I ES: {0}",i);
            Console.WriteLine("EL VALOR DE x ES: {0:C}",x);
            Console.WriteLine("EL VALOR DE bandera ES:"+bandera.ToString());
            Console.WriteLine("EL VALOR DE cadena ES:}"+cadena);
            Console.WriteLine("EL VALOR DE la fecha ES:"+fecha.ToShortDateString());
            Console.ReadKey();

        }
    }
}
