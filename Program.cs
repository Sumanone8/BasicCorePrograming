using System;

namespace BasicCorePrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fellow Learners!\nWelcome to Basic Core Programs.\nEnter the index no. of the program you want to run.");
            Console.WriteLine("1.Flip the Coin\n2.Leap Year\n3.Power Of 2\n4.Harmonic Number\n5.Factors\n6.Quotient And Remainder\n7.Swap Numbers\n8.Even Odd Checker\n9.Vowel Consonant Checker\n10.Largest Number\n11.Duplicate Elements\n12.Unique Elements\n13.Count Element Frequency\n14.Max and Min Elements in an Array\n15.Pattern Printing\n16.Pattern B\n17.Reverse Each Word in a String\n18.Sum of Digits\n19.Convert First Letter Capital\n20.Two Lowest Numbers Sum");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipTheCoin.FlipCoin();
                    break;
                case 2:
                    LeapYearChecker.CheckLeapYear();
                    break;
                case 3:
                    PowerOf2.Power2();
                    break;
                case 4:
                    HarmonicNumber.PrintHarmonicNumber();
                    break;
                case 5:
                    Factors.PrintPrimeFactors();
                    break;
                case 6:
                    QuotientAndRemainder.ComputeQuotientAndRemainder();
                    break;
                case 7:
                    SwapNumbers.SwapTwoNumbers();
                    break;
                case 8:
                    EvenOddChecker.CheckEvenOrOdd();
                    break;
                case 9:
                    VowelConsonantChecker.CheckVowelOrConsonant();
                    break;
                case 10:
                    LargestNumber.FindLargestNumber();
                    break;
                case 11:
                    int[] arr = { 1, 2, 3, 4, 2, 5, 6, 3, 7, 2, 8, 9, 1, 5 };
                    DuplicateElements.FindDuplicateElements(arr);
                    break;
                case 12:
                    int[] arrayForUniqueElements = { 1, 2, 3, 4, 2, 5, 6, 3, 7, 2, 8, 9, 1, 5 };
                    UniqueElements.FindUniqueElements(arrayForUniqueElements);
                    break;
                case 13:
                    int[] arrayForFrequency = { 1, 2, 3, 4, 2, 5, 6, 3, 7, 2, 8, 9, 1, 5, 2, 3, 1, 2 };
                    CountElementFrequency.CountFrequency(arrayForFrequency);
                    break;
                case 14:
                    int[] arrayForMaxMin = { 10, 5, 7, 14, 2, 8, 20, 1 };
                    MaxMinElements.FindMaxMin(arrayForMaxMin);
                    break;
                case 15:
                    PatternPrinting.PrintPattern();
                    break;
                case 16:
                    Pattern16.PrintPattern();
                    break;
                case 17:
                    string inputString = "Hello Fellow Learners";
                    ReverseWords.ReverseEachWord(inputString);
                    break;
                case 18:
                    int number = 12345;
                    SumOfDigits.FindSumOfDigits(number);
                    break;
                case 19:
                    string sentence = "welcome to the RFP batch";
                    ConvertFirstLetterCapital.ConvertFirstLetterToCapital(sentence);
                    break;
                case 20:
                    int[] arrayForTwoLowestNumbers = { 10, -5, 7, -14, 2, 8, -20, 1 };
                    TwoLowestNumbersSum.FindTwoLowestNumbersSum(arrayForTwoLowestNumbers);
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Index No.");
                    break;
            }
            Console.ReadLine();
        }
    }
}