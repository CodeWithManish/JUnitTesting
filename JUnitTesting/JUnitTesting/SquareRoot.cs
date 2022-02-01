using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUnitTesting
{
  public class SquareRoot
    {
        public void Root(double n1, double n2)
        {
            double x = n1;
            double root;
            int count = 0;

            while (true)
            {
                count++;

                root = 0.5 * (x + (n1 / x));

                if (Math.Abs(root - x) < n2)
                    break;
                x = root;
            }

            Console.WriteLine("The Root is: " + root);
        }
    }
}
