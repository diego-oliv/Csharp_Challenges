using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float c;
            float f;
            System.Console.WriteLine("Transformação de centígrados em Fahreinheit");
            System.Console.Write("Digite a temperatura em centígrados: ");
            c = float.Parse(Console.ReadLine());
            f = ((9*c + 160) / 5);
            System.Console.WriteLine("A temperatura em Fahreinheit é: " + f);
        }
    }
}
