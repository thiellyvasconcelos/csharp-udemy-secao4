using System;

namespace Exercicio1
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        // Usando a Fórmula de Heron para calcular a área de um triângulo
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));  
        }
    }
}