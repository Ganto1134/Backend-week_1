using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    internal class Dipendente
    {
        string nome;
        string posizione;
        double stipendio;

        public string Posizione
        {
            get { return posizione; }
            set { posizione = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
