using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting variable of 'Rand' to the Random Class Method and obstantiating Random() //
            var rand = new Random();
            // Settiing variable 'RandomList' to a list of intergers //
            var randomList = new List<int>();

            // Add a random number between 1 and 50 to the 'randomList' 21 times//
            for (int i = 1; i < 21; i++)
            {

                randomList.Add(rand.Next(1, 50));

            }
            // Print text and add seperate each number by a , in randomList. Print that into a string //
            Console.WriteLine($"20 Random Numbers between 1 and 50: { String.Join(',' ,randomList)}");

            // END //


            // Square each number that is printed in 'randonList' //

            // Declared variable 'squaredRandomList' to a new list of numbers //
            var squaredRandomList = new List<int>();

            // For every num in 'randomList', multpily num * itself and add it to the 'squaredRandomList'
            foreach (var num in randomList)
            {
                // Setting variable 'squaredNumber' equal to num * itself //
                var squareNumber = num * num;
                // Adding varibale 'swauredNumber' to 'squaredNumberList' //
                squaredRandomList.Add(squareNumber);
            }

            // Print text and add seperate each number by a , in 'squaredRandomList'. Print that into a string //
            Console.WriteLine($"Squared: { String.Join(',', squaredRandomList)}");

            // END //

            // Remove all odd numbers from the 'squaredRandomList'

            // If num is not divisable by 2, then remove it from the list //
            squaredRandomList.RemoveAll(num => num % 2 != 0);

            //Print text and add seperate each number by a , in 'squaredRandomList'. Print that into a string //
            Console.WriteLine($"Odd Numbers Removed: { String.Join(',', squaredRandomList)}");


        }
    }
}
