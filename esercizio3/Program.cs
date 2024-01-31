using System;
using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main(string[] args)
    {
        ContoCorrente Conto1 = new ContoCorrente();

        Conto1.aperturaConto(5000);
        Conto1.Versamento(300);
        Conto1.Prelievo(2800);


        //esercizio 2
        string[] ElencoNomi = { "Mario", "Simone", "Lucia", "Francesca", "Carla" };
        Console.Write("Inserisci un nome da cercare: ");
        string Cerca = Console.ReadLine();

        bool nomeCheck = false;

        for (int i = 0; i < ElencoNomi.Length; i++)
        {
            if (ElencoNomi[i] == Cerca)
            {
                nomeCheck = true;
                break;
            }
        }

        if (nomeCheck)
        {
            Console.WriteLine($"Il nome {Cerca} è presente nell'array");
        }

        else
        {
            Console.WriteLine($"Il nome {Cerca} non è presente nell'array");
        }

        //esercizio 3
        int somma = 0;
        int quantitàNumeri = 0;

        while (true)
        {
            Console.WriteLine("Inserisci i numeri. Inserisci 'fine' per terminare");
            string input = Console.ReadLine();

            if (input == "fine")
            {
                break;
            }

            if (int.TryParse(input, out int numero))
            {
                somma += numero;
                quantitàNumeri++;
            }
            else
            {
                Console.WriteLine("Inserimento non valido. Inserisci un numero valido o 'fine' per terminare.");
            }
        }

        if (quantitàNumeri > 0)
        {
            int media = somma / quantitàNumeri;
            Console.WriteLine($"Somma: {somma}");
            Console.WriteLine($"Media: {media}");
        }
        else
        {
            Console.WriteLine("Nessun numero inserito.");
        }

    }
}

public class ContoCorrente
{
    private bool contoCheck;
    private int saldo;

    public ContoCorrente() {
        contoCheck = false;
        saldo = 0;
    }

    public void aperturaConto (int versamentoIniziale)
    {
        if (contoCheck)
        {
            Console.WriteLine("Il conto è gia aperto");
        }

        else if (versamentoIniziale >= 1000)
        {
            contoCheck = true;
            saldo += versamentoIniziale;
            Console.WriteLine($"Conto creato correttamente. Saldo rimanente: {saldo} euro");
        }

        else
        {
            Console.WriteLine("Versa almeno 1000 euro per aprire il conto");
        }
    }

    public void Versamento(int importoVersamento)
    {
        if (contoCheck)
        {
            saldo += importoVersamento;
            Console.WriteLine($"Versamento di {importoVersamento} effettuato. Saldo rimanente: {saldo} ");
        }

        else
        {
            Console.WriteLine("Aprire il conto per effettuare un versamento");
        }
    }

    public void Prelievo (int importoPrelievo)
    {
        if (contoCheck) { 

            if (saldo >= importoPrelievo) {
                saldo -= importoPrelievo;
                Console.WriteLine($"Hai ritirato {importoPrelievo}. Saldo rimanente: {saldo}");
            }

            else
            {
                Console.WriteLine("Saldo insufficiente");
            }
        }

        else
        {
            Console.WriteLine("Aprire il conto per effettuare un versamento");
        }
    }
}
