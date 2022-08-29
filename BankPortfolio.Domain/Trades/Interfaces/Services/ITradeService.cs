using BankPortfolio.Domain.Trades.Entities;

namespace BankPortfolio.Domain.Trades.Interfaces.Services
{
    public interface ITradeService
    {
        string Classify(Trade trade);
    }
}
