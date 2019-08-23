using System.Collections.Generic;
using Etapa1.Entidades;

namespace CoreEscuela.Entidades
{
   public  class Escuela:ObjetoEscuelaBase
    {

        public int AnioDeCreacion{get; set;}

        public string Pais { get; set; }

        public string Ciudad { get; set; }
        
        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        //Constructor con funcion lamba
        public Escuela(string nombre, int anio,TiposEscuela tipos, string pais="",string ciudad=""){
            (Nombre, AnioDeCreacion) = (nombre,anio);
            Pais = pais;
            this.Ciudad =ciudad;

        }

        public override string ToString(){
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}"; 
        }
      
        
    }
}