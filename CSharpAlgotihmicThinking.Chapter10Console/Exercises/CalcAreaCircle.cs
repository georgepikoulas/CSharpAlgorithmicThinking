using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcAreaCircle
    {
        const double PI = 3.14159;
        public void Calculate ()
        {
            double area, radius;
            Console.Write("Enter the length of Radius: ");

            radius = double.Parse(Console.ReadLine());

            area = PI * radius * radius;

            Console.WriteLine("The area of the circle is " + area);
        }
    }
}
