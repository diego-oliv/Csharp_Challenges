using System;
using System.Collections.Generic;

namespace ZooLógico
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary < int, string > Animais = new Dictionary<int, string>()
            {
                {1, "Tubarão Martelo"},
                {2, "Tucano"},
                {3, "Arara"},
                {4, "Leão"},
                {5, "Orangotango"},
                {6, "Chimpanzé"},
                {7, "Pinguim"},
                {8, "Tartaruga"},
                {9, "Golfinho"}
            };

            List<string> Pasto = new List<string>();
            List<string> Gaiola = new List<string>();
            List <string> CasaEmArvore = new List<string>();
            List <string> CavernaDePedra = new List<string>();
            List <string> PiscinaGelada = new List<string>();
            List <string> Piscina = new List<string>();
            List <string> Aquario = new List<string>();

            Console.Clear();
            var codigo = 0;
            System.Console.WriteLine("===============================");
            System.Console.WriteLine("|  Bem- vindo ao Zoo Lógico!  |");
            System.Console.WriteLine("===============================");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o código do animal para saber sua jaula");
            foreach(string animal in Animais.Values)
            {
                System.Console.WriteLine($"{"",3} {++codigo}. {animal}");
            }
            var userOption = int.Parse(Console.ReadLine());

            switch (Animais[userOption])
            {

            }
        }
    }
}
