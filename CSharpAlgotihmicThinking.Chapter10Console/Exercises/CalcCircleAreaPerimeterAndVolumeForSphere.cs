using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcCircleAreaPerimeterAndVolumeForSphere
    {
        const float PI = 3.14159F;

        public void Calculate()
        {
            float diameter;
            float radius, perimeter, area;
            float volumeSphere;

            Console.WriteLine("Enter the diameter for calculation ");
            diameter = float.Parse(Console.ReadLine());

            radius = diameter / 2;

            perimeter = 2 * PI * radius;
            area = PI * radius * radius;

            volumeSphere = (float)(4.0 / 3 * PI * radius * radius * radius);

            Console.WriteLine("The radius is " + radius + " the perimeter is " + perimeter + " the area is " + area + " the voluem is " + volumeSphere);

        }
    }
}
