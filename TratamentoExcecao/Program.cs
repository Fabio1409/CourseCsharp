﻿using System;
namespace TratamentoExcecao 
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error! " + e.Message);
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)  
            {
                Console.WriteLine("Format error! " + e.Message);
            }

        }
    }
}

