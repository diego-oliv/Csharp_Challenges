using System;

namespace Desafio18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int impar;
            int limite;
            System.Console.Write("Digite um número para saber seus ímapres antecessores: ");
            limite = int.Parse(Console.ReadLine());
            for (int i = 0; i < limite; i++)
            {
                impar = i % 2;
                if(impar != 0){
                    System.Console.Write(i + " ");
                }
            }
        }
    }
}
