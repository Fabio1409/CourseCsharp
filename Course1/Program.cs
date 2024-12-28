using System;
using System.Globalization;

namespace Course1
{
    class Program
    {
        static void Main(string[] args)
        {

            char genero = 'F';
            int idade = 38;
            double saldo = 10.35784;
            string nome = "Maria";

            // Console.WriteLine(genero);
            // Console.WriteLine(idade);
            // Console.WriteLine(saldo);
            // Console.WriteLine(nome);
            // Console.WriteLine(saldo.ToString("f2")); // F2 serve para delimitar o numero de casas decimais do double
            // Console.WriteLine(saldo.ToString("f4")); // F4 serve para delimitar o numero de casas decimais do double
            //  Console.WriteLine(saldo.ToString("f4", CultureInfo.InvariantCulture)); // serve para miudar virgula para ponto
            // tecnica do placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais",nome,idade,saldo); // place Holder (2:f2) = casas decimais.
            // tecnica da interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2} reais ");
            //   concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("f2",CultureInfo.InvariantCulture) + " reais");

        }

    }
}
