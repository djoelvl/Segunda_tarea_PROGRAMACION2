using System;
using System.Collections.Generic;
using System.Text;

namespace patron_de_estado
{
    class Class1 : EstadoVehiculoj
    {
        

    

        public override void Respuesta()
        {
            Console.WriteLine("Usted acaba de entrar a su vehículo, desea encender el vehiculo y utilizarlo, o desea salir de el vehículo?");
            Console.WriteLine("1.Para encender el vehículo");
            Console.WriteLine("2.Para Salir de el vehículo");
            int carro;
            carro = Convert.ToInt32(Console.ReadLine());
            switch (carro)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Encender el vehículo");
                    Encendido l = new Encendido();
                    l.Respuesta();
                    break;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Salir de el vehículo");
                    Principal k = new Principal();
                    k.Respuesta();

                    break;

                default:
                    Console.Clear();

                    Console.WriteLine("Por favor elija una de las opciones");
                    Class1 c = new Class1();
                    c.Respuesta();
                    break;

            }
        }

    }
}
