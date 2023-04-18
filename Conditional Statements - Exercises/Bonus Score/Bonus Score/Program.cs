using System;

class Program
{
    static void Main(string[] args)
    {
        double points, bonusPoints = 0, totalPoints;
        points = double.Parse(Console.ReadLine());

        if (points <= 100)
        {
            bonusPoints = 5;
        }
        else if (points > 100 && points <= 1000)
        {
            bonusPoints = points * 0.2;
        }
        else if (points > 1000)
        {
            bonusPoints = points * 0.1;
        }

        if (points % 2 == 0)
        {
            bonusPoints += 1;
        }
        else if (points % 10 == 5)
        {
            bonusPoints += 2;
        }

        totalPoints = points + bonusPoints;
        Console.WriteLine($"Бонус точки: {bonusPoints}");
        Console.WriteLine($"Общ брой точки: {totalPoints}");
    }
}