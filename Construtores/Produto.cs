
using System.Globalization;

namespace Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public Produto() 
        { 
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;

        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;

        }

        public override string ToString()
        {
            return Nome
                + ", Custa $ "
                + Preco.ToString("f2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public override bool Equals(object? obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public static implicit operator Produto(Produto v)
        {
            throw new NotImplementedException();
        }
    }

}



