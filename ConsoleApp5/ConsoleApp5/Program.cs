using System;

public class Fraction
{
    private int _numerator;
    private int _denominator; 

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator can not be 0.");
        }

        _numerator = numerator;
        _denominator = denominator;
    }

    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        
        int newNumerator = f1._numerator * f2._denominator + f2._numerator * f1._denominator;
        int newDenominator = f1._denominator * f2._denominator;

        return new Fraction(newNumerator, newDenominator);
    }

    public static bool operator ==(Fraction f1, Fraction f2)
    {
        return f1._numerator * f2._denominator == f2._numerator * f1._denominator;
    }

    public static bool operator !=(Fraction f1, Fraction f2)
    {
        return !(f1 == f2);
    }

    public override bool Equals(object obj)
    {
        if (obj is Fraction other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return (_numerator, _denominator).GetHashCode();
    }
}

class Program
{
    static void Main()
    {
        try
        {
           
            Fraction fraction1 = new Fraction(2, 3); 
            Fraction fraction2 = new Fraction(3, 4); 
            Fraction fraction3 = new Fraction(4, 5); 
          
            Fraction result = fraction1 + fraction2; 

            Console.WriteLine($"{fraction1} + {fraction2} = {result}");

            Console.WriteLine($"{fraction1} == {fraction2}: {fraction1 == fraction2}");
            Console.WriteLine($"{fraction1} != {fraction3}: {fraction1 != fraction3}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

