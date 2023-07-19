using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected DateTime date;
    protected int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} {GetType().Name} ({length} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile\n" +
               $"{date.ToShortDateString()} {GetType().Name} ({length} min): Distance {GetDistance() * 1.60934:F1} km, Speed: {GetSpeed() * 1.60934:F1} kph, Pace: {GetPace() / 1.60934:F1} min per km";
    }
}

public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / length * 60;
    }

    public override double GetPace()
    {
        return length / distance;
    }
}

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1609.34;
    }

    public override double GetSpeed()
    {
        return GetDistance() / length * 60;
    }

    public override double GetPace()
    {
        return length / GetDistance();
    }
}

public class StationaryBicycle : Activity
{
    private double speed;

    public StationaryBicycle(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * length / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / (speed * 1.60934);
    }
}

class Program
{
   static void Main(string[] args)
   {
       List<Activity> activities = new List<Activity>();

       activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
       activities.Add(new StationaryBicycle(new DateTime(2022, 11, 3), 30, 12.0));
       activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 20));

       foreach (Activity activity in activities)
       {
           Console.WriteLine(activity.GetSummary());
       }
   }
}
