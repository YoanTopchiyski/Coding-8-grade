using System;

namespace Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cm = double.Parse(Console.ReadLine());
            Console.WriteLine(cm*2.54);
        }
    }
}