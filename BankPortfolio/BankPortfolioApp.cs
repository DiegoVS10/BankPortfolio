using BankPortfolio.Application.Trades.InputModel;
using BankPortfolio.Application.Trades.Interfaces;
using System.Globalization;

namespace BankPortfolio
{
    public class BankPortfolioApp
    {
        private readonly ITradeAppService _tradeAppService;

        public BankPortfolioApp(ITradeAppService tradeAppService)
        {
            _tradeAppService = tradeAppService;
        }

        public void RunApp()
        {
            var trades = new List<TradeInputModel>();

            GetInitialTrade(trades);
            PrintTradeCategory(trades);

            Console.ReadKey();
        }
        private static void GetInitialTrade(IList<TradeInputModel> trades)
        {
            var referenceDate = DateTime.MinValue;
            var quantityTrades = 0;
            bool valid;

            do
            {
                try
                {
                    Console.WriteLine("Digite uma data de referencia: ");
                    referenceDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

                    Console.WriteLine("Quantidade de transações: ");
                    quantityTrades = int.Parse(Console.ReadLine());

                    valid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nDados invalidos! Erro: {ex.Message}.\n");
                    valid = false;
                }

            } while (!valid);

            GetListTrade(referenceDate, quantityTrades, trades);
        }
        
        private static void GetListTrade(DateTime referenceDate, int quantityTrades, IList<TradeInputModel> trades)
        {
            for (int i = 0; i < quantityTrades; i++)
            {
                bool valid;
                do
                {
                    Console.WriteLine($"Digite a {i + 1}ª transação: ");

                    try
                    {
                        var inputTrade = Console.ReadLine();
                        if (!string.IsNullOrEmpty(inputTrade))
                        {
                            var inputModel = new TradeInputModel(inputTrade, referenceDate);
                            trades.Add(inputModel);
                        }

                        valid = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\nDados invalidos! Erro: {ex.Message}.");
                        valid = false;
                    }

                } while (!valid);
            }
        }
        
        private void PrintTradeCategory(IList<TradeInputModel> trades)
        {
            Console.WriteLine("\n");
            foreach (var trade in trades)
            {
                var result = _tradeAppService.Classify(trade);
                Console.WriteLine(result);
            }
        }
    }
}
