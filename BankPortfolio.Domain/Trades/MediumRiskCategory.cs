using BankPortfolio.Domain.Trades.Entities;

namespace BankPortfolio.Domain.Trades
{
    public static class MediumRiskCategory
    {
        const double MEDIUM_VALUE = 1000000;
        const string MEDIUM_CLIENTE_SECTOR = "public";
        const string MEDIUM_CATEGORY = "MEDIUMRISK";

        public static void ClassifyMediumRisk(this Category category, Trade trade)
        {
            if (category.IsClassified())
                return;

            if (trade.Value > MEDIUM_VALUE && trade.ClienteSector.ToLower().Equals(MEDIUM_CLIENTE_SECTOR))
                category.Description = MEDIUM_CATEGORY;
        }
    }
}
