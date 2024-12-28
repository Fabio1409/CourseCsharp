using System;
namespace Entrada
{
   class program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
           

            string[] vetor = Console.ReadLine().Split(' ');//Split serve pra armazenar variaveis diferentes
            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];
           
            Console.WriteLine("Voçe Digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
