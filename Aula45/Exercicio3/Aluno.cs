using System;
using System.Globalization;

namespace Exercicio3
{
    class Aluno
    {
        public string Nome;
        public double Notas;

        public double VerificarNota(double nota)
        {
            if(nota >= 60.00)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                double calculo = 60.00 - nota;

                Console.WriteLine($"Reprovado!");
                Console.WriteLine($"Faltaram {calculo.ToString("F2", CultureInfo.InvariantCulture)} pontos");
            }

            return nota;
        }
    }
}
