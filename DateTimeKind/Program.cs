using System;
using System.Globalization;

namespace DateKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);// Data e hora local

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc); // Data e hora universal

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D1 kind: " + d1.Kind);
            Console.WriteLine("D1 To Local: " + d1.ToLocalTime());
            Console.WriteLine("D1 To Utc: " + d1.ToUniversalTime());

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("D2: " + d2);
            Console.WriteLine("D2 kind: " + d2.Kind);
            Console.WriteLine("D2 To Local: " + d2.ToLocalTime());
            Console.WriteLine("D2 To Utc: " + d2.ToUniversalTime());

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("D3: " + d3);
            Console.WriteLine("D3 kind: " + d3.Kind);
            Console.WriteLine("D3 To Local: " + d3.ToLocalTime());
            Console.WriteLine("D3 To Utc: " + d3.ToUniversalTime());
        }
    }
}