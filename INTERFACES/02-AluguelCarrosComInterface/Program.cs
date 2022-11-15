using _01_AluguelCarrosSemInterface.Entities;
using _01_AluguelCarrosSemInterface.Services;
using System.Globalization;

namespace _02_AluguelCarrosComInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            TimeSpan duraction = carRental.Finish.Subtract(carRental.Start);

            if (duraction.TotalHours >= 24)
            {
                Console.WriteLine("Dias utilizados: " + Math.Ceiling(duraction.TotalDays));
            }
            Console.WriteLine("Tempo uso carro: " + Math.Ceiling(duraction.TotalHours));
            Console.WriteLine();

            RentalService rentalService = new RentalService(hour, day,new BrasilTaxService());
            rentalService.processInvoice(carRental);
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}