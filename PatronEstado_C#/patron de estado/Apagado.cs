using System;
using System.Collections.Generic;
using System.Text;

namespace patron_de_estado
{
    class Apagado : EstadoVehiculoj
    {


        

        public override void Respuesta()
        {
            Console.WriteLine("El vehículo está apagado decida si quiere salir y dejarlo estacionado o desea encenderlo");
            Console.WriteLine("1.Para salir de el vehículo");
            Console.WriteLine("2.Para encender de el vehículo");

            int vh;
            vh = Convert.ToInt32(Console.ReadLine());

            switch (vh)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Usted ha decidido salir de el vehiculo");
                    Console.Clear();
                    Principal k = new Principal();
                    k.Respuesta();


                    break;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Usted ha decidido encender su auto");
                    Console.Clear();
                    Encendido a = new Encendido();
                    a.Respuesta();

                    break;
                default:
                    Console.Clear();

                    Console.WriteLine("Por favor elija una de las opciones");
                    Apagado c = new Apagado();
                    c.Respuesta();

                    break;
            }
        }
    }
}
