using System;

public class Pattern16
{
    public static void PrintPattern()
    {
        int height = 7; // Number of rows in the pattern
        int width = 7; // Number of columns in the pattern

        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= width; j++)
            {
                if (i == 1 || i == height || j == 1 || j == width)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
