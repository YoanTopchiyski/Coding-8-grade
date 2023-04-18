using System;

class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        string inputUnit = Console.ReadLine();
        string outputUnit = Console.ReadLine();

        double numberInMeters = number;

        if (inputUnit == "mm")
        {
            numberInMeters = number / 1000;
        }
        else if (inputUnit == "cm")
        {
            numberInMeters = number / 100;
        }

        double result = 0;

        if (outputUnit == "mm")
        {
            result = numberInMeters * 1000;
        }
        else if (outputUnit == "cm")
        {
            result = numberInMeters * 100;
        }
        else if (outputUnit == "m")
        {
            result = numberInMeters;
        }

        Console.WriteLine($"{result:F3}");
    }
}