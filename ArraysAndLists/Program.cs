using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            /* Create a list of type int
             * Name the list "evens"
             */

            var evens = new List<int>();
            var odds = new List<int>();


            /* Create another list of type int
             * Name the list "odds"
             */

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                    
                }
                else
                {
                    odds.Add(numbers[i]);
                    


                }


            }
            
            
            
             foreach (var num in numbers)
             {
                if (num % 2 == 0)
                {

                    evens.Add(num);
                    //Console.WriteLine($"{num} is an even number");
                }
                else
                {
                    odds.Add(num);
                    //Console.WriteLine($"{num} is definately an odd number");

                }

             }




            /* Using a foreach or for loops,
             * display each List of even and odd numbers
             * 
             * Try to be creative in your display
             */

            foreach (var item in evens)
            {
                Console.WriteLine($"{item} is an even number");

            }

            foreach (var oddNumber in odds)
            {
                Console.WriteLine($"{oddNumber} is def odd");
            }

        }
    }
}
