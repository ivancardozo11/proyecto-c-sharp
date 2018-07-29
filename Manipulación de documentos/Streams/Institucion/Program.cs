using Institucion.Misc;
using Institucion.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaProfes = new List<Profesor>();

            string[] lineas = File.ReadAllLines("./Files/Profesores.txt");

            int localId = 0;

            foreach (var linea in lineas)
            {
                listaProfes.Add(new Profesor()
                {
                    Nombre=linea , Id = localId++
                });
            }

            foreach (var profe in listaProfes)
            {
                Console.WriteLine(profe.Nombre);
            }

            var archivo = File.Open("profesBinarios.bin", FileMode.OpenOrCreate);

            var binFile = new BinaryWriter(archivo);

            foreach (var profe in listaProfes)
            {

                binFile.Write(profe.Nombre);
                binFile.Write(profe.Id);
            }

            binFile.Close();
            archivo.Close();

            Console.ReadLine();
        }
        private void Rutina6() {
            var profesor = new Profesor() { Id = 12, Nombre = "Mateo", Apellido = "Pereira", CodigoInterno = "PROFE_SMART" };

            var Transmitter = new TransmisorDeDatos();
            Transmitter.InformacionEnviada += Transmitter_InformacionEnviada;
            Transmitter.InformacionEnviada += (obj, evtarg) =>
            {
                Console.WriteLine("");
            };

            Transmitter.FormatearYEnviar(profesor, formatter, "ALEXTROIO");

            Transmitter.FormatearYEnviar(profesor, Reverseformatter, "ALEXTROIO");
            Transmitter.FormatearYEnviar(profesor,
                (s) =>
                {
                    return new string(s.Reverse().ToArray<char>());
                }, "ALEXTROIO");


            Transmitter.InformacionEnviada -= Transmitter_InformacionEnviada;

            Transmitter.FormatearYEnviar(profesor,
                (s) =>
                {
                    return new string(s.Reverse().ToArray<char>());
                }, "ALEXTROIO");
        }
        private static void Transmitter_InformacionEnviada(object sender, EventArgs e)
        {
            Console.WriteLine("TRANSMISION DE INFORMACION");
        }

        private static string Reverseformatter(string input)=>  new string(input.Reverse().ToArray<char>());
        

        private static string formatter(string input)
        {
            
            var bytes = Encoding.UTF8.GetBytes(input);
            var base64 = Convert.ToBase64String(bytes);

            return base64;
        }

        private void Rutina5()
        {

            List<Persona> listaPersonas = new List<Persona>();

            listaPersonas.Add(new Alumno("Pedro", "Fernandez") { NickName = "Pedrito" });
            listaPersonas.Add(new Profesor() { Nombre = "Profesor", Apellido = "X" });
            listaPersonas.Add(new Alumno("Fernando", "Pedroza"));
            listaPersonas.Add(new Profesor() { Nombre = "Mag", Apellido = "Neto" });
            listaPersonas.Add(new Alumno("Juan", "Es"));


            for (int i = 0; i < listaPersonas.Count; i++)
            {
                if (listaPersonas[i] is Alumno)
                {
                    var al = (Alumno)listaPersonas[i];
                    Console.WriteLine(al.NickName != null ? al.NickName : al.NombreCompleto);
                }
                else
                {
                    var per = listaPersonas[i] as Persona;

                    if (per != null)

                        Console.WriteLine(per.NombreCompleto);

                }

            }


            foreach (var obj in listaPersonas)
            {
                if (obj is Alumno)
                {
                    var al = (Alumno)obj;
                    Console.WriteLine(al.NickName != null ? al.NickName : al.NombreCompleto);
                }
                else
                {
                    var per = obj as Persona;

                    if (per != null)

                        Console.WriteLine(per.NombreCompleto);

                }

            }
        }
        private void Rutina4()
        {
            Persona[] arregloPersonas = new Persona[5];

            var tam = arregloPersonas.Length;
            arregloPersonas[0] = new Alumno("Pedro", "Fernandez") { NickName = "Pedrito" };
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
                    Console.WriteLine(al.NickName != null ? al.NickName : al.NombreCompleto);
                }
                else
                {
                    Console.WriteLine(arregloPersonas[i].NombreCompleto);
                }

            }
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

        private void Rutina1()
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

        private static void Rutina3()
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
