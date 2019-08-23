using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    //Sealed no permite heredar
    public sealed class EscuelaEngine
    {
        public EscuelaEngine(Escuela escuela) 
        {
            this.Escuela = escuela;
               
        }
        
        public Escuela Escuela { get; set; }
        public EscuelaEngine(){
           
            
        }


        public void Inicializar()
        {
            Escuela = new Escuela("Platzi", 2019, TiposEscuela.Primaria, pais: "Colombia", ciudad: "Bogota");
            CargarCursos();
            CargarAsignaturas();       
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
           foreach (var curso in Escuela.Cursos)
           {
               foreach (var asignatura in curso.Asignatura)
               {
                   foreach (var alumno in curso.Alumnos)
                   {
                       var rnd = new Random();
                       for (int i = 0; i < 5; i++)
                       {
                           var ev = new Evaluacion{
                               Asignatura = asignatura,
                               Nombre= $"(asignatura.Nombre) Eva(i+1)",
                               Nota = (float)(5*rnd.NextDouble()),
                               Alumno=alumno
                           };
                           alumno.Evaluaciones.Add(ev);
                       }
                   }
               }
           }
        }

        private void CargarAsignaturas()
        {
           foreach (var curso in Escuela.Cursos)
           {
                List<Asignatura> listaAsignatura = new List<Asignatura>(){
                    new Asignatura{Nombre="Matematica"},
                    new Asignatura{Nombre="Ciencias Naturales"},
                    new Asignatura{Nombre="Fisica"},
                    new Asignatura{Nombre="Idioma"},
                };
              curso.Asignatura=  listaAsignatura;
           }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombres={"Jose", "Joss","Katy","Anna", "Erick"};
            string[] apellido = {"Bamaca", "Torres", "Canto","Castaneada","Lopez"};
            string[] nombres2 ={"Estuardo", "Roberto","Alexis","Oscar"};

            var listaAlumnos = from n1 in nombres
                               from n2 in nombres2
                               from a1 in apellido
                               select new Alumno{Nombre=$"{n1}{n2} {a1}"};
            
            return listaAlumnos.OrderBy((alum)=> alum.UniqueID).Take(cantidad).ToList();

        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre="101", Jornada=TiposJornada.Matutina},
                new Curso(){Nombre="201",Jornada=TiposJornada.Matutina },
                new Curso{ Nombre="301",Jornada=TiposJornada.Matutina},
                new Curso(){Nombre="401", Jornada=TiposJornada.Vespertina},
                new Curso(){Nombre="501",Jornada=TiposJornada.Matutina }};
                Random rd = new Random();


                
                foreach (var c in Escuela.Cursos)
                {
                    int cantidadRandom = rd.Next(5,30);
                    c.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
                }
        }


       


    }
}