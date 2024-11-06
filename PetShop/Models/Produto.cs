using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Produto
    {
        public Produto()
        {
        }

        public string nome {  get; set; }
        public string categoria {  get; set; }
        public double preco {  get; set; }
        public double qtdestoque {  get; set; }

       

        public Produto(string nome, string categoria, double preco, double qtdestoque)
        {
            this.nome = nome;
            this.categoria = categoria;
            this.preco = preco;
            this.qtdestoque = qtdestoque;
        }

        public void CadastrarProduto()
        {
            Console.WriteLine("Cadastrar Produto");
            Console.WriteLine("Nome do produto: ");
            nome = Console.ReadLine();
            Console.WriteLine("Nome do Produto: "+ nome);
            Console.WriteLine();

            Console.WriteLine("Categoria do Produto: ");
            categoria = Console.ReadLine();
            Console.WriteLine("Descrição do produto" + categoria);
            Console.WriteLine();

            Console.WriteLine("Preço do Produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Preço do Produto" + preco);
            Console.WriteLine();

            Console.WriteLine("Digite a Quantidade de Produtos: ");
            qtdestoque = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de Produtos" + qtdestoque);
        }
        


    }
}
