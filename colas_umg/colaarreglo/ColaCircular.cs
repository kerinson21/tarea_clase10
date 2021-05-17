using System;
using System.Collections.Generic;
using System.Text;

namespace colas_umg.colaarreglo
{
    class ColaCircular
    {
        private static int fin;
        private static int _MAXTAMQ = 99;
        protected int frente;

        protected Object[] listaCola;

        //avanza una posicion
        private int siguiente(int r)
        {
            return (r + 1) % _MAXTAMQ;
        }
        //CONSTRUTOR 
        public ColaCircular()
        {
            frente = 0;
            fin = _MAXTAMQ - 1;
            listaCola = new Object[_MAXTAMQ];
        }
        //validaciones
        public bool colaVacia() => frente == siguiente(fin);

        public bool colaLlena() => frente == siguiente(siguiente(fin));

        //operaciones de codificacion de cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                fin = siguiente(fin);
                listaCola[fin] = elemento;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }
        //quitar elemento 
        public Object quitar()
        {
            if (!colaVacia())
            {
                Object ta = listaCola[frente];
                frente = siguiente(frente);
                return ta;
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }

        public void borrarCola()
        {
            frente = 0;
            fin = _MAXTAMQ - 1; 
        }
        //obtener el valor de frente 
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }

    }
}
