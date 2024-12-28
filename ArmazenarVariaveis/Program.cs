using System;
using System.Globalization;
namespace ArmazenarVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            // cultureInfo serve para usar o ponto ao inver da virgula.

            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3],CultureInfo.InvariantCulture);


            Console.WriteLine("Voçê Digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("f2",CultureInfo.InvariantCulture));
            // sempre usar o cultureInfo nos prints tbm.
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Voce Digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}

