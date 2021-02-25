using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task2
{
    class Program
    {
        public enum Months
        {
            January = 1, February, March, April, May, June, July, Augest, September, October, November, December
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter serial number of the current month");
            byte CurMonth;

            string input = Console.ReadLine();
            if (Byte.TryParse(input, out CurMonth))
            {
                if (CurMonth != 0 || CurMonth <= 12)
                {
                    Console.WriteLine($"It's {(Months)CurMonth}");

                }
                else Console.WriteLine("Enter a number from 1 to 12");
            }
            else Console.WriteLine("Enter a number from 1 to 12");
        }
    }
}
