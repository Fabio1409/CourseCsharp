using System;
using System.Globalization;

namespace Exercicio2
{

    class Program
    {
        static void Main(string[] args) // entre points
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura");

            string [] vetor = Console.ReadLine().Split(' ');
            string nome1 = vetor[0];
            int idade = int.Parse(vetor [1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            Console.WriteLine("seu nome E?");
            Console.WriteLine(nome);
            Console.WriteLine("Sua casa tem quantos quartos");
            Console.WriteLine(quartos);
            Console.WriteLine("Seu Produto custa!");
            Console.WriteLine(preco.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ultimo nome Digitado");
            Console.WriteLine(nome1);
            Console.WriteLine("Sua idade É?");
            Console.WriteLine(idade);
            Console.WriteLine("Sua altura E?");
            Console.WriteLine(altura.ToString("f2",CultureInfo.InvariantCulture));




        } // fecha entre points

    }
}
