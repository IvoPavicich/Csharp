﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class clsAbsClientes///abstract para indicar que la clase es abstracta
    {

        public abstract int Id  { get; set; }
        public abstract string Nombre { get; set; }
        public abstract string Clave { get; set; }
        public abstract string RFC { get; set; }
        public abstract int TipoRegimen { get; set; }
        public  abstract string NombreContacto { get; set; }
    }
}
