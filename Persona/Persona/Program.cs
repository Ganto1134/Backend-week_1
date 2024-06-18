using System;

public class Persona
{
    public string Nome { get; private set; }
    public string Cognome { get; private set; }
    public int Eta { get; private set; }

    public Persona(string nome, string cognome, int eta)
    {
        Nome = nome;
        Cognome = cognome;
        Eta = eta;
    }

    public string GetNome()
    {
        return Nome;
    }

    public string GetCognome()
    {
        return Cognome;
    }

    public int GetEta()
    {
        return Eta;
    }

    public string GetDettagli()
    {
        return $"Nome: {Nome}, Cognome: {Cognome}, Eta: {Eta}";
    }

    public static void Main(string[] args)
    {
        Persona persona = new Persona("Antonio", "Gantolea", 22);

        Console.WriteLine(persona.GetNome()); 
        Console.WriteLine(persona.GetCognome()); 
        Console.WriteLine(persona.GetEta()); 
        Console.WriteLine(persona.GetDettagli());
    }
}