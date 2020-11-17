using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter11Console.Exercises
{
    public class CalcDistanceBetweenTwoPoints
    {
        public void Calculate()
        {
            double distance, coordx1, coordy1, coordx2, coordy2, xTemp, yTemp;

            Console.WriteLine("Please enter the coordinates x,y for point A: ");
            coordx1 = double.Parse(Console.ReadLine());
            coordy1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the coordinates x,y for point B: ");
            coordx2 = double.Parse(Console.ReadLine());
            coordy2 = double.Parse(Console.ReadLine());

            xTemp = Math.Pow(coordx1 - coordx2, 2);
            yTemp = Math.Pow(coordy1 - coordy2, 2);

            distance = Math.Sqrt(xTemp + yTemp);

            Console.WriteLine("Distance between the points inserted is " + distance);
        }
    }
}
