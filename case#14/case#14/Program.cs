
using System;

namespace SimpleCalculator
{
  
    public class CustomException : Exception
    {
        public int Status { get; }

        public CustomException(string message, int status) : base(message)
        {
            Status = status;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Sheikvanet pirveli ricxvi: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Sheikvanet meore ricxvi: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Sheikvanet (+, -, *, /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                            throw new DivideByZeroException("Nulze gakofa sheudzlebelia!");
                        result = num1 / num2;
                        break;
                    default:
                        throw new InvalidOperationException("Araswori operacia!");
                }

                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Araswori operacia. Gtxovt sheikvanet swori ricxvi");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Custom exception occurred: {ex.Message} (Status: {ex.Status})");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
