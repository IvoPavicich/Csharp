using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{

    /////HERENCIA
    public  class clsClientesdeVentas : clsClientes///ClientesdeVentas Hereda de Clientes
    {
        private string _RFC;
        private string _Direccion;
        private string _Provincia;
        private string _Municipio;
        private bool _EsCredito;

        public string RFC { get => _RFC; set => _RFC = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        
        public bool EsCredito { get => _EsCredito; set => _EsCredito = value; }
        public string Provincia { get => _Provincia; set => _Provincia = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
    }
}
