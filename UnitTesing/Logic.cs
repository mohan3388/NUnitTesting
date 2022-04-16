using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesing
{
    public class Logic
    {
        int sum = 0;
        public void PerfectNumber()
        {
            Console.WriteLine("Enter a Number To check Number is perfect or not");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == temp)
            {
                Console.WriteLine("Number is Perfect Number :" + " " + sum);
            }
            else
            {
                Console.WriteLine("Number is mot perfect Number :" + " " + sum);
            }
        }
    }
}
