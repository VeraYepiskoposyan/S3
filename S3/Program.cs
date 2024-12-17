using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select a task to run:");
            Console.WriteLine("1 - Monte Carlo Simulation");
            Console.WriteLine("2 - AWS Lambda Cost Estimator");
            Console.WriteLine("3 - AWS Batch Resource Allocation");
            Console.WriteLine("4 - Simulation Workflow Logger");
            Console.WriteLine("5 - Financial Model Simulation");

            Console.WriteLine("0 - Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    MonteCarloSimulation.Run();
                    break;
                case "2":
                    LambdaCostEstimator.Run();
                    break;
                case "3":
                    BatchResourceAllocator.Run();
                    break;
                case "4":
                    WorkflowLogger.Run();
                    break;
                case "5":
                    FinancialModelSimulator.Run();
                    break;
                case "0":
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
