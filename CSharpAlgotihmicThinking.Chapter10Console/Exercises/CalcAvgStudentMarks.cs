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

            List<double> Students = new List<double>();

            Console.WriteLine("Enter the first test score ");
            testOne = double.Parse(Console.ReadLine());
            Students.Add(testOne);

            Console.WriteLine("Enter the second test score ");
            testTwo = double.Parse(Console.ReadLine());
            Students.Add(testTwo);

            Console.WriteLine("Enter the third test score ");
            testThree = double.Parse(Console.ReadLine());
            Students.Add(testThree);

            Console.WriteLine("Enter the fourth test score ");
            testFour = double.Parse(Console.ReadLine());
            Students.Add(testFour);
            avg = (testOne + testTwo + testThree + testFour) / Students.Count;

            Console.WriteLine("The average score is " + avg);

        }
    }
}
