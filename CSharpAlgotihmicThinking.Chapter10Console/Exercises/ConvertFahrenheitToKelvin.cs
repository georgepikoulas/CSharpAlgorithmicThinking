using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class ConvertFahrenheitToKelvin
    {
        public void Calculate()
        {
            double fahrenheit , kelvin;
            Console.Write("Please enter value of Degrees in Fahreinheit");
            fahrenheit = double.Parse(Console.ReadLine());

            kelvin = (fahrenheit + 459.67) / 1.8;

            Console.WriteLine("The value in degrees Kelvin is " + kelvin);
        }
    }
}
