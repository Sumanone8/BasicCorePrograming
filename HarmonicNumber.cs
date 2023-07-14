using System;

namespace BasicCorePrograming
{
    internal class HarmonicNumber
    {
        public static void PrintHarmonicNumber()
        {
            Console.WriteLine("Enter the harmonic value (N): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("Invalid input. N should be a non-zero value.");
                return;
            }

            double harmonicSum = 0;
            for (int i = 1; i <= n; i++)
            {
                harmonicSum += 1.0 / i;
            }

            Console.WriteLine("The {0}th Harmonic Value is: {1}", n, harmonicSum);
        }
    }
}
