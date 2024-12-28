using ProjetoTriangulo;
using System;
using System.Globalization;
namespace ProjetoTringulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            x.C= double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Entre com as medidas do triaguloY: ");
             y.A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
             y.B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
             y.C = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

           
            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Aréa de X =  " + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Aréa de Y =  " + areaY.ToString("f4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior Área: Y");
            }
        }

    }
}