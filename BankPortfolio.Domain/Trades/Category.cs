using BankPortfolio.Domain.Trades.Interfaces;

namespace BankPortfolio.Domain.Trades
{
    public class Category
    {
        public string Description { get; set; }

        public bool IsClassified() => !string.IsNullOrEmpty(Description);
    }
}
