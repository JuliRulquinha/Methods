using System;
using Methods.Library;

namespace Methods.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Utils utilizing = new Library.Utils();

            utilizing.ReadNumber(5,6,9);

            
            double y = utilizing.ReturnYValue(1, -3, 1, 2);

           // System.Console.WriteLine(y);

        }
    }
}
