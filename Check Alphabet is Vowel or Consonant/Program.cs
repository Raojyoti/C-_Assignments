/* C# Program to Check Whether an Alphabet is Vowel or Consonant   */

using System;

namespace Check_Alphabet_is_Vowel_or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Character: ");
            char ch =Convert.ToChar(Console.ReadLine());
            switch (ch) 
            {
                 case 'a':
                     Console.WriteLine(ch + " is vowel");
                      break;
                case 'e':
                    Console.WriteLine(ch + " is vowel");
                    break;
                case 'i':
                    Console.WriteLine(ch + " is vowel");
                    break;
                case 'o':
                    Console.WriteLine(ch + " is vowel");
                    break;
                case 'u':
                    Console.WriteLine(ch + " is vowel");
                    break;
                default:
                    Console.WriteLine(ch + " is Consonant");
                    break;

            }
        }
    }
}
