using colas_umg.colalista;
using System;
using System.Collections.Generic;
using System.Text;

namespace colas_umg.bicola
{
    class Bicola: ColaConLista
    {
        //inserte por el final de la bicola
        public void insertarFinal(Object elemento)
        {
            insertar(elemento);
        }
        //insertar al frente
        public void insertarFrente(Object elemento)
        {
            Nodo a;
            a = new Nodo(elemento);
            if (colaVacia())
            {
                fin = a;
            }
            a.siguiente = frente;
            frente = a; 
        }
        //quitar elemento
        public Object quitarFrente()
        {
            return quitar();
        }
        //requitar elemento al final
        //metodo propio de bicola
        //es necesario hacer una iteracion de la bicola para 
        //llegar del nodo anteriro al final, para despues enlazar y ajustar la ocla
        public Object quitarFinal()
        {
            Object aux;
            if (!colaVacia())
            {
                if (frente == fin)//la bicola solo tiene un nodo
                {
                    aux = quitar();
                }
                else
                {
                    //como no tiene elementos vamos a iterar
                    Nodo a = frente;
                    while(a.siguiente != fin)
                    {
                        a = a.siguiente;
                    }
                    //siguiente del nodo anterior lo vamos aponer en null
                    a.siguiente = null;
                    aux = fin.elemento;
                    fin = a;
                }
            }
            else
            {
                throw new Exception("Error: la cola esta vacia");
            }
            return aux;
        }
        //retorna el valor que se encuentra en el primer elemento o frente de la cola
        public Object frenteBicola()
        {
            return frenteCola();
        }
        //devolvemos el final de la cola
        public Object finalBicola()
        {
            if (colaVacia())
            {
                throw new Exception("Error: cola vacia");
            }
            return (fin.elemento);
        }
        //retorna si esta  vacia la cola
        public bool biColaVacia() => colaVacia();
        //borrar la bicola
        public void borrarBicola() => borrarCola();

        //conteo de elementos
        public int numElementoBicola()
        {
            int n;
            Nodo a = frente;
            if (biColaVacia())
            {
                n = 0;
            }
            else
            {
                n = 1;
                while (a != fin)
                {
                    n++;
                    a = a.siguiente;
                }
            }
            return n;
        }
    }
}
