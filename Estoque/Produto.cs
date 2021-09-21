using System;
using System.Globalization;

namespace Estoque
{
    class Produto
    {
        private string _nome;
        private int _quantidade;

        // Fazendo uma Properties de Auto Properties (o set sera private para não poder ser alterado fora da classe)
        public double Preco { get; private set; }

        // Construtor padrão
        public Produto()
        {

        }

        // Construtor que recebe os 3 argumentos
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }

        // Construtor com sobrecarga (utilizando o this para diferenciar os atributos de variáveis locais)
        public Produto(string Nome, double Preco)
        {
            this._nome = Nome;
            this.Preco = Preco;
            _quantidade = 0; // Didádico (retornará mesmo que o mesmo não tenha sido adicionado nos parâmetros)
        }

        // Usando Properties para alterar ou mostrar os atributos no programa principal        
        public string Nome 
        {
            // Retornando o valor apenas
            get { return _nome; }
            
            // Fazendo uma condição para alterar o nome do atributo private
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _quantidade * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
                
        public override string ToString()
        {
            return $"{_nome}, R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades." +
                $"\nValor total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}