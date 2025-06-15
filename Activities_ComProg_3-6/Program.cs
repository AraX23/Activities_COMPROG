using System;

// A simple struct to represent time as minutes since midnight
public struct Activity6_Time
{
    private readonly int totalMins;

    // Constructor: accepts total minutes since midnight
    public Activity6_Time(int mins){
        totalMins = mins;
    }
    public int min{ 
        get {return totalMins % 60;}
    }
    public int Hour{
        get {return totalMins / 60;}
    }
    public override string ToString(){ // hh:mm format
        return String.Format("{0:D2}:{1:D2}", Hour, min);
    }
    public static implicit operator Activity6_Time(int mins){ // imp conversion: int (mins) to Time
        return new Activity6_Time(mins);
    }
    public static explicit operator int(Activity6_Time time){ // exp conversion: Time to int (mins)
        return time.totalMins;
    }
}

class Program
{
    static void Main()
    {
        Activity6_Time timeFromInt = 135; //ex., imp conversion
        Console.WriteLine("Time from 135 minutes: " + timeFromInt);

        int totalMinutes = (int)timeFromInt; //exp conversion
        Console.WriteLine("Total minutes from time: " + totalMinutes);

        // More practice
        Activity6_Time startTimeExample = 480; // 8:00 AM (implicit)
        Console.WriteLine("Starts at: " + startTimeExample);

        int minutesSinceMidnight = (int)startTimeExample; // explicit
        Console.WriteLine("That’s " + minutesSinceMidnight + " minutes since midnight.");
    }
}
