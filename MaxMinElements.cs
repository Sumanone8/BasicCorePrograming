using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograming
{
    internal class MaxMinElements
    {
        public static void FindMaxMin(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("The array is empty.");
                return;
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
        }
    }
}
