using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Aula 45 (Exercício 3) - Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
                (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. 
                
                Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para 
                ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
                este problema.  */

            Aluno aluno = new Aluno();
            
            double notas = 0.0;

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Digite a nota {i} do aluno: ");
                aluno.Notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                notas += aluno.Notas;
            }

            Console.WriteLine();
            Console.WriteLine($"Nota final: {notas.ToString("F2", CultureInfo.InvariantCulture)}");
            aluno.VerificarNota(notas);
        }
    }
}