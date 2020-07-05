using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Singletton
{
    class Instancia_unica
    {
        private static Instancia_unica instancia;

        private int av;

        
        

        private void encendido()
        {
            Console.WriteLine("Su auto ya está encendido, decida si quiere avanzar o apagarlo");
            Console.WriteLine("1. Para avanzar");
            Console.WriteLine("2. Para apagarlo");
            
            av = Convert.ToInt32(Console.ReadLine());


            switch (av)
            {
                case 1:

                    Console.Clear();


                    Console.WriteLine("El vehiculo esta avanzando");
                    Instancia_unica w = new Instancia_unica();
                    w.Avanzar();
                    break;

                case 2:

                    Console.Clear();


                    Console.WriteLine("El vehiculo se acaba de apagar");
                    Instancia_unica x = new Instancia_unica();
                    x.Apagado();
                    break;

                default:
                    Console.Clear();

                    Console.WriteLine("Por favor elija una de las opciones");
                    Instancia_unica z = new Instancia_unica();
                    z.encendido();
                    break;

            }
        }

        private void Apagado()
        {
            Console.WriteLine("El vehículo está apagado decida si quiere salir y dejarlo estacionado o desea encenderlo");
            Console.WriteLine("1.Para salir de el vehículo");
            Console.WriteLine("2.Para encender de el vehículo");

            
            av = Convert.ToInt32(Console.ReadLine());

            switch (av)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Usted ha decidido salir de el vehiculo");
                    Console.Clear();
                    Instancia_unica w = new Instancia_unica();
                    w.principal();

                    break;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Usted ha decidido encender su auto");
                    Console.Clear();
                    Instancia_unica x = new Instancia_unica();
                    x.encendido();

                    break;
                default:
                    Console.Clear();

                    Console.WriteLine("Por favor elija una de las opciones");
                    Instancia_unica c = new Instancia_unica();
                    c.Apagado();

                    break;
            }
        }

        private void Avanzar()
        {
            Console.WriteLine("El vehículo está avanzando decida si quiere aumentar la velocidad o desea frenar el vehículo");
            Console.WriteLine("1.Para aumentar la velocidad de el vehículo");
            Console.WriteLine("2.Para detener el vehículo");

            av = Convert.ToInt32(Console.ReadLine());

            switch (av)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Usted ha decidido aumentar la velocidad de el vehiculo");
                    Console.WriteLine("La velocidad de el vehículo ha aumentado");






                    Instancia_unica z = new Instancia_unica();
                    z.Avanzar();

                    break;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Usted ha decidido frenar el vehículo");
                    Instancia_unica w = new Instancia_unica();
                    w.Frenar();
                    break;

                default:
                    Console.Clear();

                    Console.WriteLine("Por favor elija una de las opciones");
                    Instancia_unica c = new Instancia_unica();
                    c.Avanzar();
                    break;

            }
        }

        private void casa()
        {
            Console.WriteLine("Usted dejo su vehículo estacionado y está en su casa");
            Console.WriteLine("1.Para irte a dormir");
            Console.WriteLine("2.Para jugar");
            Console.WriteLine("3.Para volver a su auto");
            av = Convert.ToInt32(Console.ReadLine());

            switch (av)
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
                    Instancia_unica z = new Instancia_unica();
                    z.principal();
                    break;
                default:
                    Console.Clear();

                    Console.WriteLine("Por favor elija una de las opciones");
                    Instancia_unica c = new Instancia_unica();
                    c.casa();
                    break;
            }
        }

        private void estacionado()
        {
            Console.WriteLine("Usted acaba de entrar a su vehículo, desea encender el vehiculo y utilizarlo, o desea salir de el vehículo?");
            Console.WriteLine("1.Para encender el vehículo");
            Console.WriteLine("2.Para Salir de el vehículo");
            av = Convert.ToInt32(Console.ReadLine());

            switch (av)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Encender el vehículo");
                    Instancia_unica w = new Instancia_unica();
                    w.encendido();
                    break;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Salir de el vehículo");
                    Instancia_unica x = new Instancia_unica();
                    x.principal();

                    break;

                default:
                    Console.Clear();

                    Console.WriteLine("Por favor elija una de las opciones");
                    Instancia_unica c = new Instancia_unica();
                    c.estacionado();
                    break;

            }
        }

        

        private void Frenar()
        {
            Console.WriteLine("Su auto ya está detenido, decida si quiere avanzar o apagarlo");
            Console.WriteLine("1. Para avanzar");
            Console.WriteLine("2. Para apagarlo");
            av = Convert.ToInt32(Console.ReadLine());

            switch (av)
            {
                case 1:
                    Console.Clear();




                    Console.WriteLine("El vehiculo esta avanzando");
                    Instancia_unica w = new Instancia_unica();
                    w.Avanzar(); 
                    break;

                case 2:


                    Console.Clear();

                    Console.WriteLine("El vehiculo se acaba de apagar");
                    Instancia_unica x = new Instancia_unica();
                    x.Apagado();
                    break;

                default:
                    Console.Clear();

                    Console.WriteLine("Por favor elija una de las opciones");
                    Instancia_unica c = new Instancia_unica();
                    c.Frenar();
                    break;

            }
        }

        private void principal()
        {
            Console.WriteLine("Su vehículo se encuentra estacionado, desea entrar al vehiculo y utilizarlo?");
            Console.WriteLine("1.Para si");
            Console.WriteLine("2.Para no");
            av = Convert.ToInt32(Console.ReadLine());

            switch (av)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Usted ha decidido entrar y subirse al vehiculo");

                    Instancia_unica w = new Instancia_unica();
                    w.estacionado();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Usted ha decidido dejar su auto estacionado e irse para su casa");


                    Instancia_unica x = new Instancia_unica();
                    x.casa();

                    break;

                default:
                    Console.WriteLine("Por favor si no se subirá en el vehículo vayase para su casa y deje de estar azarando en la calle");
                    Console.WriteLine("Si desea salir de el programa escriba 1 y si no, escriba cualquier otro numero que quiera");
                    int k;

                    k = Convert.ToInt32(Console.ReadLine());
                    if (k == 1)
                    {
                        Environment.Exit(0);


                    }
                    else
                    {
                        Program a = new Program();
                    }
                    break;

            }
        }
        public static Instancia_unica Obtener()
        {
            if (instancia == null)
            {
                instancia = new Instancia_unica();
                
            }
            return instancia;

        }

        public void ejecutar()
        {
            Instancia_unica x = new Instancia_unica();
            x.principal();
        }



    }
    }

