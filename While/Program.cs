using System;
using System.Globalization;
namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("f3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro numero");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Negative Number!");
        }
    }
}


