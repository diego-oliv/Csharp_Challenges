using System;

namespace Desafio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int impar;
            for (int i = 1; i < 10; i++)
            {
                impar = i % 2;
                if(impar != 0){
                    System.Console.Write(i + " ");
                }
            }
        }
    }
}
