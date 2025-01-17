/* Delegate Func
 * 
 * Representa um método que recebe zero ou mais argumentos, e retorna um vcalor
 * 
 */
using DelegateFunc.Entities;
using System.Collections.Generic;
using System.Linq;


namespace DelegateFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD Case", 80.90));

            //Func<Product, string> func = NameUpper;
            Func<Product, string> func = p => p.Name.ToUpper() ; // Expressao lâmbida
            //List<String> result = products.Select(func).ToList();// posso usar o NameUpper direto no select 
            List<String> result = products.Select(p => p.Name.ToUpper()).ToList();// Posso usar inline direto a função Lâmbida 

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

        /*static string NameUpper(Product product)
        {
            return product.Name.ToUpper();
        }
        */
    }
}