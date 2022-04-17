using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class BinaryConversion
    {
        public void Conversion()
        {
            int i;

            Console.WriteLine("enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[num];
            for (i = 0; num > 0; i++)
            {
                a[i] = num % 2;
                num = num / 2;

            }

            Console.WriteLine("banary of the given number");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }

        }
    }
}
