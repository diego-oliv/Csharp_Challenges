using System;
using System.Collections.Generic;

namespace Desafio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int num1, num2, num3;
            List<int> numbers = new List<int>();
            System.Console.WriteLine("Digite 3 Números:");
            System.Console.Write("1º número: ");
            num1 = int.Parse(Console.ReadLine());
            numbers.Add(num1);
            System.Console.Write("2º número: ");
            num2 = int.Parse(Console.ReadLine());
            numbers.Add(num2);
            System.Console.Write("3º número: ");
            num3 = int.Parse(Console.ReadLine());
            numbers.Add(num3);
            numbers.Sort();
            Console.Clear();
            System.Console.WriteLine("Em ordem crescente: ");
            foreach (int item in numbers)
            System.Console.WriteLine(item);
        }
    }
}
