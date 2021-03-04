using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno al = new Alumno();
            al.setNombre("Ivo");
            al.setNota1(10);
            al.setNota2(8);
            al.setNota3(9);
            al.setNota4(9);
            Console.WriteLine($"El promedio de las 2 primeras notas es {al.primeras()}");
            Console.WriteLine($"El promedio de las 2 ultimas notas es {al.ultimas()}");
            Console.WriteLine($"El promedio total de notas es {al.promedio()}");
            Console.ReadKey();
        }
    }
}
