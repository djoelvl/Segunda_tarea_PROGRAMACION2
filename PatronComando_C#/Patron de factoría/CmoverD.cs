using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_de_comando
{
    class CmoverD : Icomando
    {
        Carrito_de_control_remoto carro;

        public CmoverD(Carrito_de_control_remoto pcarro)
        {
            carro = pcarro;
        }
        public void ejecutar()
        {
            carro.MoverD();
        }
    }
}
