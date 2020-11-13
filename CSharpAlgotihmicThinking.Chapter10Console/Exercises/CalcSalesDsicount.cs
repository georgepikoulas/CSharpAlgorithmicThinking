using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcSalesDsicount
    {
        public void Calculate()
        {
            int discount;
            double initialPrice, discountAmount, finalPrice;
            Console.Write("Please enter the inital price ");
            initialPrice = double.Parse(Console.ReadLine());

            Console.Write("Please enter the discount offered ");
            discount = Int32.Parse(Console.ReadLine());


            discountAmount = initialPrice * discount / 100;

            finalPrice = initialPrice - discountAmount;
            Console.WriteLine("The final price with discount is " + finalPrice);

        }

    }
}
