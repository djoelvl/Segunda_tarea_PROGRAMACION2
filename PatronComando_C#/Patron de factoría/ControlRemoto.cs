using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_de_comando
{
    class ControlRemoto
    {
        private Icomando[] comando = new Icomando[6];
        public ControlRemoto(Carrito_de_control_remoto pcarro)
        {
            comando[0] = new encender(pcarro);
            comando[1] = new CApagar(pcarro);
            comando[2] = new cAvanzar(pcarro);
            comando[3] = new Retroceder(pcarro);
            comando[4] = new CMoveri(pcarro);
            comando[5] = new CmoverD(pcarro);
        }

        public void Button (int i)
        {
            comando[i].ejecutar();
        }
    }
}
