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
            Persona[] arregloPersonas = new Persona[5];

            var tam = arregloPersonas.Length;
            arregloPersonas[0] = new Alumno("Pedro", "Fernandez") { NickName="Pedrito"};
            arregloPersonas[1] = new Profesor() { Nombre = "Profesor", Apellido = "X" };

            arregloPersonas[2] = new Alumno("Fernando", "Pedroza");
            arregloPersonas[3] = new Profesor() { Nombre = "Mag", Apellido = "Neto" };

            arregloPersonas[4] = new Alumno("Juan", "Es");

            //arregloPersonas[5] = new Profesor() { Nombre = "Alberto", Apellido = "Piedra" };

            for (int i = 0; i < arregloPersonas.Length; i++)
            {
                if (arregloPersonas[i] is Alumno)
                {
                    var al = (Alumno)arregloPersonas[i];
                    Console.WriteLine(al.NickName !=null ? al.NickName : al.NombreCompleto);
                }
                else
                {
                    Console.WriteLine(arregloPersonas[i].NombreCompleto);
                }
            
        }
            Console.ReadLine();
        }

        private static void Rutina2()
        {
            short s = 32000;
            int i = 33000;
            float f = 2.35f;
            

            Console.WriteLine(i);
            s = (short)i;
            Console.WriteLine(s);
            Console.WriteLine(f);
            i = (int)f;
            Console.WriteLine(i);
        }

        public void Rutina1()
        {
            Console.WriteLine("Gestion de Estructura");
            Persona[] lista = new Persona[3];

            lista[0] = new Alumno("Ivan", "Cardozo")
            {
                Id = 1,
                Edad = 36,
                Telefono = "311111",
                Email = "ivan@hotmail.com"
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

            var newC = new CursoStruct();
            newC.Curso = "564-A";


            var cursoFreak = c;
            cursoFreak.Curso = "666-G";

            Console.WriteLine($"Curso c = {c.Curso}");
            Console.WriteLine($"Curso Freak = {cursoFreak.Curso}");




            Console.WriteLine("C L A S E S ");

            CursoClass c_class = new CursoClass(70);
            c_class.Curso = "102-B";

            var newCc_class = new CursoStruct();
            newCc_class.Curso = "563-A";


            var cursoFreakc_class = c_class;
            cursoFreak.Curso = "662-G";

            Console.WriteLine($"Curso c = {c_class.Curso}");
            Console.WriteLine($"Curso Freak = {cursoFreakc_class.Curso}");




            Console.WriteLine("E N U M E R A C I O N E S");

            var alumnoEst = new Alumno(" William ", "Torballs")
            {
                Id = 3,
                Edad = 25,
                Telefono = "911",
                Estado = EstadosAlumno.Activo
            };

            Persona personaX = alumnoEst;
            Console.WriteLine("Este es el estado del alumno:  " + alumnoEst.Estado);

            Console.WriteLine($"Tipo:       { typeof(EstadosAlumno) }");
            Console.WriteLine($"Tipo:       { typeof(Alumno) }");
            Console.WriteLine($"Tipo:       { alumnoEst.GetType()  }");
            Console.WriteLine($"Nombresito: { personaX.GetType()  }");
            Console.WriteLine($"Tipo:       { nameof(Alumno) }");
            Console.WriteLine($"Tamaño:     { sizeof(int) }");

        }

        public static void Rutina3()
        {
            var alumno = new Alumno("Victor", "Perez");
            var profesor = new Profesor();
            Persona persona = profesor;

            alumno = (Alumno)persona;

            if (persona is Profesor)
            {
                var profe = (Profesor)persona;
                ///...
            }
            var tmpProfe = persona as Profesor;

            if (tmpProfe != null)
            {
                //..
            }
        }
    }
}
