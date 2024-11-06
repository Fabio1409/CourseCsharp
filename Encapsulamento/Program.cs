using System;
using System.Globalization;

namespace Encapsulamento
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10);

            produto.SetNome("TV 4K");
            Console.WriteLine(produto.GetNome()); // Pegar itens privados e preciso usar o metodo get
            Console.WriteLine(produto.GetPreco());
            Console.WriteLine(produto.GetQuantidade());

        }
    }
}
