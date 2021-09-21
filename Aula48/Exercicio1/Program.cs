using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula 48 (Exercício único) - Criar um conversor de moeda, utilizando membros estáticos

            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(dolar, cotacao);

            Console.WriteLine($"Valor a ser pago em reais: R${resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
