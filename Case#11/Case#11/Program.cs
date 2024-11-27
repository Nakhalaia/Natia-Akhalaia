
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Insert(1, 10);
        arrayList.Remove(2);
        Console.WriteLine("ArrayList Elements:");
        foreach (var item in arrayList)
            Console.WriteLine(item);

        
        List<int> list = new List<int> { 1, 2, 3 };
        list.AddRange(new int[] { 4, 5, 6 });
        list.Sort();
        list.Remove(2);
        Console.WriteLine("\nList Elements:");
        foreach (var item in list)
            Console.WriteLine(item);

        
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 }
        };
        dictionary["four"] = 4;
        dictionary.Remove("two");
        Console.WriteLine("\nDictionary Elements:");
        foreach (var kvp in dictionary)
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        Console.WriteLine("Keys:");
        foreach (var key in dictionary.Keys)
            Console.WriteLine(key);
        Console.WriteLine("Values:");
        foreach (var value in dictionary.Values)
            Console.WriteLine(value);

        
        SortedList<int, string> sortedList = new SortedList<int, string>
        {
            { 1, "one" },
            { 3, "three" },
            { 2, "two" }
        };
        sortedList.Add(4, "four");
        sortedList.RemoveAt(1); 
        Console.WriteLine("\nSortedList Elements:");
        foreach (var kvp in sortedList)
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

       
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine($"\nStack Peek: {stack.Peek()}");
        stack.Pop();
        Console.WriteLine("Stack Elements:");
        foreach (var item in stack)
            Console.WriteLine(item);

        
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine($"\nQueue Peek: {queue.Peek()}");
        queue.Dequeue();
        Console.WriteLine("Queue Elements:");
        foreach (var item in queue)
            Console.WriteLine(item);

        
        SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>
        {
            { 1, "one" },
            { 3, "three" },
            { 2, "two" }
        };
        sortedDictionary.Add(4, "four");
        sortedDictionary.Remove(3);
        Console.WriteLine("\nSortedDictionary Elements:");
        foreach (var kvp in sortedDictionary)
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

        
        HashSet<int> hashSet = new HashSet<int> { 1, 2, 3 };
        hashSet.Add(2);
        hashSet.UnionWith(new int[] { 4, 5 });
        hashSet.Remove(1);
        Console.WriteLine("\nHashSet Elements:");
        foreach (var item in hashSet)
            Console.WriteLine(item);
    }
}

