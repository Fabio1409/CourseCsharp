using System.Globalization;
using System;
using ExercicioComposicao.Entities;
using ExercicioComposicao.Entities.Enums;


namespace Exercicio

{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter department`s name: ");
            string depName = Console.ReadLine();

            Console.WriteLine(" Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (junior/MidLevel/senior): ");

            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(depName);
            
            Worker worker = new Worker(name, level, baseSalary, dept);


            Console.Write("How many contracts to this worker? ");
            int numberContracts = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < numberContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY): ");

                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Valuer per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);


            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("");
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}