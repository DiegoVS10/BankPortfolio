using BankPortfolio.Domain.Trades.Entities;
using BankPortfolio.Domain.Trades.Interfaces.Services;

namespace BankPortfolio.Domain.Trades.Services
{
    public class TradeService : ITradeService
    {
        public string Classify(Trade trade)
        {
            var category = new Category();

            category.ClassifyExpired(trade);
            category.ClassifyHighRisk(trade);
            category.ClassifyMediumRisk(trade);

            return category.Description;
        }
    }
}
