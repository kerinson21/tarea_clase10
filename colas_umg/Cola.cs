using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace colas_umg
{
    class Cola
    { 
        public void prueba()
        {
            Queue qt = new Queue();

            qt.Enqueue("Hola");
            qt.Enqueue("esta");
            qt.Enqueue("es");
            qt.Enqueue("una");
            qt.Enqueue("prueba");

            Console.WriteLine($"La cola tiene {qt.Count}");
        }
    }
}
