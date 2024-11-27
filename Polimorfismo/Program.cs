using System;
using System.Collections.Generic;
using Exercicio.Entities;
using System.Globalization;
using System.ComponentModel.Design;
namespace Exercicio
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees:");     
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                String name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per Hours: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.WriteLine("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));

                }
                else 
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                
                }

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("PAYMENTS:");

                foreach (Employee emp in list)  
                {
                    Console.WriteLine(emp.Name + " - $ " + emp.Payments().ToString("f2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
