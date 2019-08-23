using System.Collections.Generic;
using Etapa1.Entidades;

namespace CoreEscuela.Entidades
{
    public class Alumno: ObjetoEscuelaBase
    {
        
         public List<Evaluacion> Evaluaciones{get;set;}

        public Alumno() =>(Evaluaciones) = ( new List<Evaluacion>());


    }
}