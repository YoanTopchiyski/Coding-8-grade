using System;

class Program
{
    static void Main(string[] args)
    {
        double income = double.Parse(Console.ReadLine());
        double grade = double.Parse(Console.ReadLine());
        double minSalary = double.Parse(Console.ReadLine());

        double socialScholarship = 0;
        double excellentScholarship = 0;

        if (income < minSalary && grade > 4.5)
        {
            socialScholarship = Math.Floor(0.35 * minSalary);
        }

        if (grade >= 5.5)
        {
            excellentScholarship = Math.Floor(grade * 25);
        }

        if (socialScholarship == 0 && excellentScholarship == 0)
        {
            Console.WriteLine("You cannot get a scholarship!");
        }
        else if (socialScholarship > excellentScholarship)
        {
            Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
        }
        else
        {
            Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
        }
    }
}