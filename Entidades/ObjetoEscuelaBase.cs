namespace Etapa1.Entidades
{
    //Abstract ya no puede instanciar 
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueID { get; private set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()=>UniqueID = System.Guid.NewGuid().ToString();

        
    }
}