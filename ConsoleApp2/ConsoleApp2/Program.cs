//using System;

//class Program
//{
//    static void Main()
//    {

//        string[] students = new string[3];


//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write($" {i + 1} studentis saxeli: ");
//            students[i] = Console.ReadLine(); 
//        }


//       Console.WriteLine("\nstudentebis saxelebi:");
//        foreach (string student in students)
//        {
//            Console.WriteLine(student);
//        }
//    }
//}


using System;

class Program
{
    static void Main()
    {
        
        int[,] grades = new int[3, 2];

        
        string[] students = new string[3] { "Student 1", "Student 2", "Student 3" };

        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{students[i]}:");
            Console.Write("First subject: ");
            grades[i, 0] = int.Parse(Console.ReadLine());  

            Console.Write("Second Subject: ");
            grades[i, 1] = int.Parse(Console.ReadLine());  

            Console.WriteLine(); 
        }

        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{students[i]}: {grades[i, 0]} Firs subject Score, {grades[i, 1]} Second Subject Score.");
        }
    }
}




