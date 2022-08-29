using BankPortfolio.Domain.Trades.Entities;

namespace BankPortfolio.Domain.Trades
{
    public static class ExpiredCategory
    {
        const string EXPIRED_CATEGORY = "EXPIRED";
        const int DAYS_TO_EXPIRE = 30;

        public static void ClassifyExpired(this Category category, Trade trade)
        {
            if (category.IsClassified())
                return;

            if (trade.ReferenceDate.Subtract(trade.NextPaymentDate).TotalDays > DAYS_TO_EXPIRE)
                category.Description = EXPIRED_CATEGORY;
        }
    }
}
