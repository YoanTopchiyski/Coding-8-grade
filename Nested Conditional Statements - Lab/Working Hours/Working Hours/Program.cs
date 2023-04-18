using System;

class Program
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        string day = Console.ReadLine();

        bool isOpen = (hour >= 10 && hour <= 18) &&
                      (day == "Monday" || day == "Tuesday" ||
                       day == "Wednesday" || day == "Thursday" ||
                       day == "Friday" || day == "Saturday");

        if (isOpen)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
    }
}