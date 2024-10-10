public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int getTop()
    {
        return _top;
    }

    public void setTop( int top)
    {
        _top = top;
    }

    public int getBottom()
    {
        return _bottom;
    }

    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string getFractionString()
    {
        int top = getTop();
        int bottom = getBottom();
        string fractionString = top + "/" + bottom;
        return fractionString;
    }

    public double getDecimalValue()
    {
        double top = getTop();
        double bottom = getBottom();
        double decimalValue = top/bottom;
        return decimalValue;
    }
}