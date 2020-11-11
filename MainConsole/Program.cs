using CSharpAlgotihmicThinking.Algorithms.Chapter.Exercises;
using System;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Fisrt Name");
            var fisrtName = Console.ReadLine();

            Console.WriteLine("Please enter Last Name");
            var lastName = Console.ReadLine();

            //var concatenate = new ConcatenatingNames();
            Console.WriteLine(fisrtName + " "+ lastName);

        }
    }
}
