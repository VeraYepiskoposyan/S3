using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MonteCarloSimulation
{
    public static void Run()
    {
        Console.WriteLine("Running Monte Carlo Simulation...");
        Random random = new Random();
        int simulations = 10000;
        int successes = 0;

        for (int i = 0; i < simulations; i++)
        {
            double randomValue = random.NextDouble();
            if (randomValue > 0.5) successes++;
        }

        double probability = (double)successes / simulations;
        Console.WriteLine($"Estimated probability: {probability}");
    }
}