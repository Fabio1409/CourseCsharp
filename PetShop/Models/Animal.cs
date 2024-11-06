using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Animal
    {
        string nome { get; set; }
        string especie { get; set; }
        string raca { get; set; }
        int idade { get; set; }
        string proprietario { get; set; }

        public Animal() { }

        public Animal(string nome, string especie, string raca, int idade, string proprietario)
        {
            this.nome = nome;
            this.especie = especie;
            this.raca = raca;
            this.idade = idade;
            this.proprietario = proprietario;

        }
        public void CadastroPet(Pessoa pessoa)
        {
            Console.WriteLine("Vamos cadastrar seu pet?  " +
                "Por favor entre com os dados do se pet!");

            Console.WriteLine("-------------------------------");

            Console.Write("Digite o nome do seu Pet: ");
            nome = Console.ReadLine();
            Console.WriteLine("O nome do seu Pet é: " + nome);

            Console.WriteLine("-------------------------------");

            Console.Write("Digite a espécie do seu Pet: ");
            especie = Console.ReadLine();
            Console.WriteLine("Seu Pet e da espécie é: " + especie);

            Console.WriteLine("-------------------------------");

            Console.Write("Digite a raça do seu Pet: ");
            raca = Console.ReadLine();
            Console.WriteLine("Seu pet é da raça: " + raca);

            Console.WriteLine("-------------------------------");

            Console.Write("Digite a idade do seu Pet: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"A idade do seu Pet è: {idade} anos");

            Console.WriteLine("-------------------------------");


            Console.WriteLine($"Senhor(s) {pessoa.nome} O cadastro do  Pet foi realizado com sucesso!!! ");
        }
    }
}
