using Institucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestion de institución");
            Persona[] lista = new Persona[3];
            
            lista[0] = new Alumno("Ivan" , "Cardozo")
            {
                Id =1 ,
                Edad =36 ,
                Telefono = "311111",
                Email ="ivan@hotmail.com"
            };

            lista[1] = new Profesor()
            {
                Id = 2,
                Nombre = " Axel ",
                Apellido = "Ruiz",
                Edad = 28,
                Telefono = "2142",
                Catedra = "Programacion"
            };

            lista[2] = new Profesor()
            {
                Id = 3,
                Nombre = " William ",
                Apellido = "Torballs",
                Edad = 25,
                Telefono = "911",
                Catedra = "Algebra"
            };

            Console.WriteLine(Persona.ContadorPersonas);
            Console.WriteLine("Resumenes");

            foreach (Persona p in lista)
            {
                Console.WriteLine($"Tipo {p.GetType()}");
                Console.WriteLine(p.ConstruirResumen()); 
            }

            Console.ReadLine();
        }
    }
}
