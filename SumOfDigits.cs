using System;

public class SumOfDigits
{
    public static void FindSumOfDigits(int number)
    {
        int sum = 0;

        // Use a loop to extract each digit and add it to the sum
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}
