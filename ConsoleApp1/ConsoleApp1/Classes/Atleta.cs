using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Atleta
    {
        int eta;
        string sport;
        string nome;
        int anniDiCariera;
        public int Eta
        {
            get { return eta; }
            set { eta = value; }
        }

        public int AnniDiCariera
        {
            get { return anniDiCariera; }
            set { anniDiCariera = value; }
        }
    }
}
