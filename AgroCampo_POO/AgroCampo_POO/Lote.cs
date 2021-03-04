using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCampo_POO
{
    
    public class Lote
    {
        public double superficie { get; set; }
        public string tipo_cultivo { get; set; }
        public double gastos { get; set; }
        public double cosecha { get; set; }
        public double precio { get; set; }
        public double ingreso { get; set; }
        public double ib { get; set; }
        public int nLote { get; set; }
        public Lote(int nlote,double superficie,string tipo_cultivo,double gastos,double cosecha,double precio,double ingreso,double ib)
        {
            this.nLote = nlote;
            this.superficie = superficie;
            this.tipo_cultivo = tipo_cultivo;
            this.gastos = gastos;
            this.cosecha = cosecha;
            this.precio = precio;
            this.ingreso = Ingresos(cosecha,precio);
            this.ib = ingresos_Bruto(ingreso,gastos);
            
        }

        public virtual double Ingresos(double cosecha,double precio)
        {
            ingreso = cosecha * precio;
            return ingreso;

        }

        public virtual double ingresos_Bruto(double ingreso, double gastos)
        {
            ingreso = Ingresos(cosecha,precio);
            ib = ingreso - gastos;
            return ib;

        }

        public virtual String mostrarDatos()
        {
            return "Lote N° :"+nLote+" \n "+"Gastos: " + gastos +" \n "+" \n " +"El ingreso es"+ingreso+"\n"+"Ingreso Bruto"+ib;


        }




    }
}
