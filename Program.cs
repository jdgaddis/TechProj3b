/*
    Author: James Gaddis
    Date: 9/27/2020
    Comments: This C# console program will demonstrate an array with the size of 25 elements.
*/


using System;

namespace TechProj3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array will be executed below ...");
            Console.WriteLine("");
            Console.WriteLine("________________________________________");
            // Manually populated array from 1 to 25
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            // Foreach loop to have the code display in the Console
            foreach (int i in numbers)
            {
                Console.WriteLine("Element value = " + i);
            }
            Console.WriteLine("________________________________________");
        } // End of Main
    } // End of class
} // End of namespace
