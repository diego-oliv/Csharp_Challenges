using System;

namespace Desafio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string verbo;
            string infinitivo1 = "ar";
            string infinitivo2 = "er";
            string infinitivo3 = "ir";
            string infinitivo4 = "or";
            bool conj1;
            bool conj2;
            bool conj3;
            bool conj4;
            System.Console.Write("Digite um verbo: ");
            verbo = Console.ReadLine();
            conj1 = verbo.Contains(infinitivo1);
            conj2 = verbo.Contains(infinitivo2);
            conj3 = verbo.Contains(infinitivo3);
            conj4 = verbo.Contains(infinitivo4);
            if (conj1) 
            {
                System.Console.WriteLine("Esse verbo é da primeira conjugação.");
            } else if (conj2){
                System.Console.WriteLine("Esse verbo é da segunda conjugação");
            } else if (conj3){
                System.Console.WriteLine("Esse verbo é da terceira conjugação");
            } else if (conj4){
                System.Console.WriteLine("Esse verbo é irregular.");
            } else {
                System.Console.WriteLine("Esse verbo não está no infinitivo.");
            }
        }
    }
}
