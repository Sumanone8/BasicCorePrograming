using System;
using System.Runtime.ConstrainedExecution;

namespace BasicCorePrograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fellow Learners!\nWelcome to Basic Core Programs.\nEnter the index no. of the program you want to run.");
            Console.WriteLine("1.Flip the Coin\n2.Leap Year\n3.Power Of 2\n4.Harmonic Number\n5.Factors\n6.Quotient And Remainder\n7.Swap Numbers\n8.Even Odd Checker\n9.Vowel Consonant Checker\n10.Largest Number");
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
                default:
                    Console.WriteLine("Please Enter a Valid Index No.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
