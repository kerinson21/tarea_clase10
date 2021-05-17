using System;
using System.Collections.Generic;
using System.Text;

namespace colas_umg.colalista
{
    class Nodo
    {
        public Object elemento;
        public Nodo siguiente;

        public Nodo (Object elemento)
        {
            this.elemento = elemento;
            siguiente = null;
        }
    }
}
