using System;
using System.Globalization;

public class ConvertFirstLetterCapital
{
    public static void ConvertFirstLetterToCapital(string str)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        string result = textInfo.ToTitleCase(str);
        Console.WriteLine("Converted string: " + result);
    }
}
