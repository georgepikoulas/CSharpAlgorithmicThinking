using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcAreaTriangle
    {
        public void Calculate()
        {
            double baseArea, height, area;
            Console.Write("Please enter the base of the triangle");
            baseArea = double.Parse(Console.ReadLine());

            Console.Write("Please enter the height of the triangle");
            height = double.Parse(Console.ReadLine());


            area = (baseArea * height) / 2;

            Console.WriteLine("The area is " + area);

        }
    }
}
