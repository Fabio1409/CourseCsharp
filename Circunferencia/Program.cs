using System;
using System.Globalization;


namespace Circunferencia
{
    class Program
    {



        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferência(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("f2", CultureInfo.InvariantCulture));
        }


    }
}


