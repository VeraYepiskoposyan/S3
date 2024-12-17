using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class FinancialModelSimulator
{
    public static void Run()
    {
        Console.WriteLine("Running Financial Model Simulation...");
        Console.Write("Enter the initial value: ");
        double initialValue = double.Parse(Console.ReadLine());
        Console.Write("Enter the daily growth rate (as a percentage): ");
        double growthRate = double.Parse(Console.ReadLine()) / 100;
        Console.Write("Enter the number of days: ");
        int days = int.Parse(Console.ReadLine());

        double finalValue = initialValue;
        for (int i = 0; i < days; i++)
        {
            finalValue *= (1 + growthRate);
        }

        Console.WriteLine($"Final value after {days} days: {finalValue:F2}");
    }
}