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

            var alumno1 = new Alumno("Ivan" , "Cardozo")
            {
                Id =1 ,
                Edad =36 ,
                Telefono = "311111", Email="ivan@hotmail.com"
            };
            var profesor1 = new Profesor()
            {
                Id = 1,
                Nombre = " Axel ",
                Apellido = "Ruiz",
                Edad = 28,
                Telefono = "311111",
                Catedra = "Programacion"
            };

            Console.WriteLine(Persona.ContadorPersonas);
            Console.ReadLine();
        }
    }
}
