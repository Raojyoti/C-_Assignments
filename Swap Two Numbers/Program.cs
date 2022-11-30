/*  C# Program to Swap Two Numbers     */

using System;

namespace Swap_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values of a and b : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
             a = a + b;
             b = a - b; 
             a = a - b;  

            Console.WriteLine("Values of a and b after swapping: {0} {1} ", a, b);

        }
    }
}
