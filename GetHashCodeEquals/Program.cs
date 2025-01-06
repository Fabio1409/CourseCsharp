/* GetHashCode e Equals
 * São Operações da classe Object utilizadas para comprarar se um objeto é igual a outro
 * Equals: lento, resposta 100%
 * GetHashCode: Rápido, porém resposat positiva não é 100%
 * 
 * Os tipos Pré-definidos já possuem implementação para essas operações 
 * Classes e structs Personalizados precisam sobrepô-las
 */
using GetHashCodeEquals.Entities;
using System;

namespace GetHashCodeEquals
{
    class Program
    {
        static void Main(string[] args)
        {
          Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
          Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
 


