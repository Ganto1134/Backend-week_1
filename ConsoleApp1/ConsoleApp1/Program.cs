using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta a = new Atleta();
            a.Eta = 22;
            Console.WriteLine(a.Eta);
            Dipendente b = new Dipendente();
            b.Nome = "Antonio";
            Console.WriteLine(b.Nome);
            Animale c = new Animale();
            c.Specie = "Cane";
            Console.WriteLine(c.Specie);
            Veicolo d = new Veicolo();
            d.Marca = "Fiat";
            Console.WriteLine(d.Marca);
        }
    }
}
