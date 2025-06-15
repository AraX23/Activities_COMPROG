using System;

public struct Activity4_Time_StructType{
    private readonly int totalMins;
    public Activity4_Time_StructType(int hrs, int mins){
        totalMins = (hrs * 60) + mins;
    }
    public int min{
        get { return totalMins % 60; }  
    }
    public int hr{
        get {return totalMins / 60;}  
    }
    public override string ToString(){ 
        return String.Format("{0:D2}:{1:D2}", hr, min);
    }
}

    class Program{
        static void Main(){
            Activity4_Time_StructType AM_Time = new Activity4_Time_StructType(10, 5); 
            Activity4_Time_StructType PM_Time = new Activity4_Time_StructType(23, 45); 
            Activity4_Time_StructType midnightTime = new Activity4_Time_StructType(0, 0);
            Activity4_Time_StructType customTime = new Activity4_Time_StructType(15, 30);

          //view as str
            Console.WriteLine("Formatted Times:");
            Console.WriteLine("AM Time: " + AM_Time);
            Console.WriteLine("PM Time: " + PM_Time);
            Console.WriteLine("Midnight: " + midnightTime);
            Console.WriteLine("Custom Time: " + customTime);

            Console.WriteLine("\nEvening Time:");
            Console.WriteLine("Hour: " + PM_Time.hr);
            Console.WriteLine("Minute: " + PM_Time.min);
        }
    }
