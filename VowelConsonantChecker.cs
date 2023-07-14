using System;

namespace BasicCorePrograming
{
    internal class VowelConsonantChecker
    {
        public static void CheckVowelOrConsonant()
        {
            Console.WriteLine("Enter an alphabet: ");
            char alphabet = Console.ReadLine().ToLower()[0];

            if (IsAlphabet(alphabet))
            {
                if (IsVowel(alphabet))
                {
                    Console.WriteLine("The alphabet is a vowel.");
                }
                else
                {
                    Console.WriteLine("The alphabet is a consonant.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid alphabet.");
            }
        }

        private static bool IsAlphabet(char c)
        {
            return (c >= 'a' && c <= 'z');
        }

        private static bool IsVowel(char c)
        {
            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
        }
    }
}
