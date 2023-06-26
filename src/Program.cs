using System.Diagnostics;

namespace stscoundrel.Maverick;

internal class Maverick
{
    public static readonly List<string> ProgramsToClose = new List<string>
    {
        "Discord",
        "Steam",
        "Slack"
    };

    static void Main(string[] args)
    {
        var closedPrograms = new List<String> { };
        Process[] runningProcesses = Process.GetProcesses();
        foreach (Process process in runningProcesses)
        {
            foreach (ProcessModule module in process.Modules)
            {
                if (module.ModuleName != null && ProgramsToClose.Contains(module.ModuleName))
                {
                    process.Kill();
                    closedPrograms.Add(module.ModuleName);
                }
            }
        }

        Console.WriteLine("Closed " + closedPrograms.Count + " program(s)");
        foreach (String closedProgram in closedPrograms)
        {
            Console.WriteLine("- " + closedProgram);
        }

    }
}