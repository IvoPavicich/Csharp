using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCampo_POO
{
    public class LoteSoja:Lote
    {
        public double precio_s;
        public LoteSoja(int nlote,double superficie, string tipo_cultivo, double gastos, double cosecha, double precio,double ingreso,double ib) :base(nlote,superficie, tipo_cultivo,  gastos, cosecha,precio, ingreso, ib)
        {
            this.precio_s = precio;
            this.ingreso = Ingresos(cosecha, precio);
            this.ib = ingresos_Bruto(ingreso, gastos);
            
        }
        public override double Ingresos(double cosecha, double precio_s)
        {
            ingreso = cosecha * precio_s;
            return ingreso;

        }

        public override double ingresos_Bruto(double ingreso, double gastos)
        {
            ingreso = Ingresos(cosecha, precio_s);
            ib = ingreso - gastos;
            return ib;

        }

        public override String mostrarDatos()
        {
            return "Lote N° :" + nLote + " \n " + "Gastos: " + gastos + " \n " + " \n " + "El ingreso es " + ingreso + "\n" + "Ingreso Bruto " + ib + "\n";


        }
    }
}
