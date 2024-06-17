using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dipendente
    {
        string nome;
        string posizione;
        double stipendio;

        public string posizione
        {
            // getter
            get { return posizione; }
            // setter
            set { posizione = value; }
        }

        public string nome 
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
