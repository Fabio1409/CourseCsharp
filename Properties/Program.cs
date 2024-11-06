using System;
using System.Globalization;
namespace Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 500.00, 10); // Construtores pode ser colocados na instanciação
            produto.Nome = "TV 4K";

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);
            Console.WriteLine(produto.Quantidade);
        }
    }
}