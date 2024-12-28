using System;
using System.Globalization;
namespace ExercicioPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa nome1, nome2;

            nome1 = new Pessoa();
            nome2 = new Pessoa();

            Console.WriteLine("Entre com o Primeiro nome e idade");
            nome1.Nome = Console.ReadLine();
            Console.WriteLine("Entre com sua idade");
            nome1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu Nome E: " + nome1.Nome);
            Console.WriteLine("Sua idade e:" + nome1.Idade);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Entre com o segundo nome e idade");
            nome2.Nome = Console.ReadLine();
            Console.WriteLine("Entre com sua idade");
            nome2.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu nome e: " + nome2.Nome);
            Console.WriteLine("Sua idade e: " +nome2.Idade);

            if (nome1.Idade >  nome2.Idade)
            {
                Console.WriteLine("Nome 01 e Maior"+ nome1.Nome);
            }
            else
            {
                Console.WriteLine("Nome 02 e maior:"+ nome2.Nome);
            }



        }
    }
}