using System;

namespace TransparenciaReferencial
{
    class Program 
    {
        public static  int globalValue = 3;// Essa variavel global faz com que o programa fique mais confuso na leitura.
        public static void Main(string[] args)
        {
            int[] vect = new int[] {3, 4, 5};
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));
        }

        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }
    }
}
