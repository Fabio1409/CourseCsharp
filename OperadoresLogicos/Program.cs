using System;
namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 < 3 || 4 != 5; // True
            bool c2 = !(2>3) && 4 != 5; // True
          

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("--------------------------------------------");

            bool c3 = 10 < 5; // False
            bool c4 =c1 ||c2 && c3; // True
            
            Console.WriteLine(c4);
            
        }
    }
}
// && AND (E) sendo que todas as condiçoes tem que ser verdadeiras
// || OUR (ou) sendo uma condiçao True sera verdadeiro
// !  NOR (Não)