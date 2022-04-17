using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class MonthlyPayment
    {
        public void CalMonthlyPayment(double principal, double year, double rateOfIntrest)
        {
            double rateOfInterestMonthly = rateOfIntrest / (12 * 100);//rate of intrest monthly
            double n = 12 * year;//year in monthly
            double payment = (principal * rateOfInterestMonthly) / (1 - Math.Pow((1 + rateOfInterestMonthly), (-n)));
            Console.WriteLine("Monthly payment is:" + payment);
        }
    }
}
