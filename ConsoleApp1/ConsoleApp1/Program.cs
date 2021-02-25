using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2Task1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minimum temperature");
            int Tmin;
            int Tmax;
            string input1 = Console.ReadLine();
            if (Int32.TryParse(input1, out Tmin))
            {
                Console.WriteLine("Enter maximum temperature");
                string input2 = Console.ReadLine();
                if (Int32.TryParse(input2, out Tmax))
                {

                    int Tavr = (Tmin + Tmax) / 2;                   
                    Console.WriteLine($"Average daily temperature is {Tavr}");

                }
                else Console.WriteLine("Input error!Enter a number");
            }
            else Console.WriteLine("Input error!Enter a number");

            
                   

        }
    }
}
