using System;

public struct Activity3_Time
{
    private readonly int totalMins;

    public Activity3_Time(int hrs, int mins) 
    {
        totalMins = (hrs * 60) + mins;
    }

    public override string ToString()
    {
        return totalMins + " mins since midnight";
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Input hrs <0 to 23>: ");
        string inputTimeHrs = Console.ReadLine();
        int hrs = int.Parse(inputTimeHrs); //str to int

        Console.Write("Input mins <0 to 59>: ");
        string inputMins = Console.ReadLine();
        int mins = int.Parse(inputMins); //str to int

        Activity3_Time myTime = new Activity3_Time(hrs, mins);

        Console.Write("Your time in minutes since midnight is:");
        Console.WriteLine(myTime);

        Activity3_Time exampleTime = new Activity3_Time(11, 11); //ex. time
        Console.WriteLine("Example time (11:11 AM):");
        Console.WriteLine(exampleTime);
    }
}
