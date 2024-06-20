using auth;
using System;

namespace LoginSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1.: Login");
                Console.WriteLine("2.: Logout");
                Console.WriteLine("3.: Verifica ora e data di login");
                Console.WriteLine("4.: Lista degli accessi");
                Console.WriteLine("5.: Esci");
                Console.WriteLine("========================================");

                Console.Write("Inserisci il numero dell'operazione: ");
                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        EffettuaLogin();
                        break;
                    case "2":
                        EffettuaLogout();
                        break;
                    case "3":
                        VerificaLogin();
                        break;
                    case "4":
                        ListaAccessi();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Operazione non valida. Premi un tasto per continuare...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void EffettuaLogin()
        {
            Console.Clear();
            Console.Write("Inserisci username: ");
            string username = Console.ReadLine();
            Console.Write("Inserisci password: ");
            string password = Console.ReadLine();
            Console.Write("Conferma password: ");
            string confermaPassword = Console.ReadLine();

            if (Utente.Login(username, password, confermaPassword))
            {
                Console.WriteLine("Login effettuato con successo!");
            }
            else
            {
                Console.WriteLine("Login fallito. Assicurati che username sia inserito e che le password coincidano.");
            }
            Console.WriteLine("Premi un tasto per continuare...");
            Console.ReadKey();
        }

        static void EffettuaLogout()
        {
            Console.Clear();
            if (Utente.Logout())
            {
                Console.WriteLine("Logout effettuato con successo!");
            }
            else
            {
                Console.WriteLine("Nessun utente loggato.");
            }
            Console.WriteLine("Premi un tasto per continuare...");
            Console.ReadKey();
        }

        static void VerificaLogin()
        {
            Console.Clear();
            string loginInfo = Utente.VerificaLogin();
            Console.WriteLine(loginInfo);
            Console.WriteLine("Premi un tasto per continuare...");
            Console.ReadKey();
        }

        static void ListaAccessi()
        {
            Console.Clear();
            string[] accessi = Utente.ListaAccessi();
            Console.WriteLine("Lista degli accessi:");
            foreach (string accesso in accessi)
            {
                Console.WriteLine(accesso);
            }
            Console.WriteLine("Premi un tasto per continuare...");
            Console.ReadKey();
        }
    }
}

