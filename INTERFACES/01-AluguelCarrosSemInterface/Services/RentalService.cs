

using _01_AluguelCarrosSemInterface.Entities;

namespace _01_AluguelCarrosSemInterface.Services
{
    internal class RentalService
    {
        public double PricePerHour  { get; set; }
        public double PricePerDay  { get; set; }
        public BrasilTaxService _brasilTaxService = new BrasilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
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
            double tax = _brasilTaxService.Tax(basicPayment);
            carRental.Invoice =new Invoice(basicPayment, tax);

        }
    }
}
