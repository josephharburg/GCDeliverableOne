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
            double average, smallest, largest, responseOne, responseTwo, responseThree;
            Console.WriteLine("Welcome to the currency format converter! Please enter 3 dollar amounts that you wish to be converted!");
            responseOne = Convert.ToDouble(Console.ReadLine());
            responseTwo = Convert.ToDouble(Console.ReadLine());
            responseThree = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}",responseOne, responseTwo, responseThree);
        }
    }
}
