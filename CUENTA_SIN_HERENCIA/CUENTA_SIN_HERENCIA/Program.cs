using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUENTA_SIN_HERENCIA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Corriente c = new Corriente("Ivo", 1);
            //Console.WriteLine("***Cuenta Corriente Creada Exitosamente***\n");
            //c.Actualizar();
            //Console.WriteLine(c.ToString());
            //c.Ingresar(400);
            //c.Actualizar();
            //Console.WriteLine(c.ToString());
            //c.Ingresar(100);
            //c.Actualizar();
            //Console.WriteLine(c.ToString());

            ////c.Retirar(50);
            ////c.Actualizar();
            ////Console.WriteLine(c.ToString());
            //c.Retirar(5000);
            //c.Limite(20000);

            //c.Retirar(5000);
            //c.Actualizar();
            //Console.WriteLine(c.ToString());

            //c.Retirar(1000);
            //c.Actualizar();
            //Console.WriteLine(c.ToString());





            /*********************************Cuenta Ahorro********************************************/
            Ahorro a = new Ahorro("Ivo", 1);
            Console.WriteLine("***Cuenta Ahorro Creada Exitosamente***\n");
            a.Actualizar();
            Console.WriteLine(a.ToString());
            a.Ingresar(400);
            a.Actualizar();
            Console.WriteLine(a.ToString());


            //a.cambiarInteres(2.5);
            //a.Actualizar();
            //Console.WriteLine(a.ToString());

            //a.Retirar(300);
            //a.Actualizar();
            //Console.WriteLine(a.ToString());
            a.Retirar(101);
            a.Actualizar();
            Console.WriteLine(a.ToString());



            Console.ReadKey();



        }
    }
}
