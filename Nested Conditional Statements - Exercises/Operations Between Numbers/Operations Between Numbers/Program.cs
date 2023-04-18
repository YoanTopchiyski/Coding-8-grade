using System;

class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        char op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                int sum = n1 + n2;
                Console.Write($"{n1} + {n2} = {sum} ");
                if (sum % 2 == 0)
                {
                    Console.WriteLine("- even");
                }
                else
                {
                    Console.WriteLine("- odd");
                }
                break;
            case '-':
                int diff = n1 - n2;
                Console.Write($"{n1} - {n2} = {diff} ");
                if (diff % 2 == 0)
                {
                    Console.WriteLine("- even");
                }
                else
                {
                    Console.WriteLine("- odd");
                }
                break;
            case '*':
                int prod = n1 * n2;
                Console.Write($"{n1} * {n2} = {prod} ");
                if (prod % 2 == 0)
                {
                    Console.WriteLine("- even");
                }
                else
                {
                    Console.WriteLine("- odd");
                }
                break;
            case '/':
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    double quotient = (double)n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {quotient:f2}");
                }
                break;
            case '%':
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    int remainder = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {remainder}");
                }
                break;
        }
    }
}