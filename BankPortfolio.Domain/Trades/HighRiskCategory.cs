using BankPortfolio.Domain.Trades.Entities;

namespace BankPortfolio.Domain.Trades
{
    public static class HighRiskCategory
    {
        const double HIGHT_VALUE = 1000000;
        const string HIGHT_CLIENTE_SECTOR = "private";
        const string HIGHT_CATEGORY = "HIGHRISK";

        public static void ClassifyHighRisk(this Category category, Trade trade)
        {
            if (category.IsClassified())
                return;

            if (trade.Value > HIGHT_VALUE && trade.ClienteSector.ToLower().Equals(HIGHT_CLIENTE_SECTOR))
                category.Description = HIGHT_CATEGORY;
        }
    }
}
