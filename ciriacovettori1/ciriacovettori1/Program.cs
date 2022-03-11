using System;

namespace ciriacovettori1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una app che carica un vettore di 400 elementi con valori casuali compresi tra 1 e 100 e stampi il contenuto del vettore*/
            
            Console.WriteLine("eserccizio vettori 1°");

            const int dimensione = 400;
            int[] vettore = new int[dimensione];
            


            Random generatore = new Random();
            
            for (int i =0; i < dimensione; i++)
            {
                vettore[i] = generatore.Next(1, 101);
            }

            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine(vettore[i]);
            }
        }

    }
}
