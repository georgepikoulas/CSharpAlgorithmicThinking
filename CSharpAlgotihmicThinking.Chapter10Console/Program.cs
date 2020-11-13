
using System;
using CSharpAlgotihmicThinking.Chapter10Console;
using CSharpAlgotihmicThinking.Chapter10Console.Exercises;

namespace CSharpAlgotihmicThinking.Chapter10Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var calcAreaRec = new CalcAreaRectangle();
            //calcAreaRec.Calculate();

            //var calcAreCircle = new CalcAreaCircle();
            //calcAreCircle.Calculate();

            //var mpg = new CalcMPG();
            //mpg.Calculate();

            var distance = new CalcDistanceTravelled();
            distance.Calculate();
        }
    }
}
