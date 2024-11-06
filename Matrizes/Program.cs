using System;

namespace Matriz
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            Console.WriteLine(matriz.Length);
            Console.WriteLine(matriz.Rank);
            Console.WriteLine(matriz.GetLongLength(0));
            Console.WriteLine(matriz.GetLength(1));
        }

    }
}
