using System.Globalization;

namespace Construtores
{
    class program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre  com os dados do produto:' ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());*/

            Produto produto = new Produto(nome, preco);
            Produto produto1 = new Produto();

            Produto produto2 = new Produto()
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto2.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque ");
            qte = int.Parse(Console.ReadLine());
            produto2.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + produto2);
        
        }
    }
}
