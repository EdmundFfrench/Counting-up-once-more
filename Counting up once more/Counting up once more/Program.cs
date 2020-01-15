// Author: Ed French
// SID: EJF143
// Edited: 09/10/2019
using System;

namespace Counting_up_once_more
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable to store our total number
            int total = 1;
            bool carryOn = true;

            // inform user of initial total
            Console.WriteLine("Total currently: {0}", total);

            // prompt user for the number if iterations of adding up
            Console.WriteLine("enter the number of times to add up");
            int count = Convert.ToInt32(Console.ReadLine());

            ConsoleKeyInfo response = new ConsoleKeyInfo();
            if (count == 0)
            {
                Console.WriteLine("You have specified 0 iterations. Are you sure you wish to continue. Enter Y/N: ");
                response = Console.ReadKey();

                if (response.Key == ConsoleKey.Y)
                {
                    carryOn = true;
                }

            }

            if (carryOn)
            {
                // set count for do loop
                int i = 0;

                // loop until we reach user's value'
                while (i < count)
                {
                    total += 1;
                    Console.WriteLine("Total changed to: {0}", total);
                    i++;
                }
            }

            // Readline to stop window closing before we can read results.
            Console.ReadLine();
        }
    }
}
