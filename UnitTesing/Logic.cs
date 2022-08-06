using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesing
{
    public class Logic
    {
        public static void FabonacciSeries()
        {
            int n1=0, n2=1,i,n3;
            Console.WriteLine("Fabonacci Series");
            Console.WriteLine("Enter number: "); 
            int num = Convert.ToInt32(Console.ReadLine()); //num=8
            Console.Write(n1 + " , " + n2+" , ");  //n1=0, n2=1
            for(i=2; i<num;i++)   //i=2; i<8; i++
            {
                n3 = n1 + n2;  //n3=0+1 =1
                n1 = n2;     //0=1
                n2 = n3;     //1=1
                Console.Write("{0} , ", n3); //1
            }
        }
    }
}
