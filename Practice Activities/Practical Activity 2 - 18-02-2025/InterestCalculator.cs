using System;

class InterestCalculator
{
    static void Main()
    {
        Console.Write("Enter principal amount: ");
        double principalAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        double rateOfInterest = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time in years: ");
        double timeInYears = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principalAmount * rateOfInterest * timeInYears) / 100;

        Console.WriteLine("Simple Interest: {0:F2}", simpleInterest);
    }
}
