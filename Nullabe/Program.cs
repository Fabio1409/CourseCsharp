using System;

namespace ExplicaçãoNullabe
{
    class Program
    {
        static void Main(string[] args)
        {
            //double x;
            //Nullable <double> v = null;
            //double? y = null; // duas formas de declarar variaveis nulas

            /*double? x = null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault());// valor padrao da variavel = 0
            Console.WriteLine(y.GetValueOrDefault());


            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            
                Console.WriteLine(x.Value);
            else
            Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);

            else
                Console.WriteLine("Y is null");*/

            double? x = null;
            double? y = 10;

            // Operador de coalescencia nula

            double a = x ?? 5; 
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }



    }
}
