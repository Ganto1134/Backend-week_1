using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContoDay3
{
    internal class ContoCorrente
    {
        private string numeroConto;
        private string intestatario;
        private decimal saldo;
        private bool contoAperto;

        public ContoCorrente(string numeroConto, string intestatario)
        {
            this.numeroConto = numeroConto;
            this.intestatario = intestatario;
            this.saldo = 0;
            this.contoAperto = false;
        }

        public void ApriConto(decimal primoVersamento)
        {
            if (contoAperto)
            {
                Console.WriteLine($"Il conto di {intestatario} è già aperto.");
                return;
            }

            if (primoVersamento < 1000)
            {
                Console.WriteLine($"Il primo versamento per il conto di {intestatario} deve essere almeno 1000 euro.");
                return;
            }

            saldo = primoVersamento;
            contoAperto = true;
            Console.WriteLine($"Conto di {intestatario} aperto con successo. Saldo iniziale: {saldo} euro.");
        }

        public void FaiVersamento(decimal importo)
        {
            if (!contoAperto)
            {
                Console.WriteLine($"Il conto di {intestatario} non è aperto. Impossibile effettuare il versamento.");
                return;
            }

            saldo += importo;
            Console.WriteLine($"Versamento di {importo} euro effettuato con successo sul conto di {intestatario}. Saldo attuale: {saldo} euro.");
        }

        public void FaiPrelevamento(decimal importo)
        {
            if (!contoAperto)
            {
                Console.WriteLine($"Il conto di {intestatario} non è aperto. Impossibile effettuare il prelevamento.");
                return;
            }

            if (importo > saldo)
            {
                Console.WriteLine($"Saldo insufficiente per il prelevamento dal conto di {intestatario}.");
                return;
            }

            saldo -= importo;
            Console.WriteLine($"Prelevamento di {importo} euro effettuato con successo dal conto di {intestatario}. Saldo attuale: {saldo} euro.");
        }

        public decimal GetSaldo()
        {
            return saldo;
        }
    }
}
