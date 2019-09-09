using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDeliverableOneJH
{
    class Program
    {
        static void Main(string[] args)
        {
            double responseOne, responseTwo, responseThree;
            bool correctInput = true;
            while (correctInput == true)
            {
                Console.WriteLine("Welcome to the currency format converter! Please enter 3 dollar amounts that you wish to be converted!");
                try
                {
                    responseOne = Convert.ToDouble(Console.ReadLine());
                    responseTwo = Convert.ToDouble(Console.ReadLine());
                    responseThree = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} {1} {2}", responseOne, responseTwo, responseThree);
                    Calculations(responseOne,responseTwo,responseThree);
                    correctInput = false;
                }
                catch { Console.WriteLine("Im sorry, that is not a valid response, please try again!"); }
            }
            
        }
        private static void Calculations(double first, double second, double third)
        {
            double[] arrayOne = { first, second, third};
            double max = arrayOne.Max();
            double min = arrayOne.Min();
            double average = arrayOne.Average();
            Console.WriteLine("Your largest number is " 
                + max + "\n Your smallest number is " + min + 
                "\nThe average of the numbers is " + average);
        }
    }
}
