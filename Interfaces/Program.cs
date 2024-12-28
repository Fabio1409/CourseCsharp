//INTERFACE = É um tipo que define um conjunto de operações que uma class(ou struct) deve implementar
// A interface estabelece um contrato que a classe (ou struct) deve cumprir
// por quê interfaces? Para criar sistemas com baixo aclopamento e flexiveis.

using ExercicioComInterface.Services;
using System.Globalization;
using ExercicioComInterface.Entities;

namespace ExercicioComInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine()!;

            Console.Write("Pickup (dd/MM/yyyy hh:mm: ");
            DateTime start = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessingInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
