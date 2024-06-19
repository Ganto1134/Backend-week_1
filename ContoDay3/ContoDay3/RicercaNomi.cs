using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoDay3
{
    internal class RicercaNomi
    {
        public void EseguiRicerca()
        {
            try
            {
                Console.WriteLine("Inserisci il numero di nomi:");
                int n = int.Parse(Console.ReadLine());

                string[] nomi = new string[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Inserisci il nome {i + 1}:");
                    nomi[i] = Console.ReadLine();
                }

                Console.WriteLine("Inserisci il nome da ricercare:");
                string nomeDaRicercare = Console.ReadLine();

                bool trovato = false;
                foreach (string nome in nomi)
                {
                    if (nome.Equals(nomeDaRicercare, StringComparison.OrdinalIgnoreCase))
                    {
                        trovato = true;
                        break;
                    }
                }

                if (trovato)
                {
                    Console.WriteLine("Il nome è presente nell'array.");
                }
                else
                {
                    Console.WriteLine("Il nome non è presente nell'array.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
            }
           }
        }
}
