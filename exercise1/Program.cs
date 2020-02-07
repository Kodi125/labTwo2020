/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 7 / 2 / 2020
 * Description : LAB SHEET TWO CODE SOLUTION, QUESTION 1 - using System.Linq;/Query syntax and Lambda Synta;
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var ouputNumbers = from number in numbers
                               where number > 5
                               orderby number descending
                               select number;

            foreach (int number in ouputNumbers)
            {
                Console.WriteLine(number.ToString());
            }
        }
    }
}
