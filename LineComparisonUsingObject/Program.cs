using System;

namespace LineComparisonUsingObject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation program");

            Line obj = new Line();
            obj.Calculate();

            Console.ReadLine();
        }
    }
}
