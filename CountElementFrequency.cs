using System;
using System.Collections.Generic;

public class CountElementFrequency
{
    public static void CountFrequency(int[] arr)
    {
        Console.WriteLine("Element\tFrequency");
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int element in arr)
        {
            if (frequencyMap.ContainsKey(element))
            {
                frequencyMap[element]++;
            }
            else
            {
                frequencyMap[element] = 1;
            }
        }

        foreach (var kvp in frequencyMap)
        {
            Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
        }
    }
}