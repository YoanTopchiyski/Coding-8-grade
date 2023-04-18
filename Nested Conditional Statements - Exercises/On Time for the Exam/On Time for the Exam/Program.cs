using System;

class ExamSchedule
{
    static void Main()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinute = int.Parse(Console.ReadLine());

        int examTime = examHour * 60 + examMinute;
        int arrivalTime = arrivalHour * 60 + arrivalMinute;
        int difference = arrivalTime - examTime;

        if (difference > 0)
        {
            Console.Write("Late");
        }
        else if (difference >= -30)
        {
            Console.Write("On time");
        }
        else
        {
            Console.Write("Early");
        }

        if (difference != 0)
        {
            int hours = Math.Abs(difference / 60);
            int minutes = Math.Abs(difference % 60);
            if (hours > 0)
            {
                Console.Write($"\n{hours}:{minutes:F2} hours after the start");
            }
            else
            {
                Console.Write($"\n{minutes} minutes after the start");
            }
        }
    }
}