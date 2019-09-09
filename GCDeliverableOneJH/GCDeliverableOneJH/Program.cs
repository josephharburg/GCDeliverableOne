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
            decimal responseOne, responseTwo, responseThree;
            bool correctInput = true;
            while (correctInput == true)
            {
                Console.WriteLine("Welcome! Please enter 3 dollar amounts that you wish to be converted.");
                try
                {
                    responseOne = Convert.ToDecimal(Console.ReadLine());
                    responseTwo = Convert.ToDecimal(Console.ReadLine());
                    responseThree = Convert.ToDecimal(Console.ReadLine());
                    Calculations(responseOne,responseTwo,responseThree);
                    decimal total = responseOne + responseTwo + responseThree;
                    Console.WriteLine("The total of the three numbers in different currencies is as follows:" +
                        "\nUSA: {0}\nSwedish: {1}\nJapanese: {2}\nThai: {3}", total.ToString("C2"), 
                        total.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("sv-SE")), 
                        total.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("ja-JP")), 
                        total.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("th-TH")));
                    correctInput = false;
                }
                catch { Console.WriteLine("Im sorry, that is not a valid response, please try again!"); }
            }
            
        }
        private static void Calculations(decimal first, decimal second, decimal third)
        {
            decimal[] arrayOne = { first, second, third};
            decimal max = arrayOne.Max();
            decimal min = arrayOne.Min();
            decimal average = arrayOne.Average();
              Console.WriteLine("Your largest number is "
                + max + ".\nYour smallest number is " + min +
                ".\nThe average of the numbers is " + average);
             }
    }
}
