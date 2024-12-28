using System;
using System.Globalization;
using System.Threading.Channels;
namespace ProjetoProduto {
    class Principal
    {
        static void Main(string[]args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse (Console.ReadLine());
            Console.Write("Digite a Quantidade: ");

            p.Quantidade = int.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: "+ p);

            
            Console.WriteLine();
            Console.Write("Digite o numero de produto a ser adicionado");
            Console.WriteLine();

            int qte = int.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produto a ser Removido do estoque");
            Console.WriteLine();

            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + p);
        }
           
    }
}