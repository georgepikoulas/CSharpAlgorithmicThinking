using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcDistanceTravelled
    {
        public void Calculate()
        {
            double distance, acceleration, time;
            Console.Write("Please enter the time the car is moving");
            time = double.Parse(Console.ReadLine());

            Console.Write("Please enter the acceleration");
            acceleration = double.Parse(Console.ReadLine());

            distance = 0.5 * (acceleration * time * time) ;

            Console.WriteLine("The distance the car travelled is " + distance + " meters");
        }
    }
}
