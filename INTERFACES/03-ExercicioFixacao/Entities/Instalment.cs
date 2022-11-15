
using System.Globalization;

namespace _03_ExercicioFixacao.Entities
{
    internal class Instalment
    {
        public DateTime DueDate { get; set; }
        public double Amont { get; set; }

        public Instalment(DateTime dueDate, double amont)
        {
            DueDate = dueDate;
            Amont = amont;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                +" - "
                +Amont.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
