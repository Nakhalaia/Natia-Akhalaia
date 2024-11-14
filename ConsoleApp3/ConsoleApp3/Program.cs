using System;

class Program
{
  
    static int SumOfDigitsAtIndex(int[] array, int index)
    {
        
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Incorrect Index");
            return -1; 
        }

        
        int number = array[index];

        
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10; 
            number /= 10; 
        }

        return sum; 
    }

    static void Main()
    {
        
        Console.Write("Please Enter Number: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int[] array = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            array[i] = int.Parse(inputArray[i]);
        }

        Console.Write("Please Enter Index: ");
        int index = int.Parse(Console.ReadLine());

        
        int result = SumOfDigitsAtIndex(array, index);

        
        if (result != -1) 
        {
            Console.WriteLine($"Sum: {result}");
        }
    }
}
