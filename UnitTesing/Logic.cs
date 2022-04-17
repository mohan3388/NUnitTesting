using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class DayofWeek
    {
        public void Week()
        {

            Console.WriteLine("enter the number of day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of year");
            int year = Convert.ToInt32(Console.ReadLine());

            int year0 = year - (14 - month) / 12;
            int leapyear = year0 + year0 / 4 - year0 / 100 + year0 / 400;
            int month0 = month + 12 * ((14 - month) / 12) - 2;
            int day0 = (day + (leapyear * month0) / 12) % 7;

            switch (day0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;

                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thrusday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
        public void Month()
        {
            Console.WriteLine("enter the number of day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of year");
            int year = Convert.ToInt32(Console.ReadLine());

            int year0 = year - (14 - month) / 12;
            int leapyear = year0 + year0 / 4 - year0 / 100 + year0 / 400;
            int month0 = month + 12 * ((14 - month) / 12) - 2;

            switch (month0)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("Fabruary");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;

            }
        }

    }
}
