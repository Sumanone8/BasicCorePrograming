using System;

namespace BasicCorePrograming
{
    internal class FlipTheCoin
    {
        public static void FlipCoin()
        {
            Console.WriteLine("Flip the Coin Program");
            double heads = 0;
            double tails = 0;
            double headPercentage, tailPercentage;

            Console.WriteLine("Enter the number of times the coin is to be flipped:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Random random = new Random();
                double result = random.NextDouble();

                if (result > 0.5)
                    heads++;
                else
                    tails++;
            }
            Console.WriteLine("Head count: " + heads);
            Console.WriteLine("Tail count: " + tails);

            headPercentage = (heads / num) * 100;
            Console.WriteLine("Heads percentage: " + headPercentage);
            tailPercentage = (tails / num) * 100;
            Console.WriteLine("Tail percentage: " + tailPercentage);
        }
    }
}