using System;
using System.Text;

public class ReverseWords
{
    public static void ReverseEachWord(string str)
    {
        string[] words = str.Split(' ');

        StringBuilder reversedString = new StringBuilder();

        foreach (string word in words)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            reversedString.Append(new string(charArray));
            reversedString.Append(" ");
        }

        string result = reversedString.ToString().Trim();
        Console.WriteLine("Reversed string: " + result);
    }
}
