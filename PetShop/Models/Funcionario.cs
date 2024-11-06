using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PetShop.Models
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string funcao { get; set; }
        public string telefone { get; set; }

        public Endereco endereco { get; set; }
        public Funcionario() { }

        public Funcionario(string nome, string funcao, string telefone)
        {
            this.nome = nome;
            this.funcao = funcao;
            this.telefone = telefone;
            this.endereco = new Endereco();

            // amanhã cadastrar funcionario
        }
        public void CadastrarFuncionario()
        {
            Console.WriteLine("Cadastre aqui seu funcionário");

            Console.WriteLine("******************************************");

            Console.WriteLine("Digite o nome do funcionário que deseja cadastrar:");
            nome = Console.ReadLine();
            Console.WriteLine("O Funcionário chame-se: " + nome);

            Console.WriteLine("******************************************");

            Console.WriteLine("Qual a função do funcionário?: ");
            funcao = Console.ReadLine();
            Console.WriteLine($"Funcionário irá atuar na funçao {funcao}");

            Console.WriteLine("******************************************");

            Console.WriteLine("Telefone: ");
            telefone = Console.ReadLine();
            Console.WriteLine("Telefone:" + telefone);
            Console.WriteLine("******************************************");
            MontarEndereco();

        }
        public void MontarEndereco()
        {
            Endereco novoEndereco = new Endereco();

            Console.WriteLine("Digite o nome da Rua: ");
            novoEndereco.rua = Console.ReadLine();
            Console.WriteLine("Rua:" + novoEndereco.rua);
            Console.WriteLine("******************************************");

            Console.WriteLine("Digite o número da Rua: ");
            novoEndereco.numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero da Rua:" + novoEndereco.numero);
            Console.WriteLine("******************************************");

            Console.WriteLine("Complemento");
            novoEndereco.complemento = Console.ReadLine();
            Console.WriteLine("Complemento:" + novoEndereco.complemento);
            Console.WriteLine("******************************************");





            Console.WriteLine("Digite a Cidade: ");
            novoEndereco.cidade = Console.ReadLine();
            Console.WriteLine("Cidade:" + novoEndereco.cidade);
            Console.WriteLine("******************************************");

            Console.WriteLine("Digite o Bairro: ");
            novoEndereco.bairro = Console.ReadLine();
            Console.WriteLine("Bairro:" + novoEndereco.bairro);
            Console.WriteLine("******************************************");

            Console.WriteLine("Digite o Estado: ");
            novoEndereco.estado = Console.ReadLine();
            Console.WriteLine("Estado:" + novoEndereco.estado);
            Console.WriteLine("******************************************");

            Console.WriteLine("Digite o seu país de Origem: ");
            novoEndereco.pais = Console.ReadLine();
            Console.WriteLine("País de Origem:" + novoEndereco.pais);
            Console.WriteLine("******************************************");

        }
    }
}
