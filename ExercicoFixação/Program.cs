using ExercicoFixação.Entities;
using System.Globalization;
using System.Collections.Generic;



namespace ExercicioFixacao
{
    class Program
    {
        public static void Main(string[] args)
        {
            {
                List<Product> products = new List<Product>();

                Console.Write("Enter the number of products: ");
                int product = int.Parse(Console.ReadLine());

                for (int i = 1; i <= product; i++)
                {
                    Console.WriteLine($"Product #{i} data: ");
                    Console.Write("Commom, used or imported (c/u/i) ");
                    char caracter = char.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    

                    if (caracter == 'c')
                    {
                        products.Add(new Product(name!, price));
                    }
                    else if (caracter == 'u')
                    {
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime manufacture = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufacture));
                    }

                    else
                    {
                        Console.Write("Customs fee: ");
                        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customFee));
                    }
                }


                Console.WriteLine("Price Tag:");
                foreach (Product product1 in products)
                {

                    Console.WriteLine(product1.PriceTag());
                }
            }
        }
    }

}