using System;
using System.Collections.Generic;

namespace Desafio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary < int, string > littleWhite = new Dictionary < int, string >();
            littleWhite.Add(1, "Janeiro");
            littleWhite.Add(2, "Fevereiro");
            littleWhite.Add(3, "Março");
            littleWhite.Add(4, "Abril");
            littleWhite.Add(5, "Maio");
            littleWhite.Add(6, "Junho");
            littleWhite.Add(7, "Julho");
            littleWhite.Add(8, "Agosto");
            littleWhite.Add(9, "Setembro");
            littleWhite.Add(10, "Outubro");
            littleWhite.Add(11, "Novembro");
            littleWhite.Add(12, "Dezembro");
            Console.Clear();
            int mes;
            System.Console.Write("Digite o número do mês: ");
            mes = int.Parse(Console.ReadLine());
            if ((mes >= 1) && (mes <= 12))
            {
                System.Console.WriteLine("Esse número corresponde ao mês de " + littleWhite[mes]);
            } else {
                System.Console.WriteLine("Não existe mês com o número fornecido.");
            }
        }
    }
}
