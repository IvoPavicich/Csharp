using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket venta = new Ticket();
            venta.setTipo(2);
            venta.setColor("verde");
            venta.setTamaño(2);
            venta.setCantidad(10);
            Console.WriteLine($"Precio por pelota : {venta.Precio()} y el total a pagar es $ {venta.totalPagar()}");
            Console.ReadKey();

        }
    }
}
