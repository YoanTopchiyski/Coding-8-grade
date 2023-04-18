using System;

namespace SweetCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            int campaignDays = int.Parse(Console.ReadLine());
            int pastryChefsCount = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int wafflesCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            decimal cakesSum = cakesCount * 45.00M;
            decimal wafflesSum = wafflesCount * 5.80M;
            decimal pancakesSum = pancakesCount * 3.20M;

            decimal totalSum = (cakesSum + wafflesSum + pancakesSum) * pastryChefsCount * campaignDays;
            totalSum -= totalSum / 8;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}