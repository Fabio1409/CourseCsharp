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
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Aprendendo sobre TimeSpan");
            // Aprendendo sobre TimeSpan, que utiliza a unidade de Ticks

            TimeSpan t = new TimeSpan();// aprendendo sobre Ticks
            TimeSpan t1 = new TimeSpan(0, 1, 30); // zero horas, um minuto e meio 00:01:30
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 2, 11, 213);
            Console.WriteLine(t);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Usando modo TimeSpan um pouco mais avancado");
            TimeSpan t6 = TimeSpan.FromDays(1.5);// usando modo do timespam mais avancado 
            TimeSpan t7 = TimeSpan.FromHours(1.5);
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);
            TimeSpan t10 = TimeSpan.FromMicroseconds(1.5);
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            
        }
    }
}