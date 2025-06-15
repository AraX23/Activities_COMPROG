using System;

public struct Activity5_TimeProgram
{
    private readonly int totalMin; // totalMins from 00:00
    public Activity5_TimeProgram(int hrs, int mins){
        totalMin = (hrs * 60) + mins;
    }
    public Activity5_TimeProgram(int minutes){
        totalMin = minutes;
    }
    public int hr{
        get { return totalMin / 60; }
    } 
    public int min{
        get { return totalMin % 60; }
    }
    public override string ToString(){ //hh:mm format
        return String.Format("{0:D2}:{1:D2}", hr, min);
    }
    public static Activity5_TimeProgram operator +(Activity5_TimeProgram t1, Activity5_TimeProgram t2){ // xTime + operator to add two Time values
        return new Activity5_TimeProgram(t1.totalMin + t2.totalMin);
    }
    public static Activity5_TimeProgram operator -(Activity5_TimeProgram t1, Activity5_TimeProgram t2){ // xTime - operator to add two Time values
        return new Activity5_TimeProgram(t1.totalMin - t2.totalMin);
    }
}

        class Activity5_Time
        {
            static void Main(){
                //two time examples
                Activity5_TimeProgram AM_Time = new Activity5_TimeProgram(11, 11); // 11:11 AM
                Activity5_TimeProgram extraTime = new Activity5_TimeProgram(10, 03);   // 10 hour 03 minutes

                Activity5_TimeProgram totalTime = AM_Time + extraTime;
                Activity5_TimeProgram differenceTime = AM_Time - extraTime;
                Activity5_TimeProgram directTime = new Activity5_TimeProgram(200); // 200 mins since midnight

                Console.WriteLine("Morning Time: " + AM_Time);
                Console.WriteLine("Extra Time: " + extraTime);
                Console.WriteLine("Added Time (morning + extra): " + totalTime);
                Console.WriteLine("Difference Time (morning - extra): " + differenceTime);
                Console.WriteLine("Time from 200 minutes: " + directTime);
            }
        }
