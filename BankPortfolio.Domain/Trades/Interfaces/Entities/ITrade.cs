namespace BankPortfolio.Domain.Trades.Interfaces.Entities
{
    public interface ITrade
    {
        double Value { get; }
        string ClienteSector { get; }
        DateTime NextPaymentDate { get; }
        DateTime ReferenceDate { get; }
    }
}
