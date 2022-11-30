/* Check Leap Year or not */

using System;

namespace Check_Leap_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter four digit year value: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is Leap Year ");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine(year + " is Leap Year ");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine(year + " is not Leap Year ");
            }
            else 
            {
                Console.WriteLine(year + " is not Leap Year ");
            }
        }
    }
}
