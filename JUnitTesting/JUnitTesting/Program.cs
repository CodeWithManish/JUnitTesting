using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1.to calculate the minimum number of notes \nEnter 2.to print temperature value \nEnter 3.to print Square Root");
                    

                bool flag = true;
            while (flag)
            {
                int check = Convert.ToInt32(Console.ReadLine());

                switch (check)
                {
                    case 1:
                        VendingMachine machine = new VendingMachine();
                        machine.Calculate();
                        break;

                    case 2:
                        TemperatureConversion temp = new TemperatureConversion();
                        temp.Conversion();
                        break;

                    case 3:
                        SquareRoot sqrt = new SquareRoot();
                        sqrt.Root(327, 0.00001);
                        break;

                }
            }
        }       
    }
}
