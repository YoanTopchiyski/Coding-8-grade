using System;

class Program
{
    static void Main()
    {
        double nachalnaSuma = double.Parse(Console.ReadLine());
        int srok = int.Parse(Console.ReadLine());
        double lihva = double.Parse(Console.ReadLine());

        // изчисляване на крайната сума
        double x = lihva / 100;
        double y = nachalnaSuma + srok * ((nachalnaSuma * x) / 12);

        // отпечатване на резултата
        Console.WriteLine($"{y:F2}");
    }
}