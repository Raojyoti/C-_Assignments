using System;

namespace Power_of_valune_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=10, power =1 ;
           
             Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

             for (int i=1;i<=num; i++)
             {
                 power = 2 * power;

                 Console.WriteLine(i +" " + power);
             } 
            
        }
    }
}
