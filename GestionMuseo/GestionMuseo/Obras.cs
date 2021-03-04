using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMuseo
{
    public class Obras
    {
        private string obra_arte;
        private string titulo;
        private int año;
        private string autor;
        private string tipo;
        ///constructor/////////////////////////////////////////////////////////
        public string Obra_arte { get => obra_arte; set => obra_arte = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Año { get => año; set => año = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        ///////////////////////////////////////////////////////////////////////
    }
}
