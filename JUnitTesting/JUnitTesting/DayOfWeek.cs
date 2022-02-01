using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitTesting
{
    public class DayOfWeek
    {
        public void Week()
        {
            int month, day, year;
            Console.WriteLine("Enter the month day year \n");
            month = Convert.ToInt32(Console.ReadLine());
            day = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());

            int year1 = year - (14 - month) / 12;
            int x = year1 + year1 / 4 - year1 / 100 + year1 / 400;
            int month1 = month + 12 * ((14 - month) / 12) - 2;
            int day1 = (day + x + 31 * month1 / 12) % 7;



            switch (day1)
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
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;


            }


        }
    }
}
