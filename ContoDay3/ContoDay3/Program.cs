using System;

namespace ContoDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test della classe ContoCorrente
            Console.WriteLine("Test della classe ContoCorrente");

            ContoCorrente[] conti = new ContoCorrente[]
            {
                new ContoCorrente("12345", "Mario Rossi"),
                new ContoCorrente("12346", "Luigi Bianchi"),
                new ContoCorrente("12347", "Carla Verdi")
            };

            foreach (var conto in conti)
            {
                conto.ApriConto(500); 
                conto.ApriConto(1000); 
                conto.FaiVersamento(200); 
                conto.FaiPrelevamento(300);  
                conto.FaiPrelevamento(1000);  
                Console.WriteLine($"Saldo attuale di {conto.GetSaldo()} euro\n");
            }

            Console.WriteLine("\nTest dell'algoritmo di ricerca di un nome");
            RicercaNomi ricercaNomi = new RicercaNomi();
            ricercaNomi.EseguiRicerca();

            Console.WriteLine("\nTest dell'algoritmo per somma e media di numeri interi");
            CalcoloSomma sommaEMedia = new CalcoloSomma();
            sommaEMedia.CalcolaSommaEMedia();
        }
    }
}
