public class Box<T>
{
    private T value;

    public void SetValue(T value)
    {
        this.value = value;
    }

    public T GetValue()
    {
        return value;
    }
}

public static class Utility
{
    public static int J<T>(List<T> list)
    {
        return list.Count;
    }
}

class Program
{
    static void Main(string[] args)
    { 
        Box<int> intBox = new Box<int>();
        intBox.SetValue(123);
        Console.WriteLine("Value in intBox: " + intBox.GetValue());

   
        Box<string> stringBox = new Box<string>();
        stringBox.SetValue("Gamarjoba");
        Console.WriteLine("Value in stringBox: " + stringBox.GetValue());

        List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Number of elements in intList: " + Utility.J(intList));

        List<string> stringList = new List<string> { "a", "b", "c" };
        Console.WriteLine("Number of elements in stringList: " + Utility.J(stringList));

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

