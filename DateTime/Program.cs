using System;
using System.Globalization;


namespace DataHora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2024, 11, 07);
            DateTime d2 = new DateTime(2024, 11, 07, 21, 34, 42);

            DateTime d3 = DateTime.Parse("2024-11-07");
            DateTime d4 = DateTime.Parse("2024-11-07 21:41:59");

            DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d6 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            
        }
    }
}