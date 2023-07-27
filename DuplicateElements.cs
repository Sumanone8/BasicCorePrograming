using System;
using System.Collections.Generic;

namespace BasicCorePrograming
{
    internal class DuplicateElements
    {
        public static void FindDuplicateElements(int[] arr)
        {
            // Create a dictionary to store the occurrences of each element in the array
            Dictionary<int, int> elementOccurrences = new Dictionary<int, int>();

            // Traverse through the array and update the dictionary
            foreach (int num in arr)
            {
                if (elementOccurrences.ContainsKey(num))
                {
                    elementOccurrences[num]++;
                }
                else
                {
                    elementOccurrences[num] = 1;
                }
            }

            // Print the duplicate elements in the array
            Console.WriteLine("Duplicate elements in the array:");
            foreach (var kvp in elementOccurrences)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}
