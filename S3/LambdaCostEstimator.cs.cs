using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class LambdaCostEstimator
{
    public static void Run()
    {
        Console.WriteLine("Running AWS Lambda Cost Estimator...");
        Console.Write("Enter the number of invocations: ");
        int invocations = int.Parse(Console.ReadLine());
        Console.Write("Enter the average execution time (in ms): ");
        double executionTime = double.Parse(Console.ReadLine());

        double costPerMs = 0.0000002; // Cost per ms for AWS Lambda
        double totalCost = invocations * executionTime * costPerMs;

        Console.WriteLine($"Estimated AWS Lambda cost: ${totalCost:F6}");
    }
}