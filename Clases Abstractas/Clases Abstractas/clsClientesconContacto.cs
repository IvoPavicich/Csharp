using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    class clsClientesconContacto : clsClientesBase
    {
        /// CONSTRUCTORes
        public clsClientesconContacto()
        {
            _Direccion = new clsDirecciones();

        }

        public clsClientesconContacto(int pId,string pNombre,
                                      string pClave,string pRFC,int pTipoRegimen,string pNombreContacto,string pTelefono1,string pTelefono2,string pEmail,
                                      string pCalle,string pNumeroExterior,string pNumeroInterior,string pColonia,string pMunicipio,string pEstado,string pCP )

       {
            Id = pId;
            Nombre = pNombre;
            Clave = pClave;
            RFC = pRFC;
            TipoRegimen = pTipoRegimen;
            NombreContacto = pNombreContacto;
            Telefono1 = pTelefono1;
            Telefono2 = pTelefono2;
            Email = pEmail;
            _Direccion = new clsDirecciones();///SE INSTANCIA AL CONSTRUCTOR
            ////Direccion.  xq es un objeto direccion
            Direccion.Calle = pCalle;
            Direccion.NumeroExterior = pNumeroExterior;
            Direccion.NumeroInterior = pNumeroInterior;
            Direccion.Colonia = pColonia;
            Direccion.Municipio = pMunicipio;
            Direccion.Estado = pEstado;
            Direccion.CP= pCP;








        }

       
        ////////////////////////////////////////
       

        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }

        private clsDirecciones _Direccion;

        private clsDirecciones Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
    }
}
