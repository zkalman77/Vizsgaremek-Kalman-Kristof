using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Vilagbajnoksag
{
    public int Ev { get; set; }
    public string Rendezo { get; set; }
    public string Bajnok { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;


        Console.WriteLine("LABDARÚGÓ-VILÁGBAJNOKSÁGOK");
        Console.WriteLine("=========================");
        Console.WriteLine("Adatok feldolgozása: 1930–2022");

        List<Vilagbajnoksag> vbLista = new List<Vilagbajnoksag>();

        if (!File.Exists("focivb.txt"))
        {
            Console.WriteLine("\nHiba: A 'focivb.txt' fájl nem található!");
            Console.WriteLine("Nyomj meg egy gombot a kilépéshez...");
            Console.ReadKey();
            return;
        }

        string[] sorok = File.ReadAllLines("focivb.txt");

        foreach (string sor in sorok)
        {
            string[] adatok = sor.Split(';');
            if (adatok.Length >= 3)
            {
                Vilagbajnoksag vb = new Vilagbajnoksag();
                vb.Ev = int.Parse(adatok[0].Trim());
                vb.Rendezo = adatok[1].Trim();
                vb.Bajnok = adatok[2].Trim();

                vbLista.Add(vb);
            }
        }

        Console.WriteLine("Az adatok beolvasása sikeres!");

        
        Console.WriteLine();
        Console.WriteLine("4. feladat");
        Console.WriteLine($"A világbajnokságok száma: {vbLista.Count} db");



        Console.ReadKey();
    }
}