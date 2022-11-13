using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AluguelCarrosSemInterface.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double totalPayment{
            get { return BasicPayment + Tax; }

        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.CurrentCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.CurrentCulture)
                + "\nTotal Payment: "
                + totalPayment.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
