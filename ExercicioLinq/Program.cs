/* Fazer um programa para ler um conjunto de produtos +
 *gnba partir de um arquivo em 
 * formato .csv ( suponha que exista pelo menos um produto).
 * 
 * Em seguida mostrar o preço médio dos produtos. Depois, mostrar os nomes, em ordem decrescente, 
 * os produtos que possuem preços inferior ao preço médio.
 */

using System.Globalization;

namespace ExercicioLinq.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader reader = File.OpenText(path))
            {
                while (!reader.EndOfStream)
                {
                    string[] fields = reader.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}