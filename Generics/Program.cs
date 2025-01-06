

/* Generics permitem que classes, interfaces e metodos possam ser parametizados por tipo
* seus beneficios são:
* Reuso
* Type
* Performance
* 
* Uso Comum de Generics e para Coleções.
*/

using System;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();
            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                int x = int.Parse(Console.ReadLine()); 
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("Firt: " + printService.First());
        }
    }
}
