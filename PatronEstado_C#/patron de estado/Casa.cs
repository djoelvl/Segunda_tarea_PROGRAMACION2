using System;
using System.Collections.Generic;
using System.Text;

namespace patron_de_estado
{
    class Casa
    {
        public void casa()
        {
            Console.WriteLine("Usted dejo su vehículo estacionado y está en su casa");
            Console.WriteLine("1.Para irte a dormir");
            Console.WriteLine("2.Para jugar");
            Console.WriteLine("3.Para volver a su auto");
            int vh;
            vh = Convert.ToInt32(Console.ReadLine());

            Boolean l;

            switch (vh)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Usted ha decidido irse a dormir(el programa se cerrara)");
                    Environment.Exit(0);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Usted ha decidido irse a jugar(el programa se cerrara)");
                    Environment.Exit(0);
                    
                    break;

                case 3:
                    Console.Clear();

                    Console.WriteLine("Usted ha decidido volver para su auto");
                        Principal a = new Principal();
                    a.Respuesta();
                    break;
                default:
                    Console.Clear();

                    Console.WriteLine("Por favor elija una de las opciones");
                    Casa c = new Casa();
                    c.casa();
                    break;
            }
        }
}
}