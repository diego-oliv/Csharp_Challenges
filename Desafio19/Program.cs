using System;

namespace Desafio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int arrayLimite;
            System.Console.Write("Digite o tamanho da matriz: ");
            arrayLimite = int.Parse(Console.ReadLine());
            int[] vetor = new int[arrayLimite];
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.Write($"Digite o {i+1}º valor da matriz: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            System.Console.WriteLine("A matriz tem os valores: ");
            for (int i = 0; i < vetor.Length; i++) {
                System.Console.WriteLine($"{i+1} - {vetor[i]}");
            }
        }
    }
}
