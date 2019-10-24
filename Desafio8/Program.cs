using System;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, i, j;
            m = int.Parse(Console.ReadLine());
            for (i = 1; i <= m; i++)
            {
                for (j=1; j<=i; j++){
                    System.Console.WriteLine("*");
                }
            }
        }
    }
}
