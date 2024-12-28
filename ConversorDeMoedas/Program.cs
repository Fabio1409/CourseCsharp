using System;
using System.Globalization;

namespace ConversorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares voçê vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("f2",CultureInfo.InvariantCulture));


        }
    }
}
