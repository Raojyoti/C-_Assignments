/* Flip Coin and print percentage of Heads and Tails */

using System;

namespace Flip_Coin_and_print_percentage_of_Heads_and_Tails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double head = 0, tail = 0, count = 1;
            double result;
            Console.Write("Enter the number of flip: ");
            int numflip = Convert.ToInt32(Console.ReadLine());
            while (count < numflip)
            {
                Random ran = new Random();
                result = ran.NextDouble();
                
                Console.WriteLine(result);
                if (result < 0.5)
                {
                    head++;
                    Console.WriteLine("head");
                }
                else 
                {
                    tail++;
                    Console.WriteLine("tails");
                }
                count++;
            }
            Console.WriteLine("Number of Heads: " + head);
            Console.WriteLine("Number of Tails: " + tail);

            double headpercentage = Convert.ToDouble((head * 100) /numflip);
            double tailpercentage = Convert.ToDouble((tail * 100) / numflip);

            Console.WriteLine("Percentage of Heads: " + headpercentage);
            Console.WriteLine("Percentage of Tails: " + tailpercentage);
        }
    }
}
