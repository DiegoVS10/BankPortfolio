using System.Globalization;

namespace BankPortfolio.Application.Trades.InputModel
{
    public class TradeInputModel
    {
        public TradeInputModel(string inputTrade, DateTime referenceDate)
        {
            var values = inputTrade.Split(' ');
            Value = Double.Parse(values[0]);
            ClienteSector = values[1];
            NextPaymentDate = DateTime.ParseExact(values[2], "MM/dd/yyyy", CultureInfo.InvariantCulture);

            ReferenceDate = referenceDate;
        }

        public double Value { get; private set; }
        public string ClienteSector { get; private set; }
        public DateTime NextPaymentDate { get; private set; }
        public DateTime ReferenceDate { get; private set; }
    }
}
