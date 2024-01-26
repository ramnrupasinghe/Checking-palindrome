using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkingpalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's see if your word is a palindrome or not ");
            string again;

            do
            {
                Console.WriteLine("Enter any word:");
                string word;
                
                do
                {
                    word = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(word) && ContainsOnlyLetters(word))
                    {
                        if (IsPalindrome(word))
                        {
                            Console.WriteLine($"{word} is a palindrome.");
                        }
                        else
                        {
                            Console.WriteLine($"{word} is not a palindrome.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid word : ");
                    }

                } while (string.IsNullOrWhiteSpace(word) || !ContainsOnlyLetters(word));

                Console.WriteLine("Do you want to check another word? (Y/N) : ");
                again = Console.ReadLine();

                while (!(again.ToUpper() == "Y" || again.ToUpper() == "N"))
                {
                    Console.WriteLine("Invalid input. Please enter valid input (Y/N) : ");
                    again = Console.ReadLine();
                }

            } while (again.ToUpper() == "Y");

            if (again.ToUpper() == "N")
            {
                Console.WriteLine("Please press Enter key to exit...  ");
                Console.ReadLine();
            }

        }

        static bool IsPalindrome(string word)
        {
            word = word.ToLower();

            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;

        }

        static bool ContainsOnlyLetters(string input)
        {
            foreach (char character in input)
            {
                if (!char.IsLetter(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
