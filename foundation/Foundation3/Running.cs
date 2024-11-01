using System;

public class Running : Activity
{
    private double _distance; 

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed()
    {
        return  (GetDistance() / Minutes) * 60;
    }

    public override double GetPace() 
    {
        return Minutes / GetDistance(); 
    }
}
