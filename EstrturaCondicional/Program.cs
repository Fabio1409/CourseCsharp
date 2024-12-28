using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONDICIONAL SIMPLES
            /* int x = 10;
             Console.WriteLine("Bom Dia!");
             if (x < 5) { 
                 Console.WriteLine("Boa Tarde!");
             }
             Console.WriteLine("Boa Noite!");*/

            // ESTRUTURA CONDICIONAL COMPOSTA
            Console.WriteLine("Entre com um numero");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0) // resto da divisao por dois
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");

            }
            // ENCADEAMENTO COM ELSE IF
            Console.WriteLine("Qual a Hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom Dia!");
            }
            else if ( hora < 18)// NAO PRECISA USAR MAIS A >= 12 && >18
            {
                Console.WriteLine("Boa Tarde!");
            }
            else
            {
                Console.WriteLine("Boa Noite!!");
            }
            


        }
    }
}