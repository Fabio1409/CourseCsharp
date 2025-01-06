/* Representa um conjunto de elementos(similar da álgebra
 * Não admite repetições
 * Elementos não possuem posição
 * Acesso, inserção e remoção de elementos são rápidos
 * Oferece operação eficiente de conjunto: interseção, União, Diferença.
 * 
 * HashSet
 * Armazena em tabela hash
 * Extremamente rápido: inserção, remoção e busca O(1)
 * A ordem dos elementos não é garantida
 * 
 * SortedSet
 * Armazenamento em arvore
 * Rápido: inserção, remoção e busca O(log(n))
 * Os elementos são armazenados ordenamente conforme implementação IComparer<T>
 */
using System;
using System.Collections.Generic;

namespace HashSetESortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> set = new HashSet<String>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook"));

            foreach (String s in set) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
 

