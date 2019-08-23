using System;
using System.Collections.Generic;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using Etapa1.Entidades;
using static System.Console;
namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuelaEngine = new EscuelaEngine();
            escuelaEngine.Inicializar();
            Printer.WriteTitle("Bienvenidos a la Escuela");
            Printer.Beep(10000,cantidad:5);
            ImprimirCursosEscuela(escuelaEngine.Escuela);

            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.WriteTitle("Pruebas de Polimorfismo");

            var alumnoTest = new Alumno{Nombre="Claire Underwood"};
            ObjetoEscuelaBase ob = alumnoTest;
        }
//Puntero
        private static bool Predicate(Curso obj)
        {
            return obj.Nombre=="Desde lista";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Lista de Cursos de la Escuela");

            if (escuela?.Cursos != null)
            {                
                foreach (var i in escuela.Cursos)
                {
                    Console.WriteLine("Cursos "+i.Nombre + " ID "+i.UniqueID);
                }   
            }
            
        }

    
    }
}
           //otraColeccion.Clear();
            //   Predicate<Curso> miAlgoritmo=Predicate;
                    /*    escuela.Cursos= new Curso[] {
                new Curso(){Nombre="101"},
                new Curso(){Nombre="201" },
                new Curso{ Nombre="301"}
            };*/

// escuela.Cursos.AddRange(otraColeccion);

            //escuela.Cursos = arreglorCursos;
   /*
            System.Console.WriteLine(curos1.Nombre+","+curos1.UniqueID);
            System.Console.WriteLine($"{curos2.Nombre},{curos2.UniqueID}");
            System.Console.WriteLine(curos3); */

            //escuela.Cursos.RemoveAll((cur)=> cur.Nombre=="501" && cur.Jornada == TiposJornada.Vespertina);         