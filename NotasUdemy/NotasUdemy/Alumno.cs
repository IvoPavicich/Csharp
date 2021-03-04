using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasUdemy
{
    public class Alumno
    {
        private string nombre { get; set; }
        private int nota1 { get; set; }
        private int nota2 { get; set; }
        private int nota3 { get; set; }
        private int nota4 { get; set; }


        //////////////////METODOS get y set///////////////////////////////////////////
        public string getNombre()
        {
            return nombre;

        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public double getNota1()
        {
            return nota1;

        }
        public void setNota1(int nota1)
        {
            if (nota1 >= 0 && nota1 <= 10) this.nota1 = nota1;
            else this.nota1 = 0;
        }
        public double getNota2()
        {
            return nota2;

        }
        public void setNota2(int nota2)
        {
            if (nota2 >= 0 && nota2 <= 10) this.nota2 = nota2;
            else this.nota2 = 0;
        }
        public double getNota3()
        {
            return nota3;

        }
        public void setNota3(int nota3)
        {
            if (nota3 >= 0 && nota3 <= 10) this.nota3 = nota3;
            else this.nota3 = 0;
        }
        public double getNota4()
        {
            return nota4;

        }
        public void setNota4(int nota4)
        {
            if (nota4 >= 0 && nota4 <= 10) this.nota4 = nota4;
            else this.nota4 = 0;
        }
        public double primeras()
        {
            return (this.nota1 + this.nota2) / 2;
        }
        public double ultimas()
        {
            return (this.nota3 + this.nota4) / 2;
        }
        public double promedio()
        {
            return (this.nota1+this.nota2+this.nota3+this.nota4) / 4;

        }

    }
}
