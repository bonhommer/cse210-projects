using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    protected Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date 
    {
        get
        {
            return _date;
        }
    }
    public int Minutes 
    {
        get
        {
            return _minutes;
        }
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({Minutes} min) - Distance: {GetDistance()} {(IsMetric() ? "km" : "miles")}, Speed: {GetSpeed()} {(IsMetric() ? "kph" : "mph")}, Pace: {GetPace()}  {(IsMetric() ? "min per km" : "min per mile")}";
    }

    protected virtual bool IsMetric() => false;
}
