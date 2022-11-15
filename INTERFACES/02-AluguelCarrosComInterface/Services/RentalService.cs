

using _01_AluguelCarrosSemInterface.Entities;
using _02_AluguelCarrosComInterface.Services;

namespace _01_AluguelCarrosSemInterface.Services
{
    internal class RentalService
    {
        public double PricePerHour  { get; set; }
        public double PricePerDay  { get; set; }
        public ITaxService _TaxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxservice)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxservice;
        }

        public void processInvoice(CarRental carRental)
        {
            TimeSpan duraction=carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if (duraction.Hours <=12)
            {
                basicPayment = PricePerHour * Math.Ceiling( duraction.TotalHours);
            }
            else
            {
                basicPayment=PricePerDay * Math.Ceiling( duraction.TotalDays);
            }
            double tax = _TaxService.Tax(basicPayment);
            carRental.Invoice =new Invoice(basicPayment, tax);

        }
    }
}
