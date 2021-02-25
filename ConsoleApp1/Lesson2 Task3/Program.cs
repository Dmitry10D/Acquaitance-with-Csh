using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num;

            string input = Console.ReadLine();
            if (Int32.TryParse(input, out num))
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("It's even");

                }
                else Console.WriteLine("It's odd");
            }
            else Console.WriteLine("Input error!Enter a number");
        }
    }
}
