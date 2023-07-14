using System;

namespace BasicCorePrograming
{
    internal class SwapNumbers
    {
        public static void SwapTwoNumbers()
        {
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping:");
            Console.WriteLine("Number 1: " + number1);
            Console.WriteLine("Number 2: " + number2);

            // Swapping the numbers using a temporary variable
            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("After swapping:");
            Console.WriteLine("Number 1: " + number1);
            Console.WriteLine("Number 2: " + number2);
        }
    }
}

