using System.ComponentModel;
using System.Diagnostics;

namespace stscoundrel.Maverick;

internal class Maverick
{
    public static readonly List<string> ProgramsToClose = new List<string>
    {
        "discord",
        "steam",
        "slack",
        "skype"
    };

    static void Main(string[] args)
    {
        var closedPrograms = new List<String> { };
        var failedCloses = new List<String> { };
        Process[] runningProcesses = Process.GetProcesses();
        foreach (Process process in runningProcesses)
        {
            foreach (String programToClose in ProgramsToClose)
            {
                if (process.ProcessName.ToLower().Contains(programToClose))
                {
                    try
                    {
                        process.Kill();
                        closedPrograms.Add(process.ProcessName);
                    }
                    catch (Win32Exception)
                    {
                        Console.WriteLine("Failed to close " + programToClose);
                        failedCloses.Add(process.ProcessName);
                    }
                }
            }
        }

        Console.WriteLine("Closed " + closedPrograms.Count + " program(s)");
        foreach (String closedProgram in closedPrograms)
        {
            Console.WriteLine("- " + closedProgram);
        }

        if (failedCloses.Count > 0)
        {
            Console.WriteLine("Failed to close " + failedCloses.Count + " program(s)");
            foreach (String failedClose in failedCloses)
            {
                Console.WriteLine("- " + failedClose);
            }
        }

        Console.ReadLine();

    }
}
