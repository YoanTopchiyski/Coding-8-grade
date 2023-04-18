using System;

class Program
{
    static void Main(string[] args)
    {
        string architectName = Console.ReadLine();
        int numProjects = int.Parse(Console.ReadLine());
        int hoursNeeded = numProjects * 3;
        Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {numProjects} project/s.");
    }
}