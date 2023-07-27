using System;

public class PatternPrinting
{
    public static void PrintPattern()
    {
        int n = 8; // Number of rows in the pattern

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
