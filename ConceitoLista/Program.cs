using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;


namespace ConceitoLista
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Bob");
            list.Add("Alex");
            list.Add("Anna");
            list.Insert(2, "Marco");


            foreach (string obj in list)
            {
                Console.WriteLine(obj);

            }
            Console.WriteLine("List Count: " + list.Count);
            string s1 = list.Find(x => x[0] == 'A');//Lambida Function
            Console.WriteLine("Fist 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int posicao1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Fist Position 'A': " + posicao1);

            int posicao2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': " + posicao2);

            List<string> list1 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------------------");

            foreach(string obj in list1)
            {
                Console.WriteLine(obj);
            }
            /*list.RemoveRange(2, 2);
            Console.WriteLine("----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }*/

            list.Remove("Alex");
            Console.WriteLine("----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            


        }
       
    }
}
