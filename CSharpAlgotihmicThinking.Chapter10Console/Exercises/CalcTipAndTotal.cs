using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcTipAndTotal
    {
        public void Calculate()
        {
            int gratuityRate;
            float subTotal, gratuityAmount, final;
            Console.Write("Please  enter the subTotal of the purchase");
            subTotal = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter teh gratuity rate ");
            gratuityRate = int.Parse(Console.ReadLine());

            gratuityAmount = (float)(subTotal * gratuityRate / 100);
            final = gratuityAmount + subTotal;

            Console.WriteLine("The Tip is " + gratuityAmount.ToString("C" , CultureInfo.CurrentCulture));
            Console.WriteLine("The Total is " + final.ToString("C", CultureInfo.CurrentCulture));
        }
    }
}
