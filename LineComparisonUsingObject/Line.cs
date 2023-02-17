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
            double length1 = Math.Sqrt(Math.Pow((Y2 - Y1), 2) + Math.Pow((X2 - X1), 2));
            Console.WriteLine("Length of line 1 is : " + length1);
            Console.WriteLine("Enter the value of X3 and Y3");
            double X3 = Convert.ToDouble(Console.ReadLine());
            double Y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of X4 and Y4");
            double X4 = Convert.ToDouble(Console.ReadLine());
            double Y4 = Convert.ToDouble(Console.ReadLine());
            double length2 = Math.Sqrt(Math.Pow((Y4 - Y3), 2) + Math.Pow((X4 - X3), 2));
            Console.WriteLine("Length of line 2 is : " + length2);
            double result = length1.CompareTo(length2);
            if (result > 0)
                Console.WriteLine("Line 1 is greater than Line 2");
            else if (result < 0)
                Console.WriteLine("Line 1 is less than Line 2");
            else
                Console.WriteLine("Line 1 is equal to Line 2");
        }
    }
}
