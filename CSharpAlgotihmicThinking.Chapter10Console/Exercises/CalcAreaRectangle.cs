using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcAreaRectangle
    {
        public  void Calculate()
        {
            double area, baseSide, height;
            Console.Write("Enter the lenght of the Base :");
            baseSide = Double.Parse(Console.ReadLine());

            Console.Write("Enter the legth of Height:");
            height = Double.Parse(Console.ReadLine());

            area = baseSide * height;

            Console.WriteLine("The Area of the rectangle is " + area);
        }
    }
}
