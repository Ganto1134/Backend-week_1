namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta a = new Atleta();
            a.età = 22;
            Console.WriteLine(a.età);
            Dipendente b = new Dipendente();
            b.nome = 'Antonio';
            Console.WriteLine(b.nome);
            Animale c = new Animale();
            c.specie = 'Cane';
            Console.WriteLine(c.specie);
            Veicolo d = new Veicolo();
            d.marca = 'Fiat';
            Console.WriteLine(d.marca);
        }
    }
}
