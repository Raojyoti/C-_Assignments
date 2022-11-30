using System;

namespace Compute_Quotient_and_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of Dividend :  ");
            double Dividend = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the values of Divisor:  ");
            double Divisor = Convert.ToDouble(Console.ReadLine());
            double Quotient = Dividend / Divisor;
            double Remainder = Dividend % Divisor;
            Console.WriteLine("Quotient is: " + Quotient);
            Console.WriteLine("Remainder is: " + Remainder);

        }
    }
}
