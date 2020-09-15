using System;

namespace Lab_2.Task_8
{
    class Invoice
    {
        public static double SalesTax = 0.2;
        
        private readonly int _account;
        private readonly string _customer;
        private readonly string _provider;

        private string _article;
        private int _quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
            _article = article;
            _quantity = quantity;
        }

        public double[] PriceOf(string article, int quantity)
        {
            double price = Math.Round((double)(article.Length * quantity), 2);
            double priceWithTax = Math.Round(price * (1 + SalesTax), 2);
            return new [] {price, priceWithTax};
        }

        public void Info()
        {
            Console.WriteLine("Account: " + _account);
            Console.WriteLine("Customer: " + _customer);
            Console.WriteLine("Provider: " + _provider);
            Console.WriteLine($"Ordered {_quantity} {_article}");
            Console.ForegroundColor = ConsoleColor.Green;

            double[] price = PriceOf(_article, _quantity);
            Console.WriteLine($"Price: ${price[0]}, Total: {price[1]}");
        }
    }
}
