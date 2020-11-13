using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcTipAndSalesTax
    {
        const double VAT = 0.07;
        const double TIP = 0.1;

        public void Calculate()
        {
            double salesTax, beforeTaxPrice, finalPrice, tipAmount;
            Console.Write("Please enter the price before tax");
            beforeTaxPrice = double.Parse(Console.ReadLine());

            salesTax = beforeTaxPrice * VAT;
            tipAmount = beforeTaxPrice * TIP;

            finalPrice = beforeTaxPrice + salesTax + tipAmount;

            
            Console.WriteLine("The total price is " + finalPrice);
            Console.WriteLine("The sales tax amount is  " + salesTax);
            Console.WriteLine("The tip amount is " + tipAmount);

        }
    }
}
