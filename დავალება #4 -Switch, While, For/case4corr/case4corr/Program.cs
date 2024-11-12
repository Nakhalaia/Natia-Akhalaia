{
    static void Main()
    {
        int sum = 0;
        int number;


        while (true)
        {
            Console.Write("sheikvane dadebiti ricxvi: ");
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                break;
            }

            sum += number;
        }

        Console.WriteLine($"sul: {sum}");
    }
}
