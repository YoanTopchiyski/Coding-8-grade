using System;

class Program
{
    static void Main()
    {
        double radians = double.Parse(Console.ReadLine());
        double degrees = radians * 180 / Math.PI;
        int roundedDegrees = (int)Math.Round(degrees);
        Console.WriteLine(roundedDegrees);
    }
}