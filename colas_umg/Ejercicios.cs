using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace colas_umg
{
    class Ejercicios
    {
        public bool valido(String numero)
        {
            bool sw = true;
            int i = 0;
            while(sw && (i< numero.Length))
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }

        public void esCapitua_Stack_Queue()
        {
            bool capicua;
            string numero;
            Stack<char> pila = new Stack<char>();
            Queue<Char> cola = new Queue<Char>();

            try
            {
                capicua = false;

                do
                {
                    Console.WriteLine("\nDigite un numero: ");
                    numero = Console.ReadLine();
                } while (!valido(numero));

                //ponemos en la pila y en la cola cada digito 
                for(int i = 0; i < numero.Length; i++)
                {
                    char c;
                    c = numero[i];
                    pila.Push(c);//inserta en la pila
                    cola.Enqueue(c);//inserta en la cola
                }
                //se retira de la cola y de la pila para comparar
                do
                {
                    char d;
                    d = cola.Dequeue();
                    capicua = d.Equals(pila.Pop());
                } while (capicua && cola.Count != 0);

                if (capicua)
                {
                    Console.WriteLine($"Numero {numero} es capicua");
                }
                else
                {
                    Console.WriteLine($"Numero {numero} no es capicua");
                    Console.WriteLine("Intente otro");
                }
                //vaciar las estructuras
                pila = new Stack<char>();
                cola = new Queue<char>();

            }
            catch(Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }
        }


    }
}
