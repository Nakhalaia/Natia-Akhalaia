// See https://aka.ms/new-console-template for more information


//{

//    Console.WriteLine("sheikvane ricxvi (1 to 7):");
//    string input = Console.ReadLine();
//    if (int.TryParse(input, out int dayNumber))
//    {
//        switch (dayNumber)
//        {
//            case 1:
//                Console.WriteLine("Monday");
//                break;
//            case 2:
//                Console.WriteLine("Tuesday");
//                break;
//            case 3:
//                Console.WriteLine("Wednesday");
//                break;
//            case 4:
//                Console.WriteLine("Thuesday");
//                break;
//            case 5:
//                Console.WriteLine("Friday");
//                break;
//            case 6:
//                Console.WriteLine("Satarday");
//                break;
//            case 7:
//                Console.WriteLine("Sunday");
//                break;
//            default:
//                Console.WriteLine("araswori ricxvi");
//                break;
//        }
//    }
//}


using System.Transactions;

{
    int total = 0;
    int number;

    Console.WriteLine("enter positive number to total. enter negative number to stop");
    while (true)
    {
        Console.WriteLine("enter a number: ");
        number = int.Parse(Console.ReadLine());
        
        if (number < 0)
        {
            break;
        }
        total += number;
        Console.WriteLine("The total sum is: " + total);

    }



}
