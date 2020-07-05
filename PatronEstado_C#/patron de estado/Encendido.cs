using System;
using System.Collections.Generic;
using System.Text;

namespace patron_de_estado
{
    class Encendido : EstadoVehiculoj
    {

       
            public override void Respuesta()
            {
                Console.WriteLine("Su auto ya está encendido, decida si quiere avanzar o apagarlo");
                Console.WriteLine("1. Para avanzar");
                Console.WriteLine("2. Para apagarlo");
                int av;
                av = Convert.ToInt32(Console.ReadLine());


                switch (av)
                {
                    case 1:

                        Console.Clear();


                        Console.WriteLine("El vehiculo esta avanzando");
                        Avanzar w = new Avanzar();
                        w.Respuesta();
                        break;

                    case 2:

                        Console.Clear();


                        Console.WriteLine("El vehiculo se acaba de apagar");
                        Apagado a = new Apagado();
                        a.Respuesta();
                        break;

                    default:
                        Console.Clear();

                        Console.WriteLine("Por favor elija una de las opciones");
                        Encendido c = new Encendido();
                        c.Respuesta();
                        break;

                }
            }
        }
    }
    

