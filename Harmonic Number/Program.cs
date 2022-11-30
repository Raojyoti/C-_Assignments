/* Print the Harmonic Series */

using System;

namespace Harmonic_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double result=0.0;
            Console.Write(" Enter number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(" 1/{0} + ", i);
                result = result + 1 / (float)i;
            }
            Console.WriteLine("\n sum of the series upto {0} terms : {1} \n ",n ,result);
        }
    }
}
