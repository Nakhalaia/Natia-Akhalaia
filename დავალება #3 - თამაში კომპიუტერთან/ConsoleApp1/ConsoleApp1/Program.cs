// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

{
    Random random = new Random();
    int randomNumber = random.Next(1, 10);
    int maxtries = 3;

    for (int N = 1; N <= maxtries; N++)
    {
        Console.WriteLine(" input number ");
        string input = Console.ReadLine();
        int inputNum = int.Parse (input); //convert to int

        if (randomNumber == inputNum)
        {
            Console.WriteLine("Bingo");
            break; //exit the loof if guessed right
        }

        else if (N == maxtries)
        {
            Console.WriteLine("Kidev Scade");
        }
        else
        {

            Console.WriteLine("You have: " + (maxtries - N) + " Tries Left");
        }
    }
}

     
  







