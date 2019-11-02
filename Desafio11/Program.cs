using System;

namespace Desafio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string[] Nomes = new string[2];
            for (int i = 0; i < Nomes.Length; i++)
            {
                System.Console.Write($"Digite o {i+1}º nome: ");
                Nomes[i] = Console.ReadLine();
            }
            StringComparer pi = StringComparer.OrdinalIgnoreCase;
            Array.Sort(Nomes, pi);
            Console.Clear();
            System.Console.WriteLine("Em ordem alfabética: ");
            for (int i = 0; i < Nomes.Length; i++)
            System.Console.WriteLine(Nomes[i]);
        }
    }
}
