using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesing
{
    public class Logic
    {
        public static int FabonacciSeries(int n)
        {
            if (n == 0)

                return 0;

            if (n == 1)
                return 1;
            return FabonacciSeries(n - 1) + FabonacciSeries(n - 2);
        }

        public void Fabonacci()
        {
            Console.Write("enter length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FabonacciSeries(i));
            }
            Console.ReadKey();
        }
    }
}
