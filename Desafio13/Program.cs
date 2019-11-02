using System;

namespace Desafio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double verA = 0;
            double verB = 0;
            double verC = 0;
            string option;
            do {                
            Console.Clear();
            System.Console.WriteLine("Condição de existência de um triângulo.");
            System.Console.Write("Digite o primeiro lado: ");
            verA = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o segundo lado: ");
            verB = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o terceiro lado: ");
            verC = double.Parse(Console.ReadLine());
            if (((verA - verB) < (verC)) && ((verC) < (verA + verB)) && ((verA - verC) < (verB)) && ((verB) < (verA + verC)) && ((verB - verC) < (verA)) && ((verA) < (verB + verC)))
            {
                System.Console.WriteLine("Esse triângulo existe.");
            } else{
                System.Console.WriteLine("Esse triângulo não existe");
            }
            System.Console.WriteLine("Deseja repetir a operação (s/n)?");
            option = Console.ReadLine().ToLower();
            } while (option != "s");
        }
    }
}
