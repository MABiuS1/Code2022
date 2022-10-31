using System;

namespace ConsoleAppCh8Q3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a 3-digit integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The summation of 3-digit is " + SumDigits(number));
        }
        public static int SumDigits ( int value) 
        {
            int sum = 0;
                while (value != 0)
                {
                    int rem;
                    value = Math.DivRem(value, 10, out rem);
                    sum += rem;
                }
                return sum;
        }
    }
}
