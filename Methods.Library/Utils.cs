using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
            Console.WriteLine($"The predecessor is :{a - 1}");
            Console.WriteLine($"The sucessor is : {a + 1}");

        }

        //Method - 3

        public double ServiceTax(double a)
        {
            double accountValue = a;
            double tax = a * 0.1;
            return accountValue + tax;
        }

        //Method - 4

        public int YearToDays(int year)
        {
            int daysOfYear = 365;
            return year * daysOfYear;
        }

        //Method - 5

        public double TriangleArea(double b, double h)
        {
            return (b * h) / 2;
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
            double y = xElevated2 - (3 * x) + 1;
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
            double y = (a * xElevated2) + (b * x) + c;

            return y;

        }

        // Method - 9

        public void Names(string firstName, string secondName)
        {
            Console.WriteLine(secondName + "," + firstName);
        }

        // Method - 10

        public double InvoiceTax(double productPrice)
        {
            double payment = productPrice;
            string formOfPayment = Console.ReadLine();

            Console.WriteLine("Would you like to pay the full price?");
            Console.WriteLine(formOfPayment);

            if (formOfPayment == "Y")
            {
                payment = productPrice;

            }
            else if (formOfPayment == "N")
            {
                Console.WriteLine("In how many times would you like to split the full price?");
                string split = Console.ReadLine();
                Console.WriteLine(split);

                if (split == "2")
                {
                    payment = (productPrice / 2) + (payment * 0.1);
                }
                else if (split == "3")
                {
                    payment = (productPrice / 3) + (payment * 0.2);
                }
                else if (split == "4")
                {
                    payment = (productPrice / 4) + (payment * 0.4);
                }
            }
            Console.WriteLine($"You'll be paying: {payment}.");
            return payment;
        }
        public int CountBeers(int amount)
        {
            int beerBox = amount / 24;
            int remainder = amount % 24;

            Console.WriteLine($"{amount} beers = {beerBox} boxes and {remainder} bottles.");

            return beerBox;

        }
        public double CalculateBeerProfit(double numberOfBeer)
        {
            double cost = numberOfBeer * 1.80;
            double beerPrice = 2.10;
            double totalPrice = numberOfBeer * beerPrice;
            double profit = totalPrice - cost;
            double grossRevenue = numberOfBeer * beerPrice;

            Console.WriteLine($"The cost is {cost}\n The gross revenue is {grossRevenue} \n The profit is {profit}");
            return cost;


        }

        public double DecresingOrder(double numb1, double numb2)
        {
            double biggerNumber = 0;
            double smallerNumber = 0;

            if (numb1 > numb2)
            {
                biggerNumber = numb1;
                smallerNumber = numb2;
            }
            else if (numb1 < numb2)
            {
                biggerNumber = numb2;
                smallerNumber = numb1;
            }
            Console.WriteLine($"The bigger number is {biggerNumber} and the smaller number is {smallerNumber}");
            return 0;
        }
        /// <summary>
        /// Calculates the average between two given elements.
        /// </summary>
        /// <param name="grade1"></param>
        /// <param name="grade2"></param>
        /// <returns></returns>
        public double CalculateAverage(double grade1, double grade2)
        {

            double average = (grade1 + grade2) / 2;

            if (average < 7)
            {
                Console.WriteLine($"Your average is: {average}\nStatus: You failed.");
            }
            else
            {
                Console.WriteLine($"Your average is: {average}\nStatus: You're approved.");
            }
            return average;
        }
        public void CalculateAllowance(string name, char sex, char civilStatus, int age, double salary)
        {

            double allowance = 0;
            double husbandSalary = 0;
            double fatherSalary = 0;

            if (sex == 'M')
            {
                if (age <= 18)
                {
                    fatherSalary = salary;
                    allowance = salary * 0.15;

                }
                else
                {
                    allowance = 0;
                }
            }
            else if (sex == 'F')
            {
                if (age < 21 && civilStatus == 'S')
                {
                    fatherSalary = salary;
                    allowance = fatherSalary * 0.2;
                }
                else if (civilStatus == 'C')
                {
                    husbandSalary = salary;
                    allowance = husbandSalary * 0.3;
                }
                else if (age > 21 && civilStatus == 'S')
                {
                    allowance = 0;
                }
            }

            Console.WriteLine($"Name: {name} Allowance: {allowance}");


        }
        /// <summary>
        /// This method analyses which number is the smallest among the other 2 elements.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="n3"></param>
        public void SmallestNumber(double n1, double n2, double n3)

        {
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine($"The smallest number between {n2} and {n3} is: {n1}");
            }

            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine($"The smallest number between {n1} and {n3} is: {n2}");
            }

            else if (n3 < n1 && n3 < n2)
            {
                Console.WriteLine($"The smallest number between {n1} and {n2} is: {n3}");
            }

        }
        /// <summary>
        /// Receives 3 numbers and write them in increasing order.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="n3"></param>
        public void IncresingOrder(double n1, double n2, double n3)
        {


            if (n1 != n2 || n2 != n3 || n1 != n3)
            {
                double biggestNumber = 0;
                double middleNumber = 0;
                double smallestNumber = 0;

                if (n1 > n2 && n1 > n3 && n2 > n3)
                {
                    biggestNumber = n1;
                    middleNumber = n2;
                    smallestNumber = n3;
                }
                else if (n2 > n1 && n2 > n3 && n1 > n3)
                {
                    biggestNumber = n2;
                    middleNumber = n1;
                    smallestNumber = n3;
                }
                else if (n3 > n1 && n3 > n2 && n2 > n1)
                {
                    biggestNumber = n3;
                    middleNumber = n2;
                    smallestNumber = n1;
                }
                else if (n3 < n2 && n3 > n1)
                {
                    biggestNumber = n2;
                    middleNumber = n3;
                    smallestNumber = n1;
                }
                else if (n2 < n1 && n2 < n3 && n3 > n1)
                {
                    biggestNumber = n3;
                    middleNumber = n1;
                    smallestNumber = n2;
                }

                Console.WriteLine($"Numbers in order: {smallestNumber}, {middleNumber} and {biggestNumber}");
            }
            else if (n1 == n2 && n1 != n3 && n2 == n3 && n1 == n3)
            {
                Console.WriteLine("Can you please not ruin my method? Thank you! ");
                return;
            }








        }

        public void IncreasingOrder2(params double[] numbers)
        {

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}


