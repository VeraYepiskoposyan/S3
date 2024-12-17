using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public static class WorkflowLogger
{
    public static void Run()
    {
        Console.WriteLine("Running Simulation Workflow Logger...");
        string logFile = "workflow_log.txt";

        using (StreamWriter writer = new StreamWriter(logFile, true))
        {
            writer.WriteLine($"Workflow executed at {DateTime.Now}");
        }

        Console.WriteLine($"Workflow log updated in {logFile}");
    }
}