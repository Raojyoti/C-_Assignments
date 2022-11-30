/*  C# Program to Check Whether a Number is Even or Odd */

using System;

namespace Check__Number_is_Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num+ " is Even Number");
            }
            else 
            { 
                Console.WriteLine(num+" is Odd Number"); 
            }
        }
    }
}
