using System;
using System.Collections.Generic;
using System.Text;

namespace colas_umg.pilalista
{
    class PilaLista
    {
        private static int INICIAL = 19;
        private int cima;
        private List<Object> listaPila;

        public PilaLista()
        {
            cima = -1;
            listaPila = new List<Object>();
        }
        public void insertar(Object elemento)
        {
            cima++;
            listaPila.Add(elemento);
        }
        public Object quitar()
        {
            Object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila Vaica");
            }
            aux = listaPila[cima];
            listaPila.RemoveAt(cima);
            cima--;
            return aux;
        }
        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia, no se puede sacar elemento");
            }
            return listaPila[cima];
        }
        public void limpiarPila()
        {
            while (!pilaVacia())
            {
                quitar();
            }
        }
        private bool pilaVacia() => cima == -1;
    }
}
