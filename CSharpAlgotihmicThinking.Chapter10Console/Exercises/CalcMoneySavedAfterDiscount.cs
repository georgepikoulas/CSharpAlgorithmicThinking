using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcMoneySavedAfterDiscount
    {
        public void Calculate ()
        {
            int discount;
            double beforeDiscount, discountAmount, moneySaved, finalPrice;
            Console.WriteLine("Please enter the initial price ");
            beforeDiscount = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the discount 0 to 100");
            discount = int.Parse(Console.ReadLine());

            discountAmount = (double)(beforeDiscount * discount) / 100;

            finalPrice = beforeDiscount - discountAmount;
            moneySaved = finalPrice - beforeDiscount;

            Console.WriteLine("Final price " + finalPrice.ToString("C"));
            Console.WriteLine("Money Saved " + moneySaved.ToString("C"));

        }
    }
}
