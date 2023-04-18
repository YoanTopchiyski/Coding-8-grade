using System;

class Program
{
    static void Main()
    {
        string city = Console.ReadLine();
        double sales = double.Parse(Console.ReadLine());

        double commission = -1;

        switch (city)
        {
            case "Sofia":
                if (sales >= 0 && sales <= 500)
                    commission = 0.05;
                else if (sales > 500 && sales <= 1000)
                    commission = 0.07;
                else if (sales > 1000 && sales <= 10000)
                    commission = 0.08;
                else if (sales > 10000)
                    commission = 0.12;
                break;

            case "Varna":
                if (sales >= 0 && sales <= 500)
                    commission = 0.045;
                else if (sales > 500 && sales <= 1000)
                    commission = 0.075;
                else if (sales > 1000 && sales <= 10000)
                    commission = 0.1;
                else if (sales > 10000)
                    commission = 0.13;
                break;

            case "Plovdiv":
                if (sales >= 0 && sales <= 500)
                    commission = 0.055;
                else if (sales > 500 && sales <= 1000)
                    commission = 0.08;
                else if (sales > 1000 && sales <= 10000)
                    commission = 0.12;
                else if (sales > 10000)
                    commission = 0.145;
                break;
        }

        if (commission < 0 || sales < 0)
        {
            Console.WriteLine("error");
        }
        else
        {
            double totalCommission = sales * commission;
            Console.WriteLine($"{totalCommission:F2}");
        }
    }
}
