using System;
namespace NumerosAritimetricos
    {
    class program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3; //  Mod Pega resto que sobra da divisão, no caso 2
            double n4 = (double)10 / 8;    // mesmo mudando a variavel pra double ainda continua sendo resultado 1, sempre temos que usar o casting para pegar os pontos flutuantes

            double a = 1.0, b = -3.0, c = -4.0; // Formula de bascara

            double delta = Math.Pow(b,2.0) - 4.0 * a * c;

            double x1 = ( -b + Math.Sqrt(delta)) / (2.0 * a); // raiz quadrada
            double x2 = ( -b - Math.Sqrt(delta)) / (2.0 * a); // raiz quadrada


            Console.WriteLine(n1);
            Console.WriteLine(n2); 
            Console.WriteLine(n3); 
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}
