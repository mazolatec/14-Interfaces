

namespace _03_ExercicioFixacao.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        //Prestação ou parcelas
        public List<Instalment> listInstalment { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            listInstalment = new List<Instalment>();    
        }

        public void AddInstalments(Instalment instalments)
        {
            listInstalment.Add(instalments);    
        }
    }
}
