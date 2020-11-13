using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcPerimeterCircle
    {
        const double PI = 3.14159;

        public void Calculate()
        {
            double radius, perimeter;
            Console.WriteLine("Plaease enter the radius value ");
            radius = double.Parse(Console.ReadLine());

            perimeter = 2 * PI * radius;
            Console.WriteLine("The perimeter of teh circle is " + perimeter);
        }
    }
}
