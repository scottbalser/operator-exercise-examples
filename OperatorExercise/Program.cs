using System;
using System.Dynamic;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

                       // var r = radius;
            var pi = Math.PI;

            Console.WriteLine("What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());
            var  answer = AreaOfCircle(radius);

            Console.WriteLine($"The area of {radius} is {answer}");
        }

        public static double AreaOfCircle(double r)
        {
            return Math.PI * (r * r);
        }

    }
}

    
