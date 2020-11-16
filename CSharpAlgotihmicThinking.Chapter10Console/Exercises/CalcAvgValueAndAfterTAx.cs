using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcAvgValueAndAfterTAx
    {
        const double VAT = 0.20;
        public void Calculate()
        {
            double beforeTax1, beforeTax2, beforeTax3;
            double afterTax1, afterTax2, afterTax3;
            double avgValue;
            double salesTaxProduct1, salesTaxProduct2, salesTaxProduct3;

            Console.WriteLine("Please enter the priceof product 1 before tax");
            beforeTax1 = double.Parse(Console.ReadLine());
            salesTaxProduct1 = VAT * beforeTax1;
            afterTax1 = salesTaxProduct1 + beforeTax1;

            Console.WriteLine("Please enter the price of product 2 before tax");
            beforeTax2 = double.Parse(Console.ReadLine());
            salesTaxProduct2 = VAT * beforeTax2;
            afterTax2 = salesTaxProduct2 + beforeTax2;

            Console.WriteLine("Please enter the price product 3 before tax");
            beforeTax3 = double.Parse(Console.ReadLine());
            salesTaxProduct3 = VAT * beforeTax3;
            afterTax3 = salesTaxProduct3 + beforeTax3;

            avgValue = (afterTax1 + afterTax2 + afterTax3) / 3;

            Console.WriteLine("The after tax of product 1 " + afterTax1.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("The after tax of product 2 " + afterTax2.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("The after tax of product 3 " + afterTax3.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine("The average value of the products is " + avgValue.ToString("C", CultureInfo.CurrentCulture));

        }
    }
}
