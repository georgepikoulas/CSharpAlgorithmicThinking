using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcKWhCost
    {
        const double VAT = 0.20;
        const double kWhCost = 0.06;

        public void Calculate()
        {
            int kWhStartOfMonth, kWhEndOfMonth , consumed , endCost;
            double finalCost;

            Console.WriteLine("Please enter the kWh reading for start of month");
            kWhStartOfMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the kWh reading for end of month");
            kWhEndOfMonth = int.Parse(Console.ReadLine());
            consumed = (kWhEndOfMonth - kWhStartOfMonth);
            finalCost = consumed * 0.06;
            finalCost += finalCost * VAT;

            Console.WriteLine("The final cost kWh cost is " + finalCost.ToString("C"));

        }
    }
}
