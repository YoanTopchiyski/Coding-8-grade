using System;

class Program
{
    static void Main(string[] args)
    {
        double record = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double timePerMeter = double.Parse(Console.ReadLine());

        int resistance = (int)(distance / 15) * 12;
        double ivanTime = distance * timePerMeter + resistance;

        if (ivanTime < record)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:f2} seconds.");
        }
        else
        {
            double diff = ivanTime - record;
            Console.WriteLine($"No, he failed! He was {diff:f2} seconds slower.");
        }
    }
}