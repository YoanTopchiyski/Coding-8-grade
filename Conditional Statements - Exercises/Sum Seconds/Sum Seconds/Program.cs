using System;

class Program
{
    static void Main(string[] args)
    {
        int time1, time2, time3, totalTimeInSeconds;

        time1 = int.Parse(Console.ReadLine());
        time2 = int.Parse(Console.ReadLine());
        time3 = int.Parse(Console.ReadLine());

        totalTimeInSeconds = time1 + time2 + time3;

        int minutes = totalTimeInSeconds / 60;
        int seconds = totalTimeInSeconds % 60;


        Console.WriteLine("{0}:{1:D2}", minutes, seconds);
    }
}