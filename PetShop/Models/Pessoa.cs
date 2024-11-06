using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{


    public class Pessoa
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public Pessoa() { }


        public Pessoa(string nome, string endereco, string telefone, string email)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;

        }

        public  void Cadastro()
        {
            Console.WriteLine("Seja bem vindo ao meu petshop");

            Console.WriteLine("-------------------------------");
            
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + nome);

            Console.WriteLine("-------------------------------");

            Console.Write("Digite seu endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Seu endereço é: " + endereco);

            Console.WriteLine("-------------------------------");

            Console.Write("Digite seu email: " + email);
            email = Console.ReadLine();
            
            Console.WriteLine("-------------------------------");
        }
    }
}

