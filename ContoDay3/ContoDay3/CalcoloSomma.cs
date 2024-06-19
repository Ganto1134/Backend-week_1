using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoDay3
{
    internal class CalcoloSomma
    {
        public void CalcolaSommaEMedia()
        {
            Console.WriteLine("Inserisci la dimensione dell'array:");
            int dimensione = int.Parse(Console.ReadLine());

            int[] numeri = new int[dimensione];
            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine($"Inserisci il numero {i + 1}:");
                numeri[i] = int.Parse(Console.ReadLine());
            }

            int somma = 0;
            foreach (int numero in numeri)
            {
                somma += numero;
            }

            double media = (double)somma / dimensione;

            Console.WriteLine($"La somma di tutti i numeri è: {somma}");
            Console.WriteLine($"La media di tutti i numeri è: {media}");
        }
    }
}
