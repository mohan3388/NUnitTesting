using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesing
{
    public class Logic
    {
        int Num, checkprime = 1;
        public void CheckPrime()
        {
            Console.Write("Enter Number To Check Number is prime or not:");
            Num = Convert.ToInt16(Console.ReadLine());
            for (int i = 2; i <= Num / 2; i++)
            {
                if (Num % i == 0)
                {
                    checkprime = 0;
                }

            }
            if (checkprime == 1)
            {
                Console.Write(Num + " Prime Number");
            }
            else
            {
                Console.Write(Num + " Not Prime Number");
            }
        }
    }
}
