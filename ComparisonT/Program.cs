﻿using ComparisonT.Entities;
using System;
using System.Globalization;

namespace ComparisonT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // posso usar diretamente no sort

            foreach (Product p in list) 
            {
                Console.WriteLine(p);
            
            }

        }
        
    }
}