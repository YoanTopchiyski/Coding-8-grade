using System;

class Program
{
    static void Main(string[] args)
    {
        int numDogs = int.Parse(Console.ReadLine());
        int numOtherAnimals = int.Parse(Console.ReadLine());
        double totalCost = (numDogs * 2.5) + (numOtherAnimals * 4);

        Console.WriteLine($"{totalCost} lv.");
    }
}