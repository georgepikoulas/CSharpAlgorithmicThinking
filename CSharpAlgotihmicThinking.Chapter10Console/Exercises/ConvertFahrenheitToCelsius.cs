using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgotihmicThinking.Chapter10Console.Exercises
{
    public class d
    {
        public void Calculate()
        {
            float fahrenheit, celsius;
            Console.Write("Please enter value of Degrees in Fahreinheit");
            fahrenheit = float.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) / 9 * 5 ;

            Console.WriteLine("The conversion in celsius " + celsius);
        }
    }
}
