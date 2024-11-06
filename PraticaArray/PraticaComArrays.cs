using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaArray
{
    public class PraticaComArrays
    {
        public void Exercicio1()
        {
            int[] arrayIntLinear = new int[100000];

            // popular as posicoes com seu valor de indice linearmente

            for (int i = 0; i < 100000; i++)
            {
                arrayIntLinear[i] = i;
            }
            int[,] matriz = new int[100, 100];
            var rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    matriz[i, j] = rand.Next(1, 300000);
                }

            }

            int countMatch = 0;
            for (int i = 0; i < matriz.GetUpperBound(0); i++)
            {
                for (int j = 0; j < matriz.GetUpperBound(1); j++)
                {
                    var valorMatriz = (int)matriz.GetValue(i, j);

                    for (int x = 0; x < arrayIntLinear.Length; x++)
                    {
                        if (arrayIntLinear[x] == valorMatriz)
                        {
                            countMatch++;
                        }
                    }
                    
                        
                }

            }
            Console.WriteLine($"Houveram {countMatch} entre os valores randômicos da matriz e do array linear! ");
        }
    }
}


