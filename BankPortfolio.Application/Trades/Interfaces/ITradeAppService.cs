using BankPortfolio.Application.Trades.InputModel;

namespace BankPortfolio.Application.Trades.Interfaces
{
    public interface ITradeAppService
    {
        string Classify(TradeInputModel tradeInput);
    }
}
