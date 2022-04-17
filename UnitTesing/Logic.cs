using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class SqrtNewtonMethod
    {
        public static void Sqrt()
        {
            Console.WriteLine("enter number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            double t = c;
            double l = 0.00001;
            double sqrtNumber;
            int count = 0;
            while (true)
            {
                count++;
                sqrtNumber = 0.5 * (t + (c / t));

                if (Math.Abs(sqrtNumber - t) < l)

                    break;
                t = sqrtNumber;

            }
            Console.WriteLine("sqrt given number is: " + sqrtNumber);

        }

    }
}
