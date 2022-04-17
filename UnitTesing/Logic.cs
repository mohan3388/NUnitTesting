using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VendingMachine
{
    public class evest
    {
        public void MinNumberofnot()
        {

            int[] arr = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] notes = new int[arr.Length];
            Console.WriteLine("enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {

                if (amount > 0)
                {
                    notes[i] = amount / arr[i];
                    amount -= arr[i] * notes[i];
                }


            }


            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i] != 0)
                {
                    Console.WriteLine(arr[i] + "-->" + notes[i]);
                }
            }

        }
    }

}