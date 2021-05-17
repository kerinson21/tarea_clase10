using System;
using System.Collections.Generic;
using System.Text;

namespace colas_umg.colaarreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int _MAXTAMQ = 39;
        protected int frente;


        protected Object[] listaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new Object[_MAXTAMQ];
        }

        // operaciones para trabajar con datos en la cola
        //insertar
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                listaCola[++fin] = elemento; 
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }
        public bool colaLlena()
        {
            return fin == _MAXTAMQ - 1;
        }
        public bool colaVacia()
        {
            return frente > fin;
        }
        //quitar elemento de la cola
        public Object quitar()
        {
            if (!colaVacia())
            {
                return listaCola[frente++];
            }else
            {
                throw new Exception("Cola Vacia");
            }
        }
        //limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }
        //acceder a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }else
            {
                throw new Exception("Cola vacia");
            }
        }
        //
    }
}
