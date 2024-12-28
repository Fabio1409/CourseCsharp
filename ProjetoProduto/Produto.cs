using System;
using System.Globalization;

namespace ProjetoProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade +=  + quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= + quantidade;
        }
        public override string ToString() // Override indica que veio de outra classe
        {
            return Nome 
                + ", $ " + Preco.ToString("f2", CultureInfo.InvariantCulture)
                + " , "
                + Quantidade
                + " Unidades, Total: $  "
                + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
