class Program
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();

        int ticketPrice;

        switch (dayOfWeek.ToLower())
        {
            case "monday":
            case "tuesday":
            case "friday":
                ticketPrice = 12;
                break;
            case "wednesday":
            case "thursday":
            case "saturday":
            case "sunday":
                ticketPrice = 14;
                break;
            default:
                Console.WriteLine("Invalid day of the week.");
                return;
        }

        Console.WriteLine(ticketPrice);
    }
}