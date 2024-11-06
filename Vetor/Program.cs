using System;
using System.Globalization;
namespace Vetor
{


    class Program
    {
        public static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++) 

            {
                vect[i]  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double calculaMedia = sum / n;

            Console.WriteLine("Altura Media: " + calculaMedia.ToString("F2", CultureInfo.InvariantCulture));


        }

    } 
}
