using BankPortfolio.Domain.Trades.Entities;
using BankPortfolio.Domain.Trades.Services;

namespace BankPortfolio.Test.Trades
{
    public class TradeServiceTest
    {
        const string EXPIRED_CATEGORY = "EXPIRED";
        const string HIGHT_CATEGORY = "HIGHRISK";
        const string MEDIUM_CATEGORY = "MEDIUMRISK";

        private readonly TradeService _tradeService;

        public TradeServiceTest()
        {
            _tradeService = new TradeService();
        }

        [Fact]
        public void GivenATradeExpiredShouldReturnExpiredCategory()
        {
            var trade = new Trade(4000000, "Private", DateTime.Now.AddDays(-31), DateTime.Now);
            var category = _tradeService.Classify(trade);

            Assert.Equal(EXPIRED_CATEGORY, category);
        }

        [Fact]
        public void GivenATradeHighRiskShouldReturnHighRiskCategory()
        {
            var trade = new Trade(2000000, "Private", DateTime.Now.AddDays(5), DateTime.Now);
            var category = _tradeService.Classify(trade);

            Assert.Equal(HIGHT_CATEGORY, category);
        }

        [Fact]
        public void GivenATradeMediumRiskShouldReturnMediumRiskCategory()
        {
            var trade = new Trade(5000000, "Public", DateTime.Now.AddDays(10), DateTime.Now);
            var category = _tradeService.Classify(trade);

            Assert.Equal(MEDIUM_CATEGORY, category);
        }

        [Fact]
        public void GivenATradeShouldReturnNullCategory()
        {
            var trade = new Trade(250000, "Private", DateTime.Now.AddDays(10), DateTime.Now);
            var category = _tradeService.Classify(trade);

            Assert.Null(category);
        }

        [Fact]
        public void GivenATradeExpiredAndHighRiskShouldConsiderOrderOfPrecedenceReturnExpired()
        {
            var trade = new Trade(2000000, "Private", DateTime.Now.AddDays(-50), DateTime.Now);
            var category = _tradeService.Classify(trade);

            Assert.Equal(EXPIRED_CATEGORY, category);
        }
    }
}
