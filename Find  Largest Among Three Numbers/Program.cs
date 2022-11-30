/* C# Program to Find the Largest Among Three Number */

using System;

namespace Find__Largest_Among_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 +" is largest number"); 
            }
            else if (num2 > num1 && num2 > num3)
            { 
                Console.WriteLine(num2 + " is largest number");
            }
            else
            {
                Console.WriteLine(num3 + " is largest number");
            }


        }
    }
}
