using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJADORES
{
    /*Un tipo "struct" es una construcción de programación utilizado para definir tipos personalizados, 
      se usan para encapsular pequeños grupos de variables relacionadas y representadas como un solo elemento*/
   

    class Program
    {
        public struct Trabajador///tipo de dato compuesto
        {
            public string name, surname, adress, job, academicLevel;
            public int dni;
            public double monthHours, valueHour;


            public Trabajador(string name, string surname, string adress, string job, string academicLevel, int dni, double monthHours, double valueHour)
            {
                this.name = name;
                this.surname = surname;
                this.adress = adress;
                this.job = job;
                this.academicLevel = academicLevel;
                this.dni = dni;
                this.monthHours = monthHours;
                this.valueHour = valueHour;

            }
            ////////////////////////METODOOS///////////////////////////////////////////////////////
            public double LiquidarSueldo()//////funcion
            {
                double salary = 0;
                double contributions = 0;//aportes personales
                salary = monthHours * valueHour;
                contributions = 17 * (salary / 100);
                salary = salary - contributions;
                return salary;
            }

            public void MostrarDatos()////Metodo
            {

                Console.WriteLine("Nombre: " + name);
                Console.WriteLine("Apellido: " + surname);
                Console.WriteLine("DNI :" + dni);
                Console.WriteLine("Direccion :" + adress);
                Console.WriteLine("Puesto de trabajo: " + job);
                Console.WriteLine("Hroas mensuales :" + monthHours);
                Console.WriteLine("Valor de la hora :" + valueHour);
                Console.WriteLine("Nivel academico: " + academicLevel);


            }

        }



        static void Main(string[] args)
        {

        
            string name,surname, adress, job, academicLevel;
            int dni;
            double monthHours, valueHour;
            int option = 0;
            List<Trabajador> listworkers = new List<Trabajador>();////se define la lista de trabajadores


            do
            {
                try
                {
                    Console.WriteLine
                 ("####################################################################");
                    Console.WriteLine("POR FAVOR SELECCIONE LA OPCION QUE DESEA");
                    Console.WriteLine("  ");
                    Console.WriteLine("1-Agregar un nuevo trabajador a la lista de trabajadores");
                    Console.WriteLine("2-Eliminar un trabajador de la lista de trabajadores");
                    Console.WriteLine("3-Modificar los datos de un trabajador");
                    Console.WriteLine("4-Listar trabajadores y Liquidar su sueldo:");
                    Console.WriteLine("Desea realizar otra accion?(PRESIONE 5 PARA SALIR)");
                    Console.WriteLine("  ");
                    Console.WriteLine
                 ("####################################################################");
                    option = Convert.ToInt32(Console.ReadLine());//Lee la opcion ingresada

                    if (option == 1)
                    {
                        Console.WriteLine("Ingrese el nombre del nuevo trabajador: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del nuevo trabajador: ");
                        surname = Console.ReadLine();
                        Console.WriteLine("Ingrese el N° de documento del nuevo trabajador: ");
                        dni = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese la direccion del nuevo trabajador: ");
                        adress = Console.ReadLine();
                        Console.WriteLine("Ingrese el puesto nuevo trabajador: ");
                        job = Console.ReadLine();
                        Console.WriteLine("Ingrese el total de horas mensuales trabajadas: ");
                        monthHours = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese el valor por hora  trabajada: ");
                        valueHour = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nivel academico=> Primario-Secundario-Terciario-Universitario-Magister-Doctor ");
                        academicLevel = Console.ReadLine();

                        Trabajador newworker = new Trabajador(name, surname, adress, job, academicLevel, dni, monthHours, valueHour);
                        listworkers.Add(newworker);
                        Console.WriteLine(" ");
                        Console.WriteLine("------------EL NUEVO TRABAJADOR SE HA CARGADO EXITOSAMENTE-------------");


                    }////////BORRAR TRABAJADOR////
                    else if (option == 2)
                    {
                        bool find = false;
                        int i = 0;
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el dni del trabajador que desea borrar");
                        int dnifind = Convert.ToInt32(Console.ReadLine());
                        while (find == false && i <= listworkers.Count)
                        {


                            if (listworkers.Count == 0)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("--------NO EXISTE EL TRABAJADOR QUE BUSCA!!!!----- ");
                                Console.WriteLine(" ");
                                break;
                            }

                            else if (listworkers[i].dni == dnifind)
                            {
                                find = true;
                                listworkers.Remove(listworkers[i]);
                                Console.WriteLine("---EL TRABAJADOR HA SIDO BORRADO EXITOSAMENTE!!!---");
                            }

                            else if (find == false)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("--------NO SE ENCONTRO EL TRABAJADOR !!!!----- ");
                                Console.WriteLine(" ");
                                break;
                            }
                            else
                            {
                                i++;
                            }

                        }



                    }///////BORRAR TRABAJADOR//////////*FIN/////////

                    //////////////////////////////////////////Modificar datos////////////////////////////////////////////////////////////////////////
                    else if (option == 3)
                    {
                        bool find = false;
                        int i = 0;
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el dni del trabajador que desea");
                        int dnifind = Convert.ToInt32(Console.ReadLine());
                        while (find == false && i < listworkers.Count)
                        {

                            if (listworkers[i].dni == dnifind)
                            {
                                find = true;
                                
                                
                            }                           
                            else
                            {
                                i++;
                            }

                        }
                        if (find == false)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("--------NO SE ENCONTRO EL TRABAJADOR !!!!----- ");
                            Console.WriteLine(" ");
                            break;
                        }
                        else
                        {
                            int selec = 0;
                            do
                            {
                                Console.WriteLine("SELECCIONE EL ATRIBUTO QUE DESEA MODIFICAR: ");
                                Console.WriteLine(" ");
                                Console.WriteLine("1-NOMBRE");
                                Console.WriteLine("2-APELLIDO");
                                Console.WriteLine("3-DNI");
                                Console.WriteLine("4-DIRECCION");
                                Console.WriteLine("5-PUESTO");
                                Console.WriteLine("6-HORAS MENSUALES");
                                Console.WriteLine("7-VALOR HORA");
                                Console.WriteLine("8-NIVEL ACADEMICO");
                                selec = Convert.ToInt32(Console.ReadLine());

                                if (selec == 1)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("INGRESE EL NUEVO NOMBRE");
                                    name = Console.ReadLine();
                                    Trabajador nuevot = listworkers[i];
                                    nuevot.name = name;
                                    listworkers[i] = nuevot;
                                }
                                else if (selec == 2)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("INGRESE EL NUEVO APELLIDo");
                                    surname = Console.ReadLine();
                                    Trabajador nuevot = listworkers[i];
                                    nuevot.surname = surname;
                                    listworkers[i] = nuevot;
                                }
                                else if (selec == 3)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("INGRESE EL NUEVO DNI");
                                    dni = Convert.ToInt32(Console.ReadLine());
                                    Trabajador nuevot = listworkers[i];
                                    nuevot.dni = dni;
                                    listworkers[i] = nuevot;
                                }
                                else if (selec == 4)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("INGRESE la NUEVa DIRECCION");
                                    adress = Console.ReadLine();
                                    Trabajador nuevot = listworkers[i];
                                    nuevot.adress = adress;
                                    listworkers[i] = nuevot;
                                }

                                else if (selec == 5)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("INGRESE la NUEVo Puesto");
                                    job = Console.ReadLine();
                                    Trabajador nuevot = listworkers[i];
                                    nuevot.job = job;
                                    listworkers[i] = nuevot;
                                }
                                else if (selec == 6)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("INGRESE el nuevo total de horas mensuales ");
                                    monthHours = Convert.ToInt32(Console.ReadLine());
                                    Trabajador nuevot = listworkers[i];
                                    nuevot.monthHours = monthHours;
                                    listworkers[i] = nuevot;
                                }




                                else if (selec == 7)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("INGRESE el nuevo precio por horas ");
                                    valueHour = Convert.ToInt32(Console.ReadLine());
                                    Trabajador nuevot = listworkers[i];
                                    nuevot.valueHour = valueHour;
                                    listworkers[i] = nuevot;
                                }
                                else if (selec == 8)
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Nivel academico=> Primario-Secundario-Terciario-Universitario-Magister-Doctor ");
                                    academicLevel = Console.ReadLine();
                                    Trabajador nuevot = listworkers[i];
                                    nuevot.academicLevel = academicLevel;
                                    listworkers[i] = nuevot;
                                }
                                else
                                {
                                    Console.WriteLine("¡¡OPCION INCORRECTA!!");
                                }

                            } while (selec != 1 && selec != 2 && selec != 3 && selec != 4 && selec != 5 && selec != 6 && selec != 7 && selec != 8);

                            Console.WriteLine(" ");
                            Console.WriteLine("-------------SE HA MODIFICADO CORRECTAMENTE------");
                            Console.WriteLine(" ");
                        }


                    }//////MODIFICAR DATOS////////////////////////////*FIN//////////////////////////////////////


                    else if (option==4)///////LIQUIDAR SUELDOS Y LISTAR TRABAJADORES/////
                    {
                        double salary = 0;
                        for (int i=0; i < listworkers.Count ;i++)

                        {
                            Console.WriteLine("  ");
                            Console.WriteLine
                          ("-------------------------------------------------");
                            listworkers[i].MostrarDatos();
                            salary = listworkers[i].LiquidarSueldo();
                            Console.WriteLine("SU SUELDO ES: "+ salary);
                            Console.WriteLine
                          ("-------------------------------------------------");
                            Console.WriteLine("   ");
                        }

                        if (listworkers.Count==0)
                        {
                            Console.WriteLine("   ");
                            Console.WriteLine("NO EXISTE NINGUN TRABAJADOR");
                            Console.WriteLine("    ");
                        }

                    }///////LIQUIDAR SUELDOS Y LISTAR TRABAJADORES/////*FIN////////////////////////////////////////////////////


                }
                catch (FormatException fe)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("Erroor" + fe.Message);
                    Console.WriteLine("********************************");
                }
                catch (Exception e)
                {
                    Console.WriteLine("********************************");
                    Console.WriteLine("Erroor" + e.Message);
                    Console.WriteLine("********************************");
                }

            } while (option != 5);


        }
    
    }
}
