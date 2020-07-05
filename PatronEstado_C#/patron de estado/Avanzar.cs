using System;
using System.Collections.Generic;
using System.Text;

namespace patron_de_estado
{
    class Avanzar : EstadoVehiculoj
    {
       

        public override void Respuesta()
        {
            Console.WriteLine("El vehículo está avanzando decida si quiere aumentar la velocidad o desea frenar el vehículo");
            Console.WriteLine("1.Para aumentar la velocidad de el vehículo");
            Console.WriteLine("2.Para detener el vehículo");

            int vh;
            vh = Convert.ToInt32(Console.ReadLine());

            switch (vh)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Usted ha decidido aumentar la velocidad de el vehiculo");
                    Console.WriteLine("La velocidad de el vehículo ha aumentado");






                    Avanzar s = new Avanzar();
                    s.Respuesta();


                    break;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Usted ha decidido frenar el vehículo");
                    Encendido a = new Encendido();
                    a.Respuesta();
                    break;

                default:
                    Console.Clear();

                    Console.WriteLine("Por favor elija una de las opciones");
                    Avanzar c = new Avanzar();
                    c.Respuesta();
                    break;

            }
        }
}
}
