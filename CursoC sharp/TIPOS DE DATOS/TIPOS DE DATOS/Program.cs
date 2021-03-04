using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIPOS_DE_DATOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 0.0m;//m  modifcador o sino tengo que convertir a string//
            float f = 0.0f;
            double d=0.0D;
            bool bandera= false;
            string cadena = "HOLA MUNDO";//string.empty inicia la cadena vacia
            DateTime fecha = DateTime.MinValue;
            
            Console.WriteLine("valor de i es : {0}", i);
            Console.WriteLine("valor de x es : {0:C}", x);// C=$ simbolo de moneda
            Console.WriteLine("valor de i es : {0:F2}", f);//F2 CANTIDAD DE DECIMALES
            Console.WriteLine("valor de i es : {0:F2}",d);//   ""//
            Console.WriteLine("valor de la bandera es :" + bandera.ToString());
            Console.WriteLine("valor de la cadena es : "+ cadena);
            Console.WriteLine("valor de la  fecha es : "+fecha.ToShortDateString());
            Console.ReadKey();
        }
        
    }
}
