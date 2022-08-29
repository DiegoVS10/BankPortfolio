using BankPortfolio.Application.Trades.Interfaces;
using BankPortfolio.CrossCutting;
using Microsoft.Extensions.DependencyInjection;

namespace BankPortfolio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();
            NativeInjector.RegisterServices(services);

            var tradeAppService = services
                .BuildServiceProvider()
                .GetService<ITradeAppService>();

            var app = new BankPortfolioApp(tradeAppService);
            app.RunApp();
        }
    }
}

