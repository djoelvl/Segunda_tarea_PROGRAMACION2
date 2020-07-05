using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_de_comando
{
    class Principal
    {
        

       
        public void Encendido()
            {
            

                Console.WriteLine("Seleccione una de las siguientes opciones para poder utilizar su carrito a control remoto");
            Console.WriteLine("Actualmente esta encendido");
                Console.WriteLine("1.Apagar");
                Console.WriteLine("2.Avanzar");
                Console.WriteLine("3.Retroceder");
                Console.WriteLine("4.Mover hacia la izquierda");
                Console.WriteLine("5.Mover hacia la derecha");
                Carrito_de_control_remoto micarrito = new Carrito_de_control_remoto();
                ControlRemoto control = new ControlRemoto(micarrito);
                int i;
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Apagar");
                        control.Button(1);
                        break;
                    case 2:
                        Console.WriteLine("Avanzar");
                        control.Button(2);
                        break;
                    case 3:
                        Console.WriteLine("Retroceder");
                        control.Button(3);
                        break;
                    case 4:
                        Console.WriteLine("Mover hacia la izquierda");
                        control.Button(4);
                        break;
                    case 5:
                        Console.WriteLine("Mover hacia la derecha");
                        control.Button(5);
                        break;
                    
                    default:
                        Console.WriteLine("Acaba de elegir una opción incorrecta");
                        Console.WriteLine("Si usted desea salir escriba 1 y si no, escriba cualquier otro numero");

                        i = Convert.ToInt32(Console.ReadLine());
                        if (i == 1)
                        {
                            Environment.Exit(0);
                            Console.WriteLine("Precione cualquier tecla para terminar la aplicación.");

                        }
                        else

                        {
                            Principal A = new Principal();
                            A.Encendido();
                        }
                        break;
                }



            }
        public void Apagado()
        {
            

            Console.WriteLine("Seleccione una de las siguientes opciones para poder utilizar su carrito a control remoto");
                Console.WriteLine("Actualmente se encuentra apagado");

            Console.WriteLine("1.Encender");
            Console.WriteLine("2.Salir de el programa");
            
            Carrito_de_control_remoto micarrito = new Carrito_de_control_remoto();
            ControlRemoto control = new ControlRemoto(micarrito);
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Encender");
                    control.Button(0);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Va a salir de el programa");
                    Console.WriteLine("Si usted desea salir escriba 1 y si no, escriba cualquier otro numero");

                    i = Convert.ToInt32(Console.ReadLine());
                    if (i == 1)
                    {
                        
                        Console.WriteLine("Precione cualquier tecla para terminar la aplicación.");
                        Environment.Exit(0);

                    }
                    else

                    {
                        Principal q = new Principal();
                        q.Apagado();
                    }

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Acaba de elegir una opción incorrecta");
                    
                        Principal A = new Principal();
                        A.Apagado();
                       
                    break;
            }



        }
    }
}
           