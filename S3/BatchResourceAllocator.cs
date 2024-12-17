using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class BatchResourceAllocator
{
    public static void Run()
    {
        Console.WriteLine("Running AWS Batch Resource Allocation...");
        Console.Write("Enter the number of jobs: ");
        int jobs = int.Parse(Console.ReadLine());
        Console.Write("Enter the maximum resources per job (in vCPU): ");
        int vCPUPerJob = int.Parse(Console.ReadLine());

        int totalResources = jobs * vCPUPerJob;
        Console.WriteLine($"Total vCPU resources required: {totalResources}");
    }
}