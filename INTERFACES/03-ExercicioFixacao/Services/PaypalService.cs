
namespace _03_ExercicioFixacao.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        //Taxa Porcentagem 
        private const double PaymentRate = 0.02;
        //Juros Mensais (juros simples)
        private const double SimpleInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * SimpleInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * PaymentRate ;
        }
    }
}
