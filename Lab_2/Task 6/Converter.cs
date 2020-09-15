using System;

namespace Lab_2.Task_6
{
    class Converter
    {
        private static double _usd;
        private static double _eur;
        private static double _rub;

        private static double[] ExchangeRate;
        private static readonly string[] CurrencyCode = {"UAH", "USD", "EUR", "RUB"};
 
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
            ExchangeRate = new[] {1, _usd, _eur, _rub};
        }

        private static double Convert(double amount, double from, double to) => Math.Round(amount * from / to, 2);

        public void FromUAH()
        {
            double amount = EnterTheAmount(0);
            int currency = ChooseCurrency();
            ShowTheResult(amount, 0, currency);
        }
        public void ToUAH()
        {
            int currency = ChooseCurrency();
            double amount = EnterTheAmount(currency);
            ShowTheResult(amount, currency, 0);
        }

        private int ChooseCurrency()
        {
            int currency;
            do
            {
                Console.ResetColor();
                Console.WriteLine("Choose currency: \nUSD - 1\nEUR - 2\nRUB - 3");
                Console.ForegroundColor = ConsoleColor.Green;
            } while (!int.TryParse(Console.ReadLine(), out currency));
            Console.ResetColor();
            return currency;
        }
        private double EnterTheAmount(int currency)
        {
            Console.WriteLine("- Convert from {0} -", CurrencyCode[currency]);
            double amount;
            do
            {
                Console.ResetColor();
                Console.Write($"{CurrencyCode[currency]}: ");
                Console.ForegroundColor = ConsoleColor.Green;
            } while (!double.TryParse(Console.ReadLine(), out amount));
            Console.ResetColor();
            return amount;
        }
        private void ShowTheResult(double amount, int from, int to)
        {
            Console.Write($"{CurrencyCode[to]}: ");
            Console.WriteLine(Convert(amount, ExchangeRate[from], ExchangeRate[to]));
            Console.WriteLine();
        } 
        
    }
}
