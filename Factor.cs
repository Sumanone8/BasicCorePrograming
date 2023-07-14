using System;

namespace BasicCorePrograming
{
    internal class Factors
    {
        public static void PrintPrimeFactors()
        {
            Console.WriteLine("Enter a number to find its prime factors: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime factors of {0} are:", number);
            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
            }

            if (number > 1)
            {
                Console.WriteLine(number);
            }
        }
    }
}
