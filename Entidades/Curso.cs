using System;
using System.Collections.Generic;
using Etapa1.Entidades;

namespace CoreEscuela.Entidades
{
    public class Curso:ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }

        public List<Asignatura> Asignatura{get;set;}
        public List<Evaluacion> Evaluacion{get;set;}

        public List<Alumno> Alumnos{get;set;}
        
        //Guid es aleatoriamente
        
    }
}