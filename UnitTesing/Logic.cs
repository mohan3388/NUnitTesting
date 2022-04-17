using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class TempratureCon
    {
        public void CelTOFer()
        {
            Console.WriteLine("enter To convert Celcious to Fahrenheit: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int cel = n * 9 / 5 + 32;
            Console.WriteLine(cel);
        }
        public void FerToCel()
        {
            Console.WriteLine("enter To convert Fahrenheit to Celcious : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fer = n - 32 * 5 / 9;
            Console.WriteLine(fer);
        }
    }
}
