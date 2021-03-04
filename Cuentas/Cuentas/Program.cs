using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
    public class Cuenta
    {
        public string Titular;
        public double Cantidad;
        public double interes = 1.2;

       

        public Cuenta(string titular, double cantidad,double interes)
        {
            Titular = titular;
            Cantidad = cantidad;
            interes = 1.2;
        }
        
        static double Ingresar()
        {
            double ingreso;
            double cantidad=0;
            double interes = 1.2;
            double inte = 0;
            Console.WriteLine($"Por favor esciba el monto a ingresar en la cuenta = \n");
            ingreso = Convert.ToDouble(Console.ReadLine());

            if (ingreso >= 0)
            {
                
                cantidad +=cantidad + ((cantidad + ingreso)* interes/100);

            } else if (ingreso<0)
            {
                cantidad = cantidad + 0;
            }
           

            return cantidad;
        }

        static double Retirar()
        {
            double egreso;
            double cantidad = 0;
            Console.WriteLine("Por favor esciba el monto que desea retirar de su cuenta = \n");
            egreso = Convert.ToDouble(Console.ReadLine());

            if ((egreso-cantidad) < 0)
            {
               cantidad = 0;

            }
            else if ((egreso - cantidad) >= 0)
            {
                cantidad = egreso - cantidad;
            }


            return cantidad;
        }

        static void Main(string[] args)

        {
            string titular;
            double nuevo;
            double cantidad;
            
            int opcion;
            Console.WriteLine("ingrese el nombre del titular");
            titular = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Cantidad de dinero en la cuenta $");
            cantidad = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("titular de la cuenta :" + titular);
            Console.WriteLine($"El Saldo en su cuenta es = {cantidad}\n" );
            Console.WriteLine("##### PRESIONE UNA TECLA PARA CONTINUAR ########\n");
            Console.ReadKey();

            do
            {
                Console.WriteLine("POR FAVOR SELECCIONE LA OPCION QUE DESEA REALIZAR");
                Console.WriteLine("  ");
                Console.WriteLine("1-Realizar un ingreso a mi cuenta");
                Console.WriteLine("2-Realizar una extraccion de mi cuenta");
                Console.WriteLine("3-SALIR");
                Console.WriteLine("  ");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {

                    Console.Clear();
                    cantidad = cantidad + Ingresar();
                    Console.Clear();
                    Console.WriteLine($"titular de la cuenta :  {titular}\n");
                    Console.WriteLine($"El Saldo anterior en su cuenta es = $ {cantidad}\n");
                    Console.WriteLine($"El Saldo nuevo en su cuenta es = $ {cantidad}\n");
                    Console.WriteLine();
                    Console.WriteLine("##### PRESIONE UNA TECLA PARA CONTINUAR ########\n");
                    Console.ReadKey();
                }
                else if (opcion == 2)
                {
                    Console.Clear();
                    cantidad = cantidad-Retirar();
                    if (cantidad<0) { cantidad = 0; }
                    Console.Clear();
                    Console.WriteLine($"titular de la cuenta :  {titular}\n");
                    Console.WriteLine($"El Saldo anterior en su cuenta es = $ {cantidad}\n");
                    Console.WriteLine($"El Saldo nuevo en su cuenta es = $ {cantidad}\n");
                    Console.WriteLine();
                    Console.WriteLine("##### PRESIONE UNA TECLA PARA CONTINUAR ########\n");
                    Console.ReadKey();


                }







            } while (opcion !=3);






        }
    }
}
