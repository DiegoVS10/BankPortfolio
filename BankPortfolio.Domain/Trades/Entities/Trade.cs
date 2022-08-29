using BankPortfolio.Domain.Trades.Interfaces.Entities;

namespace BankPortfolio.Domain.Trades.Entities
{
    public class Trade : ITrade
    {
        public Trade(double value, string clienteSector, DateTime nextPaymentDate, DateTime referenceDate)
        {
            Value = value;
            ClienteSector = clienteSector;
            NextPaymentDate = nextPaymentDate;
            ReferenceDate = referenceDate;
        }

        public double Value { get; }
        public string ClienteSector { get; }
        public DateTime NextPaymentDate { get; }
        public DateTime ReferenceDate { get; }        
    }
}
