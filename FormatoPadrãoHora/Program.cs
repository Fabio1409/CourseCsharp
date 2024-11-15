using System;

namespace PadraoHora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");// Mostra a hora Instanciada
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");// Formato ISO 8601 usa a hora local


            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D1: " + d1.Kind);
            Console.WriteLine("D1: " + d1.ToLocalTime());
            Console.WriteLine("D1: " + d1.ToUniversalTime());

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("D2: " + d2);
            Console.WriteLine("D2: " + d2.Kind);
            Console.WriteLine("D2: " + d2.ToLocalTime());
            Console.WriteLine("D2: " + d2.ToUniversalTime());


            Console.WriteLine("---------------------------------------");

            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));//cuidado este formato e errado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

        }
    }
}