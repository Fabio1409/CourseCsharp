using System;
using System.Globalization;

namespace PropiedadesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 235);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);// Mostra data, nao caso 15/08/2001.
            Console.WriteLine("2) Day: " + d.Day); //  Mostra o dia
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek); // Mostra qual dia da semana.
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear); // Mostra qual dia do ano.
            Console.WriteLine("5) Hour: " + d.Hour);// Mostra a Hora.
            Console.WriteLine("6) Kind " + d.Kind); // Mostra o tipo da Hora local tipo GMC -3 Hora do brasil.
            Console.WriteLine("7) MilliSecond: " + d.Millisecond); // Mostra os Milli segundos.
            Console.WriteLine("8) Minute: " + d.Minute); // Mostra os minutos
            Console.WriteLine("9) Month: " + d.Month); // Mostra os mês
            Console.WriteLine("10) Second: " + d.Second); // Mostra os segundos.
            Console.WriteLine("11) Ticks: " + d.Ticks); // Mostra a quantidade de Ticks data e hora
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);  // Mostra a hora que esta no construtor.
            Console.WriteLine("13) Year: " + d.Year); // Mostra o ano.
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Modo de Conversão de horas e dias.");
            Console.WriteLine(d.ToLongDateString()); 
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString("yyyy-MM-dd  HH:mm:ss  ")); // Formatar manualmente sua data e hora
            Console.WriteLine(d.ToString("yyyy-MM-dd  HH:mm:ss. fff  ")); // Formatar manualmente sua data e hora e Miliseconds


        }
    }
}
