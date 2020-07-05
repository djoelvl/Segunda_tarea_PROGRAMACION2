using System;

namespace patron_de_estado
{
    class Principal : EstadoVehiculoj
    {
        
        

        public override void Respuesta()
        {
            Console.WriteLine("Su vehículo se encuentra estacionado, desea entrar al vehiculo y utilizarlo?");
            Console.WriteLine("1.Para si");
            Console.WriteLine("2.Para no");
            int vh;
            vh = Convert.ToInt32(Console.ReadLine());

            Boolean l;

            switch (vh)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Usted ha decidido entrar y subirse al vehiculo");

                    Class1 m = new Class1();
                    m.Respuesta();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Usted ha decidido dejar su auto estacionado e irse para su casa");


                    Casa c = new Casa();
                    c.casa();

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
}
}