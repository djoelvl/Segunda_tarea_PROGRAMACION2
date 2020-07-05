using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_de_comando
{
    class Carrito_de_control_remoto
    {
        public void encender()
        {
            Console.Clear();
            Console.WriteLine("El Carrito se ha encendido");
            Principal a = new Principal();
            a.Encendido();
            
        }

        public void Apagar()

        {
            Console.Clear();

            Console.WriteLine("El Carrito se ha apagado");
            Principal a = new Principal();
            a.Apagado();
        }

        public void MoverI()
        {
            Console.Clear();
            Console.WriteLine("El Carrito se ha movido hacia la izquierda");
            Principal a = new Principal();
            a.Encendido();
        }

        public void MoverD()
        {
            Console.Clear();
            Console.WriteLine("El Carrito se ha movido hacia la derecha");
            Principal a = new Principal();
            a.Encendido();
        }


        public void retroceder()
        {
            Console.Clear();
            Console.WriteLine("El Carrito se ha retrocedido");
            Principal a = new Principal();
            a.Encendido();
        }

        public void avanzar()
        {
            Console.Clear();
            Console.WriteLine("El Carrito ha avanzado");
            Principal a = new Principal();
            a.Encendido();
        }




    }
}
