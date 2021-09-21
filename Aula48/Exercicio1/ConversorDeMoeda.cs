using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class ConversorDeMoeda

    {
        public static double Iof = 6.0;   

        public static double DolarParaReal(double dolar, double cotacao)
        {
            double total = dolar * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}