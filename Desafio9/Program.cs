using System;

namespace Desafio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double pesoTerra;
            double pesoPlaneta;
            string planeta;
            System.Console.WriteLine("Conversão peso através da gravidade relativa.");
            System.Console.Write("Digite o peso desejado (da Terra) em kg: ");
            pesoTerra = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Agora digite o planeta desejado:");
            System.Console.WriteLine("1 - Mercúrio");
            System.Console.WriteLine("2 - Vênus");
            System.Console.WriteLine("3 - Marte");
            System.Console.WriteLine("4 - Júpiter");
            System.Console.WriteLine("5 - Saturno");
            System.Console.WriteLine("6 - Urano");
            planeta = Console.ReadLine();
            switch (planeta)
            {
                case "1":
                Console.Clear();
                double mercurio = 3.7;
                pesoPlaneta = ((pesoTerra/10) * (mercurio));
                System.Console.WriteLine("O peso em Mercúrio é: " + pesoPlaneta);
                break;
                case "2":
                double venus = 8.7;
                Console.Clear();
                pesoPlaneta = ((pesoTerra/10) * (venus));
                System.Console.WriteLine("O peso em Vênus é: " + pesoPlaneta);
                break;
                case "3":
                double marte = 3.8;
                Console.Clear();
                pesoPlaneta = ((pesoTerra/10) * (marte));
                System.Console.WriteLine("O peso em Marte é: " + pesoPlaneta);
                break;
                case "4":
                Console.Clear();
                double jupiter = 26.4;
                pesoPlaneta = ((pesoTerra/10) * (jupiter));
                System.Console.WriteLine("O peso em Júpiter é: " + pesoPlaneta);
                break;
                case "5":
                Console.Clear();
                double saturno = 10.44;
                pesoPlaneta = ((pesoTerra/10) * (saturno));
                System.Console.WriteLine("O peso em Saturno é: " + pesoPlaneta);
                break;
                case "6":
                Console.Clear();
                double urano = 8.69;
                pesoPlaneta = ((pesoTerra/10) * (urano));
                System.Console.WriteLine("O peso em Urano é: " + pesoPlaneta);
                break;
                default:
                System.Console.WriteLine("Digite um número válido.");
                break;
            }            
        }
    }
}
