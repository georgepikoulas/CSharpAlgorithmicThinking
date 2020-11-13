using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class CalculateBMI
    {
        const float bmiCalculator = 703.0f;
        public void Calculate()
        {
            float weight, height , bmi;
            Console.WriteLine("Please enter the HEight ");
            height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enete the Weight ");
            weight = float.Parse(Console.ReadLine());

            bmi = weight * bmiCalculator /( height * height);

            Console.WriteLine("The BMI index is " + bmi);

        }
    }
}
