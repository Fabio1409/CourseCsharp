using LInqComLambda.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LinqComLambda
{
    class Program
    {


        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };


            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 350.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 90.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 },
            };
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("Tier 1 and Price < 900: ", r1);
            Console.WriteLine("--------------------------");

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Console.WriteLine();

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Name });

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);

            var r5 = r4.Skip(2).Take(4);

            Print("Names of Products from Tools", r2);
            Console.WriteLine("--------------------------");
            Print("Names started with anonymous Object", r3);
            Console.WriteLine("--------------------------");
            Print("TIER 1 ORDER BY PRICE THEN BY NAME ", r4);
            Console.WriteLine("--------------------------");
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4 ", r5);
            Console.WriteLine("--------------------------");

            var r6 = products.FirstOrDefault();
            Console.WriteLine("Fist Or default TEST 1: " + r6);
            Console.WriteLine("--------------------------");
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();// posso usar o First desa forma, ja que o valor ta bem acima
            Console.WriteLine("Fist Or default TEST 2: " + r7);
            Console.WriteLine("--------------------------");

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();// retornar 1 elemento da minha lista de produtos 
            Console.WriteLine("Single Or Default test 1: " + r8);
            Console.WriteLine("--------------------------");

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();// retornar nulo
            Console.WriteLine("Single Or Default test 2: " + r9);
            Console.WriteLine("--------------------------");


            var r10 = products.Max(p => p.Price); // Maximo de valor
            Console.WriteLine("Max Price: " + r10);
            Console.WriteLine("--------------------------");

            var r11 = products.Min(p => p.Price); // Menor valor
            Console.WriteLine("Min Price: " + r11);
            Console.WriteLine("--------------------------");

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);// Soma
            Console.WriteLine("Category 1 Sum price: " + r12);
            Console.WriteLine("--------------------------");

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price); // Media
            Console.WriteLine("Category 1 Average price: " + r13);
            Console.WriteLine("--------------------------");

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // criar coleção vazia
            Console.WriteLine("Category 5 Average price: " + r14);
            Console.WriteLine("--------------------------");

            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);// Agregação
            Console.WriteLine("Category 1 Aggregate Sum: " + r15);
            Console.WriteLine("--------------------------");


            var r16 = products.GroupBy(p => p.Category);// Agrupamento
                foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product product in group)
                    Console.WriteLine(product);
            }
            Console.WriteLine("--------------------------");



        }
    }
}

