using System;
using System.Collections.Generic;
using System.Text;

namespace colas_umg.colalista
{
    class ColaConLista
    {
        protected Nodo frente;
        protected Nodo fin;

        //constructor; crear la cola vacia
        public ColaConLista()
        {
            frente = fin = null;
        }
        //verificar si la cola esta vacia
        public bool colaVacia() => frente == null;
        //insertar: pone elmento al final de la cola
        public void insertar(Object elemento)
        {
            Nodo a;
            a = new Nodo(elemento);
            if (colaVacia())
            {
                frente = a;
            }
            else
            {
                fin.siguiente = a;
            }
            fin = a;
        }
        //quitar un elemento 
        public Object quitar()
        {
            Object aux;
            if (!colaVacia())
            {
                aux = frente.elemento;
                frente = frente.siguiente;
            }
            else
            {
                throw new Exception("Error; la cola esta vacia");
            }
            return aux;
        }
        //vaciar la cola, liberar todos los nodos
        public void borrarCola()
        {
            for(; frente != null;)
            {
                frente = frente.siguiente;
            }
        }
        //devolver el valor que esta al frente de la cola
        public Object frenteCola()
        {
            if (colaVacia())
            {
                throw new Exception("Error: la cola esta vacia");
            }
            return (frente.elemento);
        }

    }
}
