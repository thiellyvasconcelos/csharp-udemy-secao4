using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            // Exemplo do uso da Properties criada na classe Produto -> Console.WriteLine(p.Nome);

            Console.WriteLine();
            Console.WriteLine($"Dados do produto: {p}");
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qnt = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qnt);
            Console.WriteLine($"Dados atualizados: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qnt = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qnt);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}