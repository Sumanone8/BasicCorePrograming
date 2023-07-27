using System;

public class TwoLowestNumbersSum
{
    public static void FindTwoLowestNumbersSum(int[] arr)
    {
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;

        foreach (int num in arr)
        {
            if (num >= 0)
            {
                if (num < min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else if (num < min2)
                {
                    min2 = num;
                }
            }
        }

        int sum = min1 + min2;
        Console.WriteLine("Two lowest numbers: " + min1 + " and " + min2);
        Console.WriteLine("Sum of two lowest numbers: " + sum);
    }
}
