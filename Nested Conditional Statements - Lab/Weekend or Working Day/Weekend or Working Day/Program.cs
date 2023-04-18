using System;

namespace Weekend_or_Working_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();

            switch (dayOfWeek.ToLower())
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    Console.WriteLine("Working day");
                    break;
                case "saturday":
                case "sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}