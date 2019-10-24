using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            string sair;
            do{
                Console.Clear();
                System.Console.WriteLine("Par ou ímpar?");
                System.Console.Write("Digite um número: ");
                num = float.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    {
                        Console.Clear();
                        System.Console.WriteLine($"O número {num} é par.");
                    } else{
                        Console.Clear();
                        System.Console.WriteLine($"O número {num} é ímpar.");
                    }
                    System.Console.WriteLine("Deseja repetir (s/n)?");
                    sair = Console.ReadLine().ToLower();
            } while (sair == "s");
        }
    }
}
