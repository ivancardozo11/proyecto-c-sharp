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
            Console.WriteLine("Gestion de Estructura");
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

                IEnteInstituto ente = p;

                ente.ConstruirLlaveSecreta("Argumento cualquiera");
            }
            Console.WriteLine("S T R U C  T S");

            CursoStruct c = new CursoStruct(70);
            c.Curso = "101-B";

             var  newC = new CursoStruct();
             newC.Curso = "564-A";


            var cursoFreak = c;
            cursoFreak.Curso = "666-G";

            Console.WriteLine($"Curso c = {c.Curso}");
            Console.WriteLine($"Curso Freak = {cursoFreak.Curso}");




            Console.WriteLine("C L A S E S ");

            CursoClass c_class = new CursoClass(70);
            c_class.Curso = "102-B";

             var newCc_class = new CursoStruct();
             newC.Curso = "563-A";


            var cursoFreakc_class = c_class;
            cursoFreak.Curso = "662-G";

            Console.WriteLine($"Curso c = {c_class.Curso}");
            Console.WriteLine($"Curso Freak = {cursoFreakc_class.Curso}");
    
            Console.ReadLine();
        }
    }
}
