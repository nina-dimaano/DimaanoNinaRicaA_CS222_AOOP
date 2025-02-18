using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter amount in USD: ");
        double amountInUSD = double.Parse(Console.ReadLine());

        Console.Write("Enter exchange rate from USD to EUR: ");
        double exchangeRate = double.Parse(Console.ReadLine());

        double amountInEUR = amountInUSD * exchangeRate;

        Console.WriteLine("Amount in EUR: {0:F2}", amountInEUR);
    }
}
