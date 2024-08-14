using System;
using System.Linq;
using Methods.Library;

namespace Methods.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Utils utilizing = new Library.Utils();



            //utilizing.CalculateAllowance("Junior", 'M', 'S', 15, 2400);

            //utilizing.SmallestNumber(9999, 800, 80);

            var numbers = new List<int> { 5, 7, 63, 846 };
            var doubledNumbers = new List<int>();

            int DoubleNumber(int num) 
            {
                return num * 2;
            }



            foreach (int x in numbers)
            {
                System.Console.WriteLine(x);
                int y = DoubleNumber(x);
                doubledNumbers.Add(y);
                
            }

            utilizing.IncreasingOrder2(5,5,63,521,36);




        }
    }
}
