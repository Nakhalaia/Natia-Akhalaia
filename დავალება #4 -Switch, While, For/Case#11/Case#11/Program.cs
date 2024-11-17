//using System;

//public class Counter
//{

//    private static int count = 0;

//    public Counter()
//    {
//        count++;
//    }

//    public static int GetCount()
//    {
//        return count;
//    }

//    public static void ResetCount()
//    {
//        count = 0;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {

//        Counter counter1 = new Counter();
//        Console.WriteLine("Count 1: " + Counter.GetCount());

//        Counter counter2 = new Counter();
//        Console.WriteLine("Count 2: " + Counter.GetCount());

//        Counter counter3 = new Counter();
//        Console.WriteLine("Count 3: " + Counter.GetCount());


//        Counter.ResetCount();
//        Console.WriteLine("Count after reset: " + Counter.GetCount());
//    }
//}




public static class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("0 ze gakofa akrdzalulia.");
        }
        return (double)a / b;
    }
}



class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 3;

        Console.WriteLine("Add: " + MathHelper.Add(a, b));
        Console.WriteLine("Subtract: " + MathHelper.Subtract(a, b));
        Console.WriteLine("Multiply: " + MathHelper.Multiply(a, b));

        try
        {
            Console.WriteLine("Divide: " + MathHelper.Divide(a, b));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        
        b = 0;
        try
        {
            Console.WriteLine("Divide with b = 0: " + MathHelper.Divide(a, b));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

