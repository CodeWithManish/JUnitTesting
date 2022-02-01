using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitTesting
{
    public class BinaryConversion
    {
        public void Conversion()
        {
            Console.Write("Enter the Decimal Number : ");
            int number = int.Parse(Console.ReadLine());

            string Result = string.Empty;
            for (int i = 0;  0<number ; i++)
            {
                Result = number % 2 + Result;
                number = number / 2;
            }
            Console.WriteLine($"Binary Represenation of the given Number : {Result}");

            Console.ReadLine();
        }
    }
}
