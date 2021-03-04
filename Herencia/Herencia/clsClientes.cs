using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class clsClientes
    {
        
        private int idCliente;

        private string _Nombres;

        private string _Apellidos;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
    }
}
