using colas_umg.colaarreglo;
using colas_umg.pilalista;
using System;

namespace colas_umg
{
    class Program
    {
        public static void esCapicula_UMG()
        {
            //programa capicua

            bool capicua;
            string numero;
            Ejercicios ejercicios = new Ejercicios();
            PilaLista pila = new PilaLista();
            ColaCircular colaCircular = new ColaCircular();

            try
            {
                capicua = false;
                while (!capicua)
                {
                    do
                    {
                        Console.WriteLine("\nTeclee un numero: ");
                        numero = Console.ReadLine();
                    } while (!ejercicios.valido(numero));
                    //pone en la cola y en la pila cada digito
                    for (int i = 0; i < numero.Length; i++)
                    {
                        char c;
                        c = numero[i];
                        colaCircular.insertar(c);
                        pila.insertar(c);
                    }
                    //se retira de la cola y pila para comparar
                    do
                    {
                        char d;
                        d = (char)colaCircular.quitar();
                        capicua = d.Equals(pila.quitar());
                    } while (capicua && !colaCircular.colaVacia());
                    if (capicua)
                    {
                        Console.WriteLine($"Numero {numero} es capicua");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {numero} no es capicua");
                        Console.WriteLine("Intente otro");
                    }
                    //vaciar estructuras
                    colaCircular.borrarCola();
                    pila.limpiarPila();

                }
                
            }
            catch (Exception errores)
            {
                Console.WriteLine($"Eror en {errores.Message}");
            }
        }
        static void Main(string[] args)
        {
            Ejercicios ejercicios = new Ejercicios();
            ejercicios.esCapitua_Stack_Queue();
        }
    }
}
