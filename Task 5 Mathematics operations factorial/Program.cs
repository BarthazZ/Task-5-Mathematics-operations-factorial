using System;

namespace Task_5_Mathematics_operations_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //A: Ask the user for a number.
            Console.WriteLine("Please enter some number:");

            //B: Load the number provided by the user.
            string somenr = Console.ReadLine();
            int snr = int.Parse(somenr);

            //C: Use the while loop to calculate the value of n !. Don't use recursion.
            int fctr = 1;
            int n = snr;
            int cn = n;

            while (n != 0)
            {
                fctr *= n;
                n--;
            }

            Console.WriteLine(cn + "! = " + fctr);
        }
    }
}
