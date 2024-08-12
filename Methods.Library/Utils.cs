using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Library
{
    public class Utils
    {
        //Method 1 - 

        public double ReadNumber(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }

        //Method 2 -
        public void PrintPS(int a)
        {
            Console.WriteLine($"The predecessor is :{a-1}");
            Console.WriteLine($"The sucessor is : {a+1}");

        }

        //Method - 3

        public double ServiceTax(double a)
        {
            double accountValue = a;
            double tax = a*0.1;
            return accountValue + tax;
        }

        //Method - 4

        public int YearToDays(int year)
        {
            int daysOfYear = 365;
            return year*daysOfYear;
        }

        //Method - 5

        public double TriangleArea(double b, double h)
        { 
            return (b * h)/2;
        }

        // Method - 6

        public double WeightXReceipt(double receipt1, double receipt2)
        {

            return (receipt1 * 3) + (receipt2 * 4) / 3 + 4;

        }

        // Method - 7

        public double WeightXReceipt(double receipt1, double receipt2, double weight1, double weight2)
        {

            return (receipt1 * weight1) + (receipt2 * weight2) / weight1 + weight2;

        }

        // Method - 8

        public double ReadValue(double x)
        {
            //y=x2 –3x+1.
            double xElevated2 = Math.Pow(x, 2);
            double y = xElevated2-(3 * x) + 1;
            if (x == 2)
            {
                y = -1;
            }
            return y;
        }

        // Method - 9

        public double ReturnYValue(double a, double b, double c, double x)
        {
            //y = ax2 + bx + c.
            double xElevated2 = Math.Pow(x, 2);
            double y = (a*xElevated2)+(b*x)+c;
               
            return y;

        }

        // Method - 9

        public void Names(string firstName, string secondName)
        {
            Console.WriteLine(secondName+","+ firstName);
        }

        // Method - 10

        


    }
}
