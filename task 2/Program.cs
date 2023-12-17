using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Converter
    {
        private double usdRate;
        private double eurRate;
        private double plnRate;

       
        public Converter(double usd, double eur, double pln)
        {
            usdRate = usd;
            eurRate = eur;
            plnRate = pln;
        }

        
        public double ConvertToForeignCurrency(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount / usdRate;
                case "eur":
                    return amount / eurRate;
                case "pln":
                    return amount / plnRate;
                default:
                    Console.WriteLine("Невірний код валюти");
                    return 0;
            }
        }

       
        public double ConvertFromForeignCurrency(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount * usdRate;
                case "eur":
                    return amount * eurRate;
                case "pln":
                    return amount * plnRate;
                default:
                    Console.WriteLine("Невірний код валюти");
                    return 0;
            }
        }
    }

    class Program
    {
        static void Main()
        {
         
            Converter converter = new Converter(28.3, 33.2, 7.6);

            Console.WriteLine("Виберіть операцію конвертації:");
            Console.WriteLine("1. З гривні в іншу валюту");
            Console.WriteLine("2. З іншої валюти в гривню");

            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть суму:");

            double amount = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Введіть код валюти (usd, eur, pln):");
                    string toCurrency = Console.ReadLine();
                    double result = converter.ConvertToForeignCurrency(amount, toCurrency);
                    Console.WriteLine($"Результат конвертації: {result} {toCurrency}");
                    break;

                case 2:
                    Console.WriteLine("Введіть код валюти (usd, eur, pln):");
                    string fromCurrency = Console.ReadLine();
                    double resultReverse = converter.ConvertFromForeignCurrency(amount, fromCurrency);
                    Console.WriteLine($"Результат конвертації: {resultReverse} UAH");
                    break;

                default:
                    Console.WriteLine("Невірний вибір операції");
                    break;
            }

            Console.ReadLine(); 
        }
    }
}
