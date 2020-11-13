using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcThirdangleTriangle
    {
        public void Calculate()
        {
            int angleOne, angleTwo, angleThree;
            Console.WriteLine("Enter the fisrt angle ");
            angleOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second angle ");
            angleTwo = int.Parse(Console.ReadLine());

            angleThree = 180 - (angleOne + angleTwo);

            Console.WriteLine("The third angle is " + angleThree);

        }
    }
}
