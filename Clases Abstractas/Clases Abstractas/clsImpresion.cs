using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public class clsImpresion
    {
        public void ImprimeCliente(clsAbsClientes clientes) 
        {

            Console.WriteLine(clientes.Clave + "  " + clientes.Nombre);
            Console.WriteLine(clientes.TipoRegimen);
            Console.WriteLine(clientes.RFC);
            Console.WriteLine(clientes.NombreContacto);
            Console.ReadKey();

        }
    }
}
