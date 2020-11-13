using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalculatingSalesTax
    {
        const double VAT = 0.19;

        public void Calculate()
        {
            double salesTax, beforeTaxPrice, finalPrice;
            Console.Write("Please enter the price before tax");
            beforeTaxPrice = double.Parse(Console.ReadLine());

            salesTax = beforeTaxPrice * VAT;

            finalPrice = beforeTaxPrice + salesTax;

            Console.WriteLine("The final price afetr tax is " + finalPrice);

        }
    }
}
