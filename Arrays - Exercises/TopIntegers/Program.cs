
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] separator = { " " }; 
        int[] numbers = Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        List<int> topIntegers = new List<int>();
        int maxRight = int.MinValue; // Initialize the maximum value to the minimum integer value

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] > maxRight)
            {
                maxRight = numbers[i];
                topIntegers.Add(numbers[i]);
            }
        }

        topIntegers.Reverse(); // Reverse the list to get the original order of top integers

        Console.WriteLine(string.Join(" ", topIntegers));
    }
}
