using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task5
{
    class Program
    {
              public enum Months
        {
            January = 0b000_000_000_001, 
            February = 0b000_000_000_010,
            March = 0b000_000_000_100,
            April = 0b000_000_001_000,
            May = 0b000_000_010_000, 
            June = 0b000_000_100_000, 
            July = 0b000_001_000_000,
            Augest = 0b000_010_000_000, 
            September = 0b000_100_000_000, 
            October = 0b001_000_000_000, 
            November = 0b010_000_000_000, 
            December = 0b100_000_000_000
        }
        static void Main(string[] args)
        {
            //Months Winter = Months.January | Months.February | Months.December;
            //int Winter = 0b100000000011;
            Console.WriteLine("Enter serial number of the current month");
            byte NumMonth;
            Months CurMonth;
            string input = Console.ReadLine();
            if (Byte.TryParse(input, out NumMonth))
            {
                    switch (NumMonth) {
                        case 1: Console.WriteLine("It's January");CurMonth = Months.January;
                    break;
                        case 2:
                            Console.WriteLine("It's February"); CurMonth = Months.February;
                        break;
                        case 3:
                            Console.WriteLine("It's March"); CurMonth = Months.March;
                        break;
                        case 4:
                            Console.WriteLine("It's April"); CurMonth = Months.April;
                        break;
                        case 5:
                            Console.WriteLine("It's May"); CurMonth = Months.May;
                        break;
                        case 6:
                            Console.WriteLine("It's June"); CurMonth = Months.June;
                        break;
                        case 7:
                            Console.WriteLine("It's July"); CurMonth = Months.July;
                        break;
                        case 8:
                            Console.WriteLine("It's Augest"); CurMonth = Months.Augest;
                        break;
                        case 9:
                            Console.WriteLine("It's September"); CurMonth = Months.September;
                        break;
                        case 10:
                            Console.WriteLine("It's October"); CurMonth = Months.October;
                        break;
                        case 11:
                            Console.WriteLine("It's November"); CurMonth = Months.November;
                        break;
                        case 12:
                            Console.WriteLine("It's December"); CurMonth = Months.December;
                        break;
                        default: Console.WriteLine("Enter a number from 1 to 12");
                            return;
                                                }
                bool ItsWinter = CurMonth == Months.December || CurMonth == Months.January || CurMonth == Months.February;
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

                        if (ItsWinter && Tavr>0) Console.WriteLine ("Rainy winter");

                    }
                    else Console.WriteLine("Input error!Enter a number");
                }
                else Console.WriteLine("Input error!Enter a number");
            }
            else Console.WriteLine("Enter a number from 1 to 12");

            
            
            

        }
    }
}
