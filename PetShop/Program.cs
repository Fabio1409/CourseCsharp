using PetShop;
using PetShop.Models;
using System;
using System.Globalization;


namespace ProjetoPetShop
{
    public class MenuPrincipal
    {

        public static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Cadastro();
            Console.WriteLine("******************************************");

            Animal animal = new Animal();
            animal.CadastroPet(pessoa);

            Console.WriteLine("******************************************");

            Funcionario funcionario = new Funcionario();
            funcionario.CadastrarFuncionario();

            Produto produto = new Produto();
            produto.CadastrarProduto();

            Console.WriteLine("Deseja adicionar algum serviço (Banho/Tosa): ");
            string adicionarServico = Console.ReadLine();

            // Tente converter a string para um valor do enum
            if (Enum.TryParse(adicionarServico, true, out Servico servicoEscolhido))
            {
                // Se a conversão foi bem-sucedida, use o switch para comparar o enum
                switch (servicoEscolhido)
                {
                    case Servico.banho:
                        Console.WriteLine("Você escolheu Banho.");
                        break;

                    case Servico.tosa:
                        Console.WriteLine("Você escolheu Tosa.");
                        break;

                    case Servico.clinicaVeterinaria:
                        Console.WriteLine("Você escolheu Clinica veterinaria:");
                        break;

                    case Servico.massagem:
                        Console.WriteLine("Você escolheu Massagem: ");
                        break;

                    case Servico.hotel:
                        Console.WriteLine("Você escolheu Hotel: ");
                        break;

                    case Servico.consultaVeterinaria:
                        Console.WriteLine("Você escolheu consulta veterinaria:");
                        break;

                    default:
                        Console.WriteLine("Serviço não reconhecido.");
                        
                        break;


                }
            }
            else
            {
                Console.WriteLine("Serviço não reconhecido. Tente novamente.");
            }
        }
    }


}
       

    }
}


