
class Program
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());

        minute += 15;

        if (minute >= 60)
        {
            hour += 1;
            minute -= 60;
        }

        if (hour >= 24)
        {
            hour = 0;
        }
        if(hour <=10)
        {
            Console.WriteLine("0");
        }

        Console.Write($"{hour:D2}:{minute:D2}");
    }
}