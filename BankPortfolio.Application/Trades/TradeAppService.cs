using BankPortfolio.Application.Trades.InputModel;
using BankPortfolio.Application.Trades.Interfaces;
using BankPortfolio.Domain.Trades.Entities;
using BankPortfolio.Domain.Trades.Interfaces.Services;

namespace BankPortfolio.Application.Trades
{
    public class TradeAppService : ITradeAppService
    {
        private readonly ITradeService _tradeService;

        public TradeAppService(ITradeService tradeService)
        {
            _tradeService = tradeService;
        }

        public string Classify(TradeInputModel tradeInput)
        {
            var trade = new Trade(tradeInput.Value, tradeInput.ClienteSector, tradeInput.NextPaymentDate, tradeInput.ReferenceDate);
            return _tradeService.Classify(trade);
        }
    }
}
