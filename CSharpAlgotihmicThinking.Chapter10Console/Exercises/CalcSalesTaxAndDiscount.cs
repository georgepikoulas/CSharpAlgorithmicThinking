using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcSalesTaxAndDiscount
    {
        const double VAT = 0.19;
        public void Calculate()
        {
            int discount;
            double salesTax, beforeTaxPrice, finalPrice, discountAmount;
            Console.Write("Please enter the price before tax");
            beforeTaxPrice = double.Parse(Console.ReadLine());

            salesTax = beforeTaxPrice * VAT;

            Console.Write("Please enter the discount offered ");
            discount = Int32.Parse(Console.ReadLine());

            discountAmount = beforeTaxPrice * discount / 100;


            finalPrice = beforeTaxPrice - discountAmount + salesTax;

            Console.WriteLine("The final price with discount and tax is " + finalPrice);

        }
    }
}
