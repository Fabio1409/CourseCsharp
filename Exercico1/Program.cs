using System;
using System.Globalization;

namespace Exercio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            Console.WriteLine("Prodrutos:");
            Console.WriteLine("{0},cujo preço e $ {1:f2} ", produto1, preco1);
            Console.WriteLine($"{produto2},cujo preco e $ {preco2:f2}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Registro:{idade} anos de idade, codigo {codigo} e genero:{genero}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Medida com oito casas decimais:{0}",medida.ToString("f3",CultureInfo.InvariantCulture));

            // conversao dos tipos e casting

            float a = 6.1f;
            double b = a;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(b);
            Console.WriteLine("---------------------------------------------");

            double c = 9.5;
            float d = (float)c; // casting: transformando em casting.
            Console.WriteLine(d);
            Console.WriteLine("-------------------------------------------------");


            int t = 5;
            int i = 2;

            double resultado =  (double) t / i;
            Console.WriteLine(resultado);

        }
    }
}