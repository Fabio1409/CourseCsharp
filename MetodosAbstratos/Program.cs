

using MetodosAbstratos.Entities;
using MetodosAbstratos.Entities.Enums;

using System.Globalization;

namespace MetodosAbstratos
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number shapes: ");
            int shape = int.Parse(Console.ReadLine());

            for (int i = 1; i <= shape; i++)
            {
                Console.WriteLine($"Shape #{shape} data: ");
                Console.Write("Rectangle or Cilcle (r/c) ");
                char caracter = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (caracter == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
                Console.WriteLine("---------------------------------------");
                

                
            }
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shap in shapes)
            {
                Console.WriteLine(shap.Area().ToString("f2", CultureInfo.InvariantCulture));

            }


        }
    }
}
