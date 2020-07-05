using System;

namespace Patron_Singletton
{
    class Program
    {
        static void Main(string[] args)
        {
            Instancia_unica x = Instancia_unica.Obtener();
            x.ejecutar();

        }
    }
}
