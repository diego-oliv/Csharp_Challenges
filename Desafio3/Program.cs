using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo;
            double tempoConvertido;
            double velocidadeMedia;
            double distancia;
            double gasosa;
            System.Console.WriteLine("Cálculo do combustível gasto em uma viagem!");
            System.Console.Write("Informe o tempo (em minutos) gasto na viagem: ");
            tempo = double.Parse(Console.ReadLine());
            System.Console.Write("Informe a velocidade média (em km/h) da viagem: ");
            velocidadeMedia = double.Parse(Console.ReadLine());
            tempoConvertido = (tempo/60);
            distancia = (tempoConvertido * velocidadeMedia);
            gasosa = (distancia / 12);
            System.Console.WriteLine("A distância percorrida foram: " + distancia + " quilômetros.");
            System.Console.WriteLine("Foram gastos " + gasosa + " litros de combustível.");
        }
    }
}
