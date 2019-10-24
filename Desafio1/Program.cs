using System;
using System.Globalization;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double medidaBase;
            double medidaAltura;
            double perimetroRetangulo;
            double areaRetangulo;
            double diagonalRetangulo;
            double pitagoras;
            System.Console.WriteLine("Estudo matemático de um retângulo!");
            System.Console.Write("Digite a medida da base: ");
            medidaBase = double.Parse(Console.ReadLine());
            System.Console.Write("Digite a medida da altura: ");
            medidaAltura = double.Parse(Console.ReadLine());
            if ((medidaAltura > 0) && (medidaBase > 0))
            {
                Console.Clear();
                perimetroRetangulo = ((2*medidaAltura) + (2*medidaBase));
                areaRetangulo = (medidaBase*medidaAltura);
                pitagoras = ((medidaAltura*medidaAltura) + (medidaBase*medidaBase));
                diagonalRetangulo = (Math.Sqrt(pitagoras));
                System.Console.WriteLine("O perímetro do retângulo é: " + perimetroRetangulo);
                System.Console.WriteLine("A área do retãngulo é: " + areaRetangulo);
                System.Console.WriteLine($"A diagonal do Retângulo é: {diagonalRetangulo}");
            } else
            {
                System.Console.WriteLine("Não é possível calcular com medidas negativas.");
            }
        }
    }
}
