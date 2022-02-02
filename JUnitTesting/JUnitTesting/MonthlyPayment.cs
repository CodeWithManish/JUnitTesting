using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitTesting
{
    internal class MonthlyPayment
    {
        double principle = 0, rate = 0, years = 0;

        public double CalculateResult(double principle, double rate, double years)
        {
            double n = 12 * years;
            double r = rate/ (12 * 100);

            double payment = (principle * r) / 1 - (Math.Pow((1 + r), 1 / n));
            return payment;
        }
        public void CalMonthlyPayment()
        {
            Console.WriteLine("Enter the principle amount");
            principle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the rate of interest");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the no of years");
            years = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Monthly Payment user  Rs is. " + CalculateResult(principle, rate, years));
        }
    }



}
