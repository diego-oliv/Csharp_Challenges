using System;

namespace Desafio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string nome;
            double alturaCM = 0;
            double alturaM = 0;
            double peso = 0;
            double IMC = 0;
            System.Console.WriteLine("Calcule o seu Índice de Massa Corporal (IMC).");
            System.Console.Write("Olá, por favor identifique-se: ");
            nome = Console.ReadLine();
            System.Console.Write("Digite seu peso (em kg): ");
            peso = double.Parse(Console.ReadLine());
            System.Console.Write("Digite sua altura (em cm): ");
            alturaCM = double.Parse(Console.ReadLine());
            alturaM = (alturaCM / 100);
            IMC = (peso / (alturaM*alturaM));
            if (IMC <= 20)
            {
                System.Console.WriteLine("Seu IMC é: " + IMC);
                System.Console.WriteLine(nome + ", você está abaixo do peso.");
            } else if ((IMC > 20) && (IMC <= 25)){
                System.Console.WriteLine("Seu IMC é: " + IMC);
                System.Console.WriteLine(nome + ", você está com o peso normal.");
            } else if ((IMC > 25) && (IMC <= 30)){
                System.Console.WriteLine("Seu IMC é: " + IMC);
                System.Console.WriteLine(nome + ", você está com excesso de peso.");
            } else if ((IMC > 30) && (IMC <= 35)){
                System.Console.WriteLine("Seu IMC é: " + IMC);
                System.Console.WriteLine(nome + ", você está obeso.");
            } else if (IMC > 35){
                System.Console.WriteLine("Seu IMC é: " + IMC);
                System.Console.WriteLine(nome + ", você está com obesidade mórbida.");
            }
        }
    }
}
