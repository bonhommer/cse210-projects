using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.getFractionString());
        Console.WriteLine(fraction.getDecimalValue());

        Fraction fraction1 = new Fraction(5);
        Console.WriteLine(fraction1.getFractionString());
        Console.WriteLine(fraction1.getDecimalValue());

        Fraction fraction2 = new Fraction(3,4);
        Console.WriteLine(fraction2.getFractionString());
        Console.WriteLine(fraction2.getDecimalValue());

        Fraction fraction3 = new Fraction(1,3);
        Console.WriteLine(fraction3.getFractionString());
        Console.WriteLine(fraction3.getDecimalValue());
    }
}