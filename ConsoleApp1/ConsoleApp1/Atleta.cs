using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Atleta
    {
        // campi di un'automobile
        int età;
        string sport;
        string nome;
        int anniDiCariera;
        // Proprietà
        public int età
        {
            // getter
            get { return età; }
            // setter
            set { età = value; }
        }

        public int anniDiCariera
        {
            get { return anniDiCariera; }
            set { anniDiCariera = value; }
        }
    }
}
