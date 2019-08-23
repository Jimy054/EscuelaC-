namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DrawLine(int tamanio=10){          
            System.Console.WriteLine("".PadLeft(tamanio,'-'));
        }

       public static void WriteTitle(string title){
           int tamanio=title.Length+4;
           DrawLine(tamanio);          
            System.Console.WriteLine($"| {title.ToUpper()} |");
            DrawLine(tamanio);
        }

        public static void Beep(int hz=2000, int tiempo=500, int cantidad=1){
            while (cantidad-- >0)
            {
                System.Console.Beep(hz,tiempo);
              
            }
        }
    }
}