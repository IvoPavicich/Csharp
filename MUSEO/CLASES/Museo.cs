using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    class Museo
    {
        public List<ObraArte> listadeObras;///SE DEFINE UNA LISTA DE OBRAS DE ARTE
        
        public Museo()///METODO
        {
            listadeObras = new List<ObraArte>();
            

        }

        internal ObraArte ObraArte
        {
            get => default(ObraArte);
            set
            {
            }
        }
    }
}
