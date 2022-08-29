using BankPortfolio.Application.Trades;
using BankPortfolio.Application.Trades.Interfaces;
using BankPortfolio.Domain.Trades.Interfaces.Services;
using BankPortfolio.Domain.Trades.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BankPortfolio.CrossCutting
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            RegisterAppService(services);
            RegisterService(services);
        }

        public static void RegisterAppService(IServiceCollection services)
        {
            services.AddScoped<ITradeAppService, TradeAppService>();
        }

        public static void RegisterService(IServiceCollection services)
        {
            services.AddScoped<ITradeService, TradeService>();
        }
    }
}