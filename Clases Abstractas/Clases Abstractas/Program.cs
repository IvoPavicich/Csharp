using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas///son las que no se pueden instanciar se las usa como superclse en una jerarquia
{
    class Program
    {
        static void Main(string[] args)
        {

            clsClientesconContacto cliente = new clsClientesconContacto(0,"ROBERTO",
                                                                "011",
                                                                 "HEHM",
                                                                 1,"Marcos perez",
                                                                 "22222", "11111 ", "@gmail.com",
                                                                 "Av sfd","11","2224",
                                                                 "la cueva de jaguar","quitilipi",
                                                                 "Chaco","3530");


            ///se instancia la clase impresion
            clsImpresion Impresion;
            Impresion = new clsImpresion();
            Impresion.ImprimeCliente(cliente);

        }
    }
}
