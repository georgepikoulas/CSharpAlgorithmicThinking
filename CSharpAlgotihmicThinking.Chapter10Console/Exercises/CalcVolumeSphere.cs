using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcVolumeSphere
    {
        const float PI = 3.14159F;

        public void Calculate()
        {
            float diameter, volume , radius;
            Console.WriteLine("Plase enter the radius of the sphere ");
            radius = float.Parse(Console.ReadLine());

            //Since the volume requires radius and not rperimeter we must calculate it
            //radius = diameter / 2;

            volume = (float)(4.0 / 3 * PI * radius * radius * radius);

            Console.WriteLine("The volume of teh sphere is " + volume);
        }
    }
}
