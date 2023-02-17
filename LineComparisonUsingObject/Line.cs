using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonUsingObject
{
    public class Line
    {
        public void Calculate()
        {
            Console.WriteLine("Enter the value of X1 and Y1");
            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of X2 and Y2");
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2 = Convert.ToDouble(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((Y2 - Y1), 2) + Math.Pow((X2 - X1), 2));
            Console.WriteLine("Length of line is : " + length);
        }
    }
}
