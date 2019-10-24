using System;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float aux = 0;
            System.Console.Write("Digite o valor da variável A: ");
            a = float.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor da variável B: ");
            b = float.Parse(Console.ReadLine());
            aux = b;
            b = a;
            a = aux;
        }
    }
}
