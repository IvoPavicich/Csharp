using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Fotografica
{
    class Item
    {
        public string referencia;
        

        public Item(string referencia)
        {
            this.referencia = referencia;
            
        }

        public void Mostrar_Item()
        {
            Console.WriteLine("ESTADO\n");
            Console.WriteLine($"Referencia : {referencia}\n");
            

        }
    }
}
