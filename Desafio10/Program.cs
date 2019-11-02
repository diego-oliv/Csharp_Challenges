using System;

namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double result;
            string repeat;
            do {
                Console.Clear();
                System.Console.WriteLine("Descubra os múltiplos de 3");
                System.Console.Write("Digite o número desejado: ");
                num = int.Parse(Console.ReadLine());
                result = (num % 3);
                if (result == 0)
                {
                    Console.Clear();
                    System.Console.WriteLine("Esse número é um múltiplo.");
                } else{
                    System.Console.WriteLine("Esse número não é múltiplo.");
                }
                System.Console.WriteLine("Deseja repetir (s/n)?");
                repeat = Console.ReadLine().ToLower();
            } while (repeat != "n");
        }
    }
}
