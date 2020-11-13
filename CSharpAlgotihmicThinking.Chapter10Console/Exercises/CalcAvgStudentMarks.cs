using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalcAvgStudentMarks
    {
        public void Calculate()
        {
            double testOne , testTwo, testThree, testFour , avg;

            Console.WriteLine("Enter the first test score ");
            testOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second test score ");
            testTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third test score ");
            testThree = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth test score ");
            testFour = double.Parse(Console.ReadLine());

            avg = (testOne + testTwo + testThree) / 4;

            Console.WriteLine("The average score is " + avg);

        }
    }
}
