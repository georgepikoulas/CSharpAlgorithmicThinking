using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcMPG
    {
        public void Calculate()
        {
            double miles, gallons , mpg;
            Console.Write("Enter the miles driven");
            miles = double.Parse(Console.ReadLine());

            Console.Write("Eneter the gallons of gas used");
            gallons = double.Parse(Console.ReadLine());

            mpg = miles / gallons;

            Console.WriteLine("Your Miles per gallon is : " + mpg);

        }
    }
}
